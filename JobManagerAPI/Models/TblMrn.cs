using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblMrn
    {
        public int Id { get; set; }
        public string Mrnid { get; set; }
        public int? MaterialId { get; set; }
        public string Type { get; set; }
        public string MaterialType { get; set; }
        public string BillInvoiceNo { get; set; }
        public DateTime? BillInvoiceDate { get; set; }
        public string Material { get; set; }
        public string Code { get; set; }
        public double? Qty { get; set; }
        public double? BalQty { get; set; }
        public double? Damages { get; set; }
        public string UnitType { get; set; }
        public double? PricePerUnit { get; set; }
        public double? Mrp { get; set; }
        public double? TranceportCharge { get; set; }
        public double? TotalAmt { get; set; }
        public string Remarks { get; set; }
        public string Updatedby { get; set; }
        public DateTime? Updatedon { get; set; }
        public double? L { get; set; }
        public double? W { get; set; }
        public double? Smts { get; set; }
        public double? SunitPrice { get; set; }
    }
}
