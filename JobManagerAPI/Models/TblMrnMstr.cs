using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblMrnMstr
    {
        public int Id { get; set; }
        public int? Mrn { get; set; }
        public string Mrnid { get; set; }
        public string SuplierId { get; set; }
        public string BillInvoiceNo { get; set; }
        public DateTime? BillInvoiceDate { get; set; }
        public double? InvoiceAmt { get; set; }
        public double? MiscAmt { get; set; }
        public double? TranceportCharge { get; set; }
        public double? PaidAmt { get; set; }
        public string PaymentMode { get; set; }
        public string TranNo { get; set; }
        public int? TotalAmt { get; set; }
        public int? BalAmt { get; set; }
        public string Remarks { get; set; }
    }
}
