//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageSoftware.ModelManage
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_config_practice
    {
        public tb_config_practice()
        {
            this.tb_exercise = new HashSet<tb_exercise>();
        }
    
        public int ConfigID { get; set; }
        public Nullable<int> LiftingPower { get; set; }
        public Nullable<int> Rate { get; set; }
        public Nullable<int> RunTime { get; set; }
        public string Note { get; set; }
    
        public virtual ICollection<tb_exercise> tb_exercise { get; set; }
    }
}