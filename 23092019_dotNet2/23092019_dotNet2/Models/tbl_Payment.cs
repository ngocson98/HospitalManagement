//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _23092019_dotNet2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Payment
    {
        public short id { get; set; }
        public string customerName { get; set; }
        public string phone { get; set; }
        public string serviceUnitName { get; set; }
        public string doctor { get; set; }
        public Nullable<decimal> totalFee { get; set; }
        public Nullable<decimal> paidFee { get; set; }
        public Nullable<decimal> debtFee { get; set; }
        public Nullable<short> billId { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public Nullable<System.DateTime> payTime { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> paymentType { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public Nullable<System.DateTime> createdTime { get; set; }
        public Nullable<System.DateTime> updatedTime { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
    
        public virtual tbl_MedicalBill tbl_MedicalBill { get; set; }
    }
}
