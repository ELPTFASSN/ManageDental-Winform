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
    
    public partial class tb_clinicalrecord
    {
        public tb_clinicalrecord()
        {
            this.tb_patient_clinicalrecord = new HashSet<tb_patient_clinicalrecord>();
        }
    
        public int ClinicalRecordID { get; set; }
        public string ClinicalRecordName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<tb_patient_clinicalrecord> tb_patient_clinicalrecord { get; set; }
    }
}
