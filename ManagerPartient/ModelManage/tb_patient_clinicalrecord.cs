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
    
    public partial class tb_patient_clinicalrecord
    {
        public string PatientID { get; set; }
        public int ClinicalRecordID { get; set; }
        public string Note { get; set; }
    
        public virtual tb_clinicalrecord tb_clinicalrecord { get; set; }
    }
}
