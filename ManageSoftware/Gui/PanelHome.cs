using System;
using System.Drawing;
using System.Windows.Forms;
using ManageSoftware.CustomControl;
using ManageSoftware.Core;
using ManageSoftware.ModelManage;
using ManageSoftware.Controller;
using System.Collections.Generic;
#region Assembly mscorlib.dll, v4.0.0.0
// C:\Program Files\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\mscorlib.dll
#endregion

namespace ManageSoftware.Gui
{
    public partial class PanelHome : UserControl, IFormPanelChild
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point pnt);
        private MouseMoveMessageFilter mouseMessageFilter;
        public event DisplayPanelHander DisplayPanelEvent;
        private tb_person person;
        private List<tb_exercise> exercisesOwn;

        public tb_person Person
        {
            get { return person; }
            set { 
                person = value;
                exercisesOwn = ExerciseModelManage.Instance.FindExerciseByPerson(person.PersonID);
                foreach (Control c in flowLayoutPanel.Controls)
                {
                    ButtonFunction btn = ((ButtonFunction)c);
                    int exerciseID = Int32.Parse(btn.Name.Split('-')[1]);
                    if (exercisesOwn != null && exercisesOwn.Exists(p => p.ExerciseID == exerciseID))
                        btn.TablePanelMainBackColor = SystemColors.Highlight;
                }
            }
        }

        public PanelHome()
        {
            InitializeComponent();
            SettingForm();
            this.mouseMessageFilter = new MouseMoveMessageFilter();
            this.mouseMessageFilter.TargetForm = this;
            StartFiltering(this.mouseMessageFilter);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelHome));
            flowLayoutPanel.SuspendLayout();
            List<tb_exercise> exercises = ExerciseModelManage.Instance.FindAllExercise();
            foreach(tb_exercise e in exercises)
            {                
                ButtonFunction button = new ButtonFunction();
                button.GroupButtonName = "ButtonFunction";
                button.Margin = new System.Windows.Forms.Padding(5);
                button.Name = "btn" + "-" + e.ExerciseID;
                button.NameButtonText = e.Title;
                button.PtrBoxImage = ((System.Drawing.Image)(resources.GetObject("telephony__icon")));
                button.Size = new System.Drawing.Size(325, 110);
                button.TabIndex = 1;
                button.TablePanelMainBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(178)))), ((int)(((byte)(183)))));
                button.TablePanelMainBackgroundImage = null;
                button.TextDescription3 = "- Kết quả tập luyện";
                button.TextDescription1 = "- Giới thiệu bài tập";
                button.TextDescription2 = "- Tình trạng sức khỏe";
                flowLayoutPanel.Controls.Add(button);
            }            
            flowLayoutPanel.ResumeLayout();
        }

        /**
         *Business Methods
         **/
        private void StopFiltering(IMessageFilter value)
        {
            Application.RemoveMessageFilter(value);
        }

        private void StartFiltering(IMessageFilter value)
        {
            StopFiltering(value);
            Application.AddMessageFilter(value);
        }

        public new void Hide()
        {
            base.Hide();
            StopFiltering(this.mouseMessageFilter);
        }

        public new void Show()
        {
            base.Show();
            StartFiltering(this.mouseMessageFilter);
        }

        public void SettingForm()
        {
            this.Dock = DockStyle.Fill;
            this.Name = typeof(PanelHome).Name;
        }

        /**
         ************Event Button Function*******************
         **/

        private void MouseButtonClick(String ButtonName)
        {
            String[] splitString = ButtonName.Split('-');
            int exerciseID = Int32.Parse(splitString[1]);
            tb_person_exercise pexe = ExerciseModelManage.Instance.FindPersonExercise(Person.PersonID, exerciseID);
            tb_exercise exercise = ExerciseModelManage.Instance.FindExerciseByID(exerciseID);
            if(pexe == null)
                pexe = new tb_person_exercise()
                {
                    PersonID = Person.PersonID,
                    ExerciseID = exerciseID
                };
            TutorialExercise panel = new TutorialExercise();
            panel.PersonExercise = pexe;
            panel.Exercise = exercise;
            panel.Person = person;
            FormDialogMain form = new FormDialogMain(panel);
            form.Text = "Bài tập luyện chi tiết";
            form.TitleForm = exercise.Title;
            form.DesciptionForm = "Mô tả chung chung về bài tập luyện";
            form.ShowDialog();
        }        

        class MouseMoveMessageFilter : IMessageFilter
        {
            public PanelHome TargetForm { get; set; }
            //ButtonFunction buttonTemp = null;
            public bool PreFilterMessage(ref Message m)
            {
                // Vị trí con trỏ chuột so với tablePanelRight
                Point mousePosition = this.TargetForm.PointToClient(MousePosition);
                // Kiểm tra vị trí con trỏ chuột này có nằm trong tablePanelRight không?
                if (this.TargetForm.ClientRectangle.Contains(mousePosition))
                {
                    // Bắt đầu Message
                    int numMsg = m.Msg;
                    // Message chuột di chuyển
                    if (numMsg == 0x0200 /*WM_MOUSEMOVE*/)
                    {
                        
                        Point p = this.TargetForm.PointToClient(MousePosition);
                        IntPtr hWnd = WindowFromPoint(MousePosition);
                        if (hWnd != IntPtr.Zero)
                        {
                            Control ctl = Control.FromHandle(hWnd);

                            if (ctl != null)
                            {                                
                                foreach(Control c in this.TargetForm.flowLayoutPanel.Controls)
                                {
                                    if (((ButtonFunction)c).ClientRectangle.Contains(((ButtonFunction)c).PointToClient(MousePosition)))
                                    {
                                        ((ButtonFunction)c).TablePanelMainBackColor = Color.Orange;
                                        break;
                                    }
                                    else
                                    {
                                        ((ButtonFunction)c).TablePanelMainBackColor = ((ButtonFunction)c).ColorOriginal;
                                    }                                   
                                }
                            }                            
                        }
                    }
                    // Message chuột trái ấn
                    if (numMsg == 0x0202 /*WM_LBUTTONUP*/)
                    {
                        IntPtr hWnd = WindowFromPoint(MousePosition);
                        if (hWnd != IntPtr.Zero)
                        {
                            Control ctl = Control.FromHandle(hWnd);
                            if (ctl != null)
                            {
                                String nameButton = "";
                                Control child = ctl;
                                while (child != null)
                                {
                                    if(child.Name.Contains("btn-")) 
                                    {
                                        nameButton = child.Name;
                                        break;
                                    } 
                                    else
                                    {
                                        if (child.Name == "flowLayoutPanel")
                                        {
                                            nameButton = "";
                                            break;
                                        }
                                    }                                    
                                    
                                    child = child.Parent;
                                }

                                if (nameButton != "")
                                {
                                    this.TargetForm.MouseButtonClick(nameButton);
                                }
                            }                                                   
                        }
                    }
                }
                else
                {
                    foreach (Control c in this.TargetForm.flowLayoutPanel.Controls)
                    {
                        ButtonFunction btn = (ButtonFunction)c;
                        btn.TablePanelMainBackColor = btn.ColorOriginal;
                    }
                }               
                return false;
            }
        }
        
    }
}
