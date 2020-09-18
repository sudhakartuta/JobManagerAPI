using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblEstimationProduction
    {
        public int Uid { get; set; }
        public int Id { get; set; }
        public DateTime? Proddate { get; set; }
        public string JobcardId { get; set; }
        public int? WorkerId { get; set; }
        public string Workername { get; set; }
        public string Jobtype { get; set; }
        public double? Qty { get; set; }
        public double? Dayofwork { get; set; }
        public double? Cost { get; set; }
    }
}
