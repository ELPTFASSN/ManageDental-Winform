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
    
    public partial class tb_paramprescription
    {
        public tb_paramprescription()
        {
            this.tb_examinetype = new HashSet<tb_examinetype>();
            this.tb_paramprescription_medicine = new HashSet<tb_paramprescription_medicine>();
        }
    
        public int ParamPrescriptionID { get; set; }
        public string ParamPrescriptionName { get; set; }
        public string DoctorID { get; set; }
        public string Description { get; set; }
    
        public virtual tb_employee tb_employee { get; set; }
        public virtual ICollection<tb_examinetype> tb_examinetype { get; set; }
        public virtual ICollection<tb_paramprescription_medicine> tb_paramprescription_medicine { get; set; }
    }
}