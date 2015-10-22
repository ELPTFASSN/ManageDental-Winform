using ManageSoftware.ModelManage;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ManageSoftware.Controller
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

        public bool CreatePerson(tb_person _person)
        {
            using (database = new ModelEntities())
            {
                database.tb_person.Add(_person);
                database.SaveChanges();
                return true;
            }
        }

        public bool UpdatePerson(tb_person _person)
        {
            using (database = new ModelEntities())
            {
                tb_person patient = database.tb_person.SingleOrDefault(p => p.PersonID == _person.PersonID);
                patient.FullName = _person.FullName;
                patient.Birthday = _person.Birthday;
                patient.Address = _person.Address;
                patient.Gender = _person.Gender;
                patient.MobilePhone = _person.MobilePhone;
                patient.Email = _person.Email;
                patient.Marital = _person.Marital;
                patient.Note = _person.Note;

                database.SaveChanges();
                return true;
            }
        }

        public tb_person FindPatientByCode(String code)
        {
            using (database = new ModelEntities())
            {
                return database.tb_person.SingleOrDefault(p => p.PersonID == code);
            }
        }

        public List<tb_person> FindPatientByCode(String code, bool exact)
        {
            List<tb_person> list = null;
            using (database = new ModelEntities())
            {
                if (!exact)
                    list = database.tb_person.Where(p => p.PersonID.Contains(code)).ToList();
                else
                {
                    list = new List<tb_person>();
                    list.Add(database.tb_person.SingleOrDefault(p => p.PersonID == code));
                }
                    
                return list;
            }
        }

        public List<tb_person> FindPatientByName(String name, bool exact)
        {
            using (database = new ModelEntities())
            {
                if (!exact)
                    return database.tb_person.Where(p => p.FullName.Contains(name)).ToList();
                else
                    return database.tb_person.Where(p => p.FullName.Equals(name)).ToList();
            }
        }

        public List<tb_person> FindPatientByMobile(String mobile, bool exact)
        {
            using (database = new ModelEntities())
            {
                if (!exact)
                    return database.tb_person.Where(p => p.MobilePhone.Contains(mobile)).ToList();
                else
                    return database.tb_person.Where(p => p.MobilePhone.Equals(mobile)).ToList();
            }
        }

        public List<tb_person> FindPatientByAddress(String address, bool exact)
        {
            using (database = new ModelEntities())
            {
                if (!exact)
                    return database.tb_person.Where(p => p.Address.Contains(address)).ToList();
                else
                    return database.tb_person.Where(p => p.Address.Equals(address)).ToList();
            }
        }

        public List<tb_person> FindAllPatients()
        {
            using (database = new ModelEntities())
            {
                return database.tb_person.ToList();
            }
        }

        public List<tb_person> FindPatientsByManyConds(String name, String address, String gender, String age, String time)
        {
            using (database = new ModelEntities())
            {
                var query = database.tb_person.AsQueryable();
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
