using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblJobcards
    {
        public int Id { get; set; }
        public int? Jobcardno { get; set; }
        public string JobcardId { get; set; }
        public string CustomerId { get; set; }
        public string JobType { get; set; }
        public string Itemcode { get; set; }
        public string Item { get; set; }
        public double? Totalitems { get; set; }
        public double? Balanceitems { get; set; }
        public double? Damages { get; set; }
        public double? Itemcost { get; set; }
        public double? MaterialCost { get; set; }
        public double? Westage { get; set; }
        public double? Totalexp { get; set; }
        public double? Totallabchrg { get; set; }
        public double? Mrp { get; set; }
        public double? TotalamtWop { get; set; }
        public int? ProfitPer { get; set; }
        public double? Profit { get; set; }
        public double? Totalamt { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdby { get; set; }
        public string Status { get; set; }
        public DateTime? Closedon { get; set; }
        public string Closedby { get; set; }
        public DateTime? Expected { get; set; }
    }
}
