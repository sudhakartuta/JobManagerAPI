using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblJobcardsWorker
    {
        public int Id { get; set; }
        public int? MaterialId { get; set; }
        public string JobcardId { get; set; }
        public int? WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string Type { get; set; }
        public string MaterialType { get; set; }
        public string Material { get; set; }
        public double? Qty { get; set; }
        public double? PricePerUnit { get; set; }
        public double? Price { get; set; }
        public string UnitType { get; set; }
    }
}
