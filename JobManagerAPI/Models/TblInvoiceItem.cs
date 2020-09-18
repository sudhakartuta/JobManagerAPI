using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblInvoiceItem
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string JobcardId { get; set; }
        public string Invoice { get; set; }
        public string Jobtype { get; set; }
        public string MaterialType { get; set; }
        public string Itemcode { get; set; }
        public string Item { get; set; }
        public double? Itemcost { get; set; }
        public double? Totalitems { get; set; }
        public double? Amount { get; set; }
        public string Updatedby { get; set; }
    }
}
