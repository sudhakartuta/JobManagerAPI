using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblExpens
    {
        public int Id { get; set; }
        public DateTime? Expdate { get; set; }
        public string Trantype { get; set; }
        public string Expense { get; set; }
        public double? Totalamt { get; set; }
        public DateTime? Updatedon { get; set; }
        public string Updatedby { get; set; }
        public string Particulars { get; set; }
        public string Cheque { get; set; }
    }
}
