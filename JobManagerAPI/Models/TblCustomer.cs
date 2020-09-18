using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblCustomer
    {
        public int Id { get; set; }
        public int? Cid { get; set; }
        public string CustomerId { get; set; }
        public string Customer { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Bank { get; set; }
        public string BankAcNo { get; set; }
        public string Branch { get; set; }
        public string Ifsc { get; set; }
        public string Gstno { get; set; }
        public string Pan { get; set; }
        public string Aadhaar { get; set; }
        public string PlaceCity { get; set; }
        public string Br { get; set; }
    }
}
