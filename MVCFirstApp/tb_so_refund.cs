//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCFirstApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_so_refund
    {
        public decimal so_id { get; set; }
        public byte refund_line { get; set; }
        public byte refund_type { get; set; }
        public string reason { get; set; }
        public string pay_type { get; set; }
        public string curr_id { get; set; }
        public decimal amount { get; set; }
        public byte refund_status { get; set; }
        public System.DateTime refund_date { get; set; }
    }
}
