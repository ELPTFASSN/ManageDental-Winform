using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerPartient.Controller;
using ManagerPartient.ModelManage;
using ManagerPartient.Core;

namespace ManagerPartient.Gui
{
    public partial class PanelListPatient : UserControl, IFormPanelChild
    {
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note_Col;

        private int totalRecords;
        private int pageSize = 20;
        private List<tb_patient> dataShow = null;

        public event DisplayPanelHander DisplayPanelEvent;

        public PanelListPatient()
        {
            InitializeComponent();
            InitGui();
            SettingForm();
        }

        /**
         * Methods business
         **/
        public void InitGui()
        {
            this.txtTimDiaChi.ClearTextDefaultForcus = true;
            this.txtTimTen.ClearTextDefaultForcus = true;
            this.txtTuTimKiem.ClearTextDefaultForcus = true;

            List<CustomControl.Item> itemsTypeSearch = new List<CustomControl.Item>();
            itemsTypeSearch.Add(new CustomControl.Item("Tìm theo tên", "Name", null));
            itemsTypeSearch.Add(new CustomControl.Item("Tìm theo số di động", "MobilePhone", null));
            itemsTypeSearch.Add(new CustomControl.Item("Tìm theo địa chỉ", "Address", null));
            this.cbLoaiTimKiem.Items = itemsTypeSearch;

            List<CustomControl.Item> itemsTime = new List<CustomControl.Item>();
            itemsTime.Add(new CustomControl.Item("<Từ trước tới giờ>", "", null));
            itemsTime.Add(new CustomControl.Item("Hôm nay", "", null));
            itemsTime.Add(new CustomControl.Item("Tuần này", "", null));
            itemsTime.Add(new CustomControl.Item("3 tuần gần đây", "", null));
            itemsTime.Add(new CustomControl.Item("Tháng này", "", null));
            itemsTime.Add(new CustomControl.Item("3 tháng gần đây", "", null));
            this.cbThoiGian.Items = itemsTime;

            List<CustomControl.Item> itemsGender = new List<CustomControl.Item>();
            itemsGender.Add(new CustomControl.Item("<Tất cả giới tính>", "All", null));
            itemsGender.Add(new CustomControl.Item("Nam", "Male", null));
            itemsGender.Add(new CustomControl.Item("Nữ", "Female", null));
            itemsGender.Add(new CustomControl.Item("Khác", "Other", null));
            this.cbGioiTinh.Items = itemsGender;

            List<CustomControl.Item> itemsAge = new List<CustomControl.Item>();
            itemsAge.Add(new CustomControl.Item("<Mọi độ tuổi>", "All", null));
            itemsAge.Add(new CustomControl.Item("Dưới 5 tuổi", "<5", null));
            itemsAge.Add(new CustomControl.Item("Từ 5 - 10 tuổi", "5-10", null));
            itemsAge.Add(new CustomControl.Item("Từ 10 - 15 tuổi", "10-15", null));
            itemsAge.Add(new CustomControl.Item("Từ 15 - 30 tuổi", "15-30", null));
            itemsAge.Add(new CustomControl.Item("Từ 30 - 60 tuổi", "30-60", null));
            itemsAge.Add(new CustomControl.Item("Trên 60 tuổi", ">60", null));
            this.cbTuoi.Items = itemsAge;

            /*
             * DataGridView Customize
             */
            this.PatientID_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PatientID_Col.DataPropertyName = "PatientID";
            this.PatientID_Col.HeaderText = "Mã số";
            this.PatientID_Col.MinimumWidth = 20;
            this.PatientID_Col.Name = "PatientID";
            this.PatientID_Col.ReadOnly = true;
            this.PatientID_Col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientID_Col.ToolTipText = "Mã số bệnh nhân";
            this.PatientID_Col.Width = 70;

            this.FullName_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName_Col.DataPropertyName = "FullName";
            this.FullName_Col.HeaderText = "Họ và tên";
            this.FullName_Col.MinimumWidth = 20;
            this.FullName_Col.Name = "FullName";
            this.FullName_Col.ReadOnly = true;
            this.FullName_Col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FullName_Col.Width = 200;

            this.Gender_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender_Col.DataPropertyName = "Gender";
            this.Gender_Col.HeaderText = "Giới tính";
            this.Gender_Col.MinimumWidth = 20;
            this.Gender_Col.Name = "Gender";
            this.Gender_Col.ReadOnly = true;
            this.Gender_Col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gender_Col.Width = 80;

            this.Birthday_Col.DataPropertyName = "Birthday";
            this.Birthday_Col.HeaderText = "Ngày sinh";
            this.Birthday_Col.MinimumWidth = 20;
            this.Birthday_Col.Name = "Birthday";
            this.Birthday_Col.ReadOnly = true;
            this.Birthday_Col.Width = 79;

            this.Address_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address_Col.DataPropertyName = "Address";
            this.Address_Col.FillWeight = 65F;
            this.Address_Col.HeaderText = "Địa chỉ";
            this.Address_Col.MinimumWidth = 20;
            this.Address_Col.Name = "Address";
            this.Address_Col.ReadOnly = true;

            this.Note_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note_Col.DataPropertyName = "Note";
            this.Note_Col.FillWeight = 35F;
            this.Note_Col.HeaderText = "Ghi chú";
            this.Note_Col.Name = "Note";
            this.Note_Col.ReadOnly = true;

            this.grvDSBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID_Col,
            this.FullName_Col,
            this.Gender_Col,
            this.Birthday_Col,
            this.Address_Col,
            this.Note_Col});

