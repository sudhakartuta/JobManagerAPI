using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class Bankdetails
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string Ifsc { get; set; }
    }
}
