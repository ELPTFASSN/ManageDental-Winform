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
    
    public partial class tb_examinetype
    {
        public tb_examinetype()
        {
            this.tb_examination = new HashSet<tb_examination>();
            this.tb_paramact = new HashSet<tb_paramact>();
        }
    
        public int ExamineTypeID { get; set; }
        public string ExamineTypeName { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParamPrescriptionID { get; set; }
    
        public virtual ICollection<tb_examination> tb_examination { get; set; }
        public virtual tb_paramprescription tb_paramprescription { get; set; }
        public virtual ICollection<tb_paramact> tb_paramact { get; set; }
    }
}
