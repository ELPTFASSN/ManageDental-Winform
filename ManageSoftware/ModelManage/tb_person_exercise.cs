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
    
    public partial class tb_person_exercise
    {
        public int ID { get; set; }
        public string PersonID { get; set; }
        public Nullable<int> ExerciseID { get; set; }
        public string Result { get; set; }
        public Nullable<int> ConfigID { get; set; }
    
        public virtual tb_exercise tb_exercise { get; set; }
        public virtual tb_person tb_person { get; set; }
    }
}