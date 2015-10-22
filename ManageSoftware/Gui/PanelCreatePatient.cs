using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSoftware.Core;
using ManageSoftware.Controller;
using ManageSoftware.ModelManage;
using ManageSoftware.CustomControl;

namespace ManageSoftware.Gui
{
    public partial class PanelCreatePatient : UserControl, IFormDialogMain
    {
        /**
         * Variable Gobal
         **/
        public delegate void HandleAutoCodePatient();
        public event HandleAutoCodePatient EventAutoCodePatient;
        private Boolean autoNumbering;
        private tb_person person;

        /**
         * Properties
         **/
        public PanelListPatient PanelListPatient { set; get; }

        public Boolean AutoNumbering
        {
            set
            {
                autoNumbering = value;
                if (value) EventAutoCodePatient();
            }
            get { return autoNumbering; }
        }

        /**
         * Methods
         **/
        public PanelCreatePatient()
        {
            InitializeComponent();
            InitGui();
            EventAutoCodePatient += AutoCodePatient;
            this.AutoNumbering = true;
        }

        private void InitGui()
        {
            this.dtpNgaySinh.ValueChanged += (x, y) =>
            {
                if (this.dtpNgaySinh.Checked)
                    this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
                else
                    this.dtpNgaySinh.CustomFormat = " ";
            };

            List<CustomControl.Item> itemsGender = new List<CustomControl.Item>();
            itemsGender.Add(new CustomControl.Item("Nam", "Male", null));
            itemsGender.Add(new CustomControl.Item("Nữ", "Female", null));
            itemsGender.Add(new CustomControl.Item("Khác", "Other", null));
            this.cbGioiTinh.Items = itemsGender;
            this.cbGioiTinh.DisplayMember = "Name";
            this.cbGioiTinh.ValueMember = "Value";

            List<CustomControl.Item> itemsMarital = new List<CustomControl.Item>();
            itemsMarital.Add(new CustomControl.Item("Độc thân", "Single", null));
            itemsMarital.Add(new CustomControl.Item("Đã kết hôn", "Married", null));
            itemsMarital.Add(new CustomControl.Item("Khác", "Other", null));
            this.cbHonNhan.Items = itemsMarital;
            this.cbHonNhan.DisplayMember = "Name";
            this.cbHonNhan.ValueMember = "Value";
        }

        public void SetData(tb_person _patient)
        {
            person = _patient;
            txtMaSo.Text = person.PersonID;
            txtHoTen.Text = person.FullName;
            cbGioiTinh.SelectedText = person.Gender;
            txtDiDong.Text = person.MobilePhone;
            if (person.Birthday != null)
            {
                this.dtpNgaySinh.Checked = true;
                dtpNgaySinh.Value = (DateTime)person.Birthday;
            }                
            else
            {
                this.dtpNgaySinh.Checked = false;
            }
            txtHomThu.Text = person.Email;
            if (person.Marital != null)
                cbHonNhan.SelectedValue = person.Marital;
            if (person.ProfessionID != null && !person.ProfessionID.Equals(""))
                cbNgheNghiep.SelectedValue = person.ProfessionID;
            txtDiaChi.Text = person.Address;
            txtGhiChu.Text = person.Note;

            SetEnableComponents(false);
        }

        private tb_person GetData()
        {
            person = new tb_person();
            person.PersonID = txtMaSo.Text;
            person.FullName = txtHoTen.Text;
            if(dtpNgaySinh.Checked)
                person.Birthday = new DateTime(dtpNgaySinh.Value.Year, dtpNgaySinh.Value.Month, dtpNgaySinh.Value.Day);           
            person.Address = txtDiaChi.Text;
            person.Gender = ((CustomControl.Item)cbGioiTinh.SelectedItem).Value;
            person.MobilePhone = txtDiDong.Text;
            person.Marital = ((CustomControl.Item)cbHonNhan.SelectedItem).Value;
            person.Email = txtHomThu.Text;
            person.Note = txtGhiChu.Text;
            
            return person;
        }

        private bool CheckDataInput()
        {
            // Thêm mới thông tin
            if (person == null)
            {
                // Kiểm tra có trùng mã ID
                tb_person _patient = PatientModelManage.Instance.FindPatientByCode(txtMaSo.Text);
                if (_patient != null)
                {
                    MessageBoxEX.DialogMessageBox("Thông báo", "Mã bệnh nhân đã tồn tại", "Vui lòng kiểm tra mã bệnh nhân. Mã này đã tồn tại trong hệ thống");
                    return false;
                }
            }
            // Sửa lại thông tin
            else
            {
                return true;
            }

            // Kiểm tra nhập tên khác rỗng
            if(txtHoTen.Text.Equals(""))
            {
                MessageBoxEX.DialogMessageBox("Thông báo", "Tên bệnh nhân không được để trống", "Trường tên không được để trống. Yêu cầu phải nhập tên bệnh nhân");
                return false;
            }

            return true;
        }

        private void SetEnableComponents(Boolean value)
        {
            txtMaSo.Enabled = value;
        }

        public void cancel()
        {
            this.ParentForm.Close();
        }

        public void finish()
        {
            bool flagSave = false;

            // Kiểm tra dữ liệu vào hợp lệ
            if (CheckDataInput())
            {

                if (person == null)
                    flagSave = PatientModelManage.Instance.CreatePerson(GetData());
                else flagSave = PatientModelManage.Instance.UpdatePerson(GetData());
                if (flagSave)
                {
                    PanelListPatient.RefeshDataTable(null);
                    ResetGui();
                    SetEnableComponents(true);
                }
            }

            if (!flagSave)
               MessageBoxEX.DialogMessageBox("Thông báo", "Lưu không thành công", "Chưa thực hiện được thao tác này. \n Vui lòng kiểm tra lại dữ liệu hoặc thao tác của bạn!");
        }

        public void ResetGui()
        {
            person = null;
            txtMaSo.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Checked = false;
            txtDiaChi.Text = "";
            cbGioiTinh.SelectedIndex = 0;
            txtDiDong.Text = "";
            txtHomThu.Text = "";
            txtGhiChu.Text = "";
        }

        public void AutoCodePatient()
        {
            int count = PatientModelManage.Instance.FindAllPatients().Count;
            DateTime dateNow = DateTime.Now;
            int month = dateNow.Month;
            int year = dateNow.Year;
            txtMaSo.TextDefault = (count + 1) + "" + month + "" + year.ToString().Substring(2, 2);
        }
    }
}
