using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblCashbook
    {
        public int Id { get; set; }
        public DateTime? Datec { get; set; }
        public string DParticulars { get; set; }
        public string DDetails { get; set; }
        public string DRef { get; set; }
        public double? DAmount { get; set; }
        public string CParticulars { get; set; }
        public string CDetails { get; set; }
        public string CRef { get; set; }
        public double? CAmount { get; set; }
    }
}
