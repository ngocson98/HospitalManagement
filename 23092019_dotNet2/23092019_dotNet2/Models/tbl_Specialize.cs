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

    public partial class tbl_Specialize
    {
        public short id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<int> status { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public Nullable<System.DateTime> createdTime { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public Nullable<System.DateTime> updatedtime { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
    }
}
