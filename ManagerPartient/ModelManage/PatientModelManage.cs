using ManagerPartient.ModelManage;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ManagerPartient.Controller
{
    class PatientModelManage
    {
        /**
         * Variable Gobal
         **/
        private ModelEntities database;
        private static PatientModelManage instance;

        /**
         * Properties
         **/
        public static PatientModelManage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PatientModelManage();
                }
                return PatientModelManage.instance;
            }
        }

        public PatientModelManage() { }

        public bool CreatePatient(tb_patient _patient)
        {
            using (database = new ModelEntities())
            {
                database.tb_patient.Add(_patient);
                database.SaveChanges();
                return true;
            }
        }

        public bool UpdatePatient(tb_patient _patient)
        {
            using (database = new ModelEntities())
            {
                tb_patient patient = database.tb_patient.SingleOrDefault(p => p.PatientID == _patient.PatientID);
                patient.FullName = _patient.FullName;
                patient.Birthday = _patient.Birthday;
                patient.Address = _patient.Address;
                patient.Gender = _patient.Gender;
                patient.MobilePhone = _patient.MobilePhone;
                patient.Email = _patient.Email;
                patient.ProfessionID = _patient.tb_profession.ProfessionID;
                patient.Marital = _patient.Marital;
                patient.Note = _patient.Note;

                database.SaveChanges();
                return true;
            }
        }

        public tb_patient FindPatientByCode(String code)
        {
            using (database = new ModelEntities())
            {
                return database.tb_patient.SingleOrDefault(p => p.PatientID == code);
            }
        }

        public List<tb_patient> FindPatientByCode(String code, bool exact)
        {
            List<tb_patient> list = null;
            using (database = new ModelEntities())
            {
                if (!exact)
                    list = database.tb_patient.Where(p => p.PatientID.Contains(code)).ToList();
                else
                {
                    list = new List<tb_patient>();
                    list.Add(database.tb_patient.SingleOrDefault(p => p.PatientID == code));
                }
                    
                return list;
            }
        }

        public List<tb_patient> FindPatientByName(String name, bool exact)
        {
            using (database = new ModelEntities())
            {
                if (!exact)
                    return database.tb_patient.Where(p => p.FullName.Contains(name)).ToList();
                else
                    return database.tb_patient.Where(p => p.FullName.Equals(name)).ToList();
            }
        }

        public List<tb_patient> FindPatientByMobile(String mobile, bool exact)
        {
            using (database = new ModelEntities())
            {
                if (!exact)
                    return database.tb_patient.Where(p => p.MobilePhone.Contains(mobile)).ToList();
                else
                    return database.tb_patient.Where(p => p.MobilePhone.Equals(mobile)).ToList();
            }
        }

        public List<tb_patient> FindPatientByAddress(String address, bool exact)
        {
            using (database = new ModelEntities())
            {
                if (!exact)
                    return database.tb_patient.Where(p => p.Address.Contains(address)).ToList();
                else
                    return database.tb_patient.Where(p => p.Address.Equals(address)).ToList();
            }
        }

        public List<tb_patient> FindAllPatients()
        {
            using (database = new ModelEntities())
            {
                return database.tb_patient.ToList();
            }
        }

        public List<tb_patient> FindPatientsByManyConds(String name, String address, String gender, String age, String time)
        {
            using (database = new ModelEntities())
            {
                var query = database.tb_patient.AsQueryable();
                if (name != null && !name.Equals(""))
                    query = query.Where(p => p.FullName.Contains(name));
                if (address != null && !address.Equals(""))
                    query = query.Where(p => p.Address.Contains(address));
                if (gender != null && !gender.Equals(""))
                    query = query.Where(p => p.Gender.Equals(gender));
                switch (age.ToString())
                {
                    case "<5":
                        query = query.Where(p => p.Birthday >= DbFunctions.AddYears(DateTime.Now, -5));
                        break;
                    case "5-10":
                        query = query.Where(p => p.Birthday >= DbFunctions.AddYears(DateTime.Now, -10) && p.Birthday <= DbFunctions.AddYears(DateTime.Now, -5));
                        break;
                    case "10-15":
                        query = query.Where(p => p.Birthday >= DbFunctions.AddYears(DateTime.Now, -15) && p.Birthday <= DbFunctions.AddYears(DateTime.Now, -10));
                        break;
                    case "15-30":
                        query = query.Where(p => p.Birthday >= DbFunctions.AddYears(DateTime.Now, -30) && p.Birthday <= DbFunctions.AddYears(DateTime.Now, -15));
                        break;
                    case "30-60":
                        query = query.Where(p => p.Birthday >= DbFunctions.AddYears(DateTime.Now, -60) && p.Birthday <= DbFunctions.AddYears(DateTime.Now, -30));
                        break;
                    case ">60":
                        query = query.Where(p => p.Birthday <= DbFunctions.AddYears(DateTime.Now, -60));
                        break;
                }

                return query.ToList();
            }
        }        

        public List<tb_profession> FindAllProfession()
        {
            using (database = new ModelEntities())
            {
                return database.tb_profession.ToList();
            }
        }
    }

    // public static class PagingUtils<T>
    //{
    //    public static IEnumerable<T> Page(this IEnumerable<T> en, int pageSize, int page)
    //    {
    //        return en.Skip(page * pageSize).Take(pageSize);
    //    }
    //    public static IQueryable<T> Page(this IQueryable<T> en, int pageSize, int page)
    //    {
    //        return en.Skip(page * pageSize).Take(pageSize);
    //    }
    //}
}
