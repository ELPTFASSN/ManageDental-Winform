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
    
    public partial class tb_prescription_detail
    {
        public int MedicineID { get; set; }
        public int PrescriptionID { get; set; }
        public int Quantity { get; set; }
        public string Direction { get; set; }
    
        public virtual tb_medicine tb_medicine { get; set; }
        public virtual tb_prescription tb_prescription { get; set; }
    }
}
