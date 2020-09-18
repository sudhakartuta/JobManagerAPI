using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblBalancePayment
    {
        public int Id { get; set; }
        public DateTime? Baldate { get; set; }
        public string Mrnid { get; set; }
        public string Suplier { get; set; }
        public double? Totalamt { get; set; }
        public double? Paid { get; set; }
        public double? Bal { get; set; }
    }
}
