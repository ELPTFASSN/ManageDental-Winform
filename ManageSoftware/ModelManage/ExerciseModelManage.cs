using ManageSoftware.ModelManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoftware.Controller
{
    class ExerciseModelManage
    {
        private static ExerciseModelManage instance;
        private ModelEntities database;

        public static ExerciseModelManage Instance
        {
            get 
            {
                if (instance == null)
                    instance = new ExerciseModelManage();
                return instance;           
            }
            set { instance = value; }
        }

        public ExerciseModelManage() { }

        public List<tb_exercise> FindAllExercise()
        {
            using (this.database = new ModelEntities())
            {
                return this.database.tb_exercise.ToList();
            }
        }

        public tb_exercise FindExerciseByID(int ID)
        {
            using (this.database = new ModelEntities())
            {
                return this.database.tb_exercise.SingleOrDefault(e=>e.ExerciseID == ID);
            }
        }

        public tb_person_exercise FindPersonExercise(string personID, int exerciseID)
        {
            using (this.database = new ModelEntities())
            {
                return this.database.tb_person_exercise.SingleOrDefault(e => e.ExerciseID == exerciseID && e.PersonID == personID);
            }
        }

        public List<tb_exercise> FindExerciseByPerson(string personID)
        {
            using (this.database = new ModelEntities())
            {
                return this.database.tb_person_exercise.Where(e=>e.PersonID == personID).Select(e=>e.tb_exercise).ToList();
            }
        }

        public tb_config_practice FindConfigPracticeByID(int? configID)
        {
            using (this.database = new ModelEntities())
            {
                return this.database.tb_config_practice.SingleOrDefault(e => e.ConfigID == configID);
            }
        }
    }
}
