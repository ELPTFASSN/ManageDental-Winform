using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManageSoftware.Core;
using ManageSoftware.ModelManage;
using ManageSoftware.Controller;

namespace ManageSoftware.Gui
{
    public partial class TutorialExercise : UserControl, IFormDialogMain
    {
        private tb_person_exercise personExercise;
        private tb_exercise exercise;
        private tb_person person;

        public tb_person Person
        {
            get { return person; }
            set { person = value; }
        }

        public tb_exercise Exercise
        {
            get { return exercise; }
            set { 
                exercise = value;
                txtHuongDan.Text = this.Exercise.Description;
                txtLuuY.Text = this.Exercise.Note;
            }
        }

        public tb_person_exercise PersonExercise
        {
            get { return personExercise; }
            set { 
                personExercise = value;
            }
        }        

        public TutorialExercise()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void finish() 
        {
            this.ParentForm.Hide();
            ConfigPractice form = new ConfigPractice();
            form.TitleForm = exercise.Title;
            if (PersonExercise.ConfigID != null && PersonExercise.ConfigID != 0)
                form.Config = ExerciseModelManage.Instance.FindConfigPracticeByID(PersonExercise.ConfigID);
            else
                form.Config = ExerciseModelManage.Instance.FindConfigPracticeByID(Exercise.ConfigID_Default);
            form.ShowDialog();
            this.ParentForm.Close();
        }

        public void cancel() 
        {
            this.ParentForm.Close();
        }
    }
}