            for (int i = 0; i < this.grvDSBenhNhan.ColumnCount; i++)
            {
                this.grvDSBenhNhan.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            this.grvDSBenhNhan.Columns["Birthday"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvDSBenhNhan.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grvDSBenhNhan.AutoGenerateColumns = false;

            bindingNavigator.BindingSource = bindingSource;
            bindingSource.CurrentChanged += new EventHandler(bindingSource_CurrentChanged);
            TotalPageDataTable(PatientModelManage.Instance.FindAllPatients());
        }

        public new void Hide()
        {
            base.Hide();
        }

        public new void Show()
        {
            base.Show();
        }

        public void SettingForm()
        {
            this.Dock = DockStyle.Fill;
            this.Name = typeof(PanelListPatient).Name;
        }

        public void FireDisplayPanelEvent()
        {
            if (DisplayPanelEvent != null)
                DisplayPanelEvent(this);
        }

        /**
         * Methods for event components
         **/
        #region Methods for event components

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefeshDataTable(dataShow);
        }

        private void TotalPageDataTable(List<tb_patient> _dataTable)
        {
            if (_dataTable == null)
                _dataTable = PatientModelManage.Instance.FindAllPatients();
            totalRecords = _dataTable.Count;
            var pageOffsets = new List<int>();
            for (int offset = 0; offset < totalRecords; offset += pageSize)
                pageOffsets.Add(offset);
            bindingSource.DataSource = pageOffsets;
        }

        public void RefeshDataTable(List<tb_patient> _dataTable)
        {
            //BindingList<tb_patient> bindlist = new BindingList<tb_patient>();

            if (bindingSource.Current != null)
            {
                int offsetRecord = (int)bindingSource.Current;
                if (_dataTable == null)
                    _dataTable = PatientModelManage.Instance.FindAllPatients();
                this.grvDSBenhNhan.DataSource = _dataTable.OrderBy(p => p.ID).Skip(offsetRecord).Take(pageSize).ToList();

                foreach (DataGridViewRow row in grvDSBenhNhan.Rows)
                {
                    if (grvDSBenhNhan.Rows[row.Index].Cells["Gender"].Value != null)
                        switch (grvDSBenhNhan.Rows[row.Index].Cells["Gender"].Value.ToString())
                        {
                            case "Male":
                                {
                                    grvDSBenhNhan.Rows[row.Index].Cells["Gender"].Value = "Nam";
                                } break;
                            case "Female":
                                {
                                    grvDSBenhNhan.Rows[row.Index].Cells["Gender"].Value = "Nữ";
                                } break;
                            case "Other":
                                {
                                    grvDSBenhNhan.Rows[row.Index].Cells["Gender"].Value = "Khác";
                                } break;
                        }
                }
            }
            else
            {
                if (_dataTable == null)
                    _dataTable = PatientModelManage.Instance.FindAllPatients();
                this.grvDSBenhNhan.DataSource = _dataTable.OrderBy(p => p.ID).Skip(0).Take(pageSize).ToList();
            }            
        }

