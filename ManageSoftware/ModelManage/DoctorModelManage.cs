//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ManagerPartient.ModelManage
//{
//    class DoctorModelManage
//    {
//        private ModelEntities database;
//        public static DoctorModelManage instance;
//        public DoctorModelManage() 
//        {
//            database = new ModelEntities();
//        }

//        public static DoctorModelManage Instance()
//        {
//            if (instance == null)
//            {
//                instance = new DoctorModelManage();
//            }
//            return instance;
//        }

//        public IEnumerable<Object> getAllBacSy()
//        {
//            IEnumerable<Object> list = database.tb_employee;
//            return list;
//        }
//    }
//}
