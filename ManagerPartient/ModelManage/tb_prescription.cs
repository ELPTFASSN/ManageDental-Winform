//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagerPartient.ModelManage
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_prescription
    {
        public tb_prescription()
        {
            this.tb_prescription_detail = new HashSet<tb_prescription_detail>();
        }
    
        public int PrescriptionID { get; set; }
        public int ExaminationID { get; set; }
        public string EmployeeID { get; set; }
        public string PatientID { get; set; }
        public System.DateTime DateOfIssuee { get; set; }
        public string Description { get; set; }
    
        public virtual tb_employee tb_employee { get; set; }
        public virtual tb_examination tb_examination { get; set; }
        public virtual ICollection<tb_prescription_detail> tb_prescription_detail { get; set; }
    }
}