        private void lblTimKiemNangCao_MouseEnter(object sender, EventArgs e)
        {
            this.lblTimKiemNangCao.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblTimKiemNangCao_MouseLeave(object sender, EventArgs e)
        {
            this.lblTimKiemNangCao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void lblTimKiemNangCao_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tableLayoutTimKiemNangCao.Visible)
            {
                this.tableLayoutTimKiem.Visible = this.tableLayoutTimKiemNangCao.Visible;
                this.tableLayoutTimKiemNangCao.Visible = !this.tableLayoutTimKiemNangCao.Visible;
                this.lblTimKiemNangCao.Text = "Tìm nâng cao";
            }
            else
            {
                this.tableLayoutTimKiem.Visible = this.tableLayoutTimKiemNangCao.Visible;
                this.tableLayoutTimKiemNangCao.Visible = !this.tableLayoutTimKiemNangCao.Visible;
                this.lblTimKiemNangCao.Text = "Tìm kiếm mặc định";
            }

        }

        private void grvDSBenhNhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.grvDSBenhNhan.CurrentRow != null)
            {
                tb_patient patient = (tb_patient)this.grvDSBenhNhan.CurrentRow.DataBoundItem;
                PanelCreatePatient panel = new PanelCreatePatient();
                panel.Dock = DockStyle.Fill;
                panel.PanelListPatient = this;
                panel.SetData(patient);
                FormDialogMain form = new FormDialogMain(panel);
                form.Text = "Chi tiết bệnh nhân";
                form.TitleForm = "Chi tiết hồ sơ bệnh nhân";
                form.DesciptionForm = "Hiển thị hồ sơ thông tin chi tiết của bệnh nhân";
                form.ShowDialog();
            }            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyWord = txtTuTimKiem.Text;
            List<tb_patient> patients = null;
            if ((!keyWord.Equals("") || !keyWord.Equals(txtTuTimKiem.TextDefault)) && txtTuTimKiem.ForeColor.Equals(SystemColors.ControlText))
            {
                bool exact = ckTimKiemChinhXac.Checked;
                patients = new List<tb_patient>();
                switch (((CustomControl.Item)cbLoaiTimKiem.SelectedItem).Value)
                {
                    case "Name":
                        patients = PatientModelManage.Instance.FindPatientByName(keyWord, exact);
                        break;
                    case "MobilePhone":
                        patients = PatientModelManage.Instance.FindPatientByMobile(keyWord, exact);
                        break;
                    case "Address":
                        patients = PatientModelManage.Instance.FindPatientByAddress(keyWord, exact);
                        break;
                    default:
                        break;
                }
            }
            
            dataShow = patients;
            TotalPageDataTable(dataShow);
        }

        private void btnTimKiemNangCao_Click(object sender, EventArgs e)
        {
            string name = txtTimTen.ForeColor.Equals(SystemColors.ControlDark) ? "" : txtTimTen.Text;
            string address = txtTimDiaChi.ForeColor.Equals(SystemColors.ControlDark) ? "":txtTimDiaChi.Text;
            string gender = cbGioiTinh.SelectedIndex==0?"":cbGioiTinh.SelectedValue.ToString();
            string age = cbTuoi.SelectedIndex == 0 ? "" : cbTuoi.SelectedValue.ToString();
            string time = cbThoiGian.SelectedIndex == 0 ? "" : cbThoiGian.SelectedValue.ToString();
            dataShow = PatientModelManage.Instance.FindPatientsByManyConds(name, address, gender, age, time);
            TotalPageDataTable(dataShow);
        }

        #endregion        

        private void grvDSBenhNhan_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.grvDSBenhNhan.ClearSelection();
                    this.grvDSBenhNhan.Rows[rowSelected].Selected = true;
                    this.contextMenuStrip.Show(this.grvDSBenhNhan, e.Location);
                    this.contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void mnButton_Del_Click(object sender, EventArgs e)
        {
            tb_patient patient = (tb_patient)this.grvDSBenhNhan.CurrentRow.DataBoundItem;
            bool flag = PatientModelManage.Instance.RemovePatient(patient.PatientID);
            if(flag)
            {
                Int32 rowToDelete = this.grvDSBenhNhan.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                this.dataShow.RemoveAt(rowToDelete);
                this.grvDSBenhNhan.ClearSelection();
            }
        }
        
    }
}
