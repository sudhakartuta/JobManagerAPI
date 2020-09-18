using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblInvoice
    {
        public int Id { get; set; }
        public int? InvoiceId { get; set; }
        public string Invoice { get; set; }
        public DateTime? Invoicedate { get; set; }
        public string CustomerId { get; set; }
        public double? Totalamt { get; set; }
        public double? Aftertax { get; set; }
        public double? Roundamount { get; set; }
        public double? Paidamt { get; set; }
        public double? Balance { get; set; }
        public double? Cgstp { get; set; }
        public double? Cgst { get; set; }
        public double? Sgstp { get; set; }
        public double? Sgst { get; set; }
        public double? Igstp { get; set; }
        public double? Igst { get; set; }
        public double? Misc { get; set; }
        public double? Transport { get; set; }
        public string TransportMode { get; set; }
        public string VechicleNumber { get; set; }
        public DateTime? SupplyDate { get; set; }
        public string SupplyPlace { get; set; }
        public string PaymentMode { get; set; }
        public string Tranno { get; set; }
        public string Updatedby { get; set; }
        public DateTime? Updatedon { get; set; }
    }
}
