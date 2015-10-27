using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatagridviewPagination
{
    class Employee
    {

        public Employee(int empid, string empname, string empdept)
        {
            this.empId = empid;
            this.empName = empname;
            this.empDept = empdept;

        }
        private int empId;

        public int Empid
        {
            get { return empId; }
            set { empId = value; }
        }

        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private string empDept;

        public string EmpDept
        {
            get { return empDept; }
            set { empDept = value; }
        }

    }
}
