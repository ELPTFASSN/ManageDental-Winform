using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerPartient.Core;
using ManagerPartient.Controller;
using ManagerPartient.ModelManage;
using ManagerPartient.CustomControl;

namespace ManagerPartient.Gui
{
    public partial class PanelCreatePatient : UserControl, IFormDialogMain
    {
        /**
         * Variable Gobal
         **/
        public delegate void HandleAutoCodePatient();
        public event HandleAutoCodePatient EventAutoCodePatient;
        private Boolean autoNumbering;
        private tb_patient patient;

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

            List<tb_profession> professions = PatientModelManage.Instance.FindAllProfession();
            this.cbNgheNghiep.DataSource = professions;
            this.cbNgheNghiep.DisplayMember = "ProfessionName";
            this.cbNgheNghiep.ValueMember = "ProfessionID";
        }

        public void SetData(tb_patient _patient)
        {
            patient = _patient;
            txtMaSo.Text = patient.PatientID;
            txtHoTen.Text = patient.FullName;
            cbGioiTinh.SelectedText = patient.Gender;
            txtDiDong.Text = patient.MobilePhone;
            if (patient.Birthday != null)
            {
                this.dtpNgaySinh.Checked = true;
                dtpNgaySinh.Value = (DateTime)patient.Birthday;
            }                
            else
            {
                this.dtpNgaySinh.Checked = false;
            }
            txtHomThu.Text = patient.Email;
            if (patient.Marital != null)
                cbHonNhan.SelectedValue = patient.Marital;
            if (patient.ProfessionID != null && !patient.ProfessionID.Equals(""))
                cbNgheNghiep.SelectedValue = patient.ProfessionID;
            txtDiaChi.Text = patient.Address;
            txtGhiChu.Text = patient.Note;

            SetEnableComponents(false);
        }

        private tb_patient GetData()
        {
            patient = new tb_patient();
            patient.PatientID = txtMaSo.Text;
            patient.FullName = txtHoTen.Text;
            if(dtpNgaySinh.Checked)
                patient.Birthday = new DateTime(dtpNgaySinh.Value.Year, dtpNgaySinh.Value.Month, dtpNgaySinh.Value.Day);           
            patient.Address = txtDiaChi.Text;
            patient.Gender = ((CustomControl.Item)cbGioiTinh.SelectedItem).Value;
            patient.MobilePhone = txtDiDong.Text;
            patient.Marital = ((CustomControl.Item)cbHonNhan.SelectedItem).Value;
            if (cbNgheNghiep.SelectedItem != null)
                patient.tb_profession = (tb_profession)cbNgheNghiep.SelectedItem;
            patient.Email = txtHomThu.Text;
            patient.Note = txtGhiChu.Text;
            
            return patient;
        }

        private bool CheckDataInput()
        {
            // Thêm mới thông tin
            if (patient == null)
            {
                // Kiểm tra có trùng mã ID
                tb_patient _patient = PatientModelManage.Instance.FindPatientByCode(txtMaSo.Text);
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

                if (patient == null)
                    flagSave = PatientModelManage.Instance.CreatePatient(GetData());
                else flagSave = PatientModelManage.Instance.UpdatePatient(GetData());
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
            patient = null;
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
