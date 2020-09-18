using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblWestage
    {
        public int Id { get; set; }
        public string Wrkid { get; set; }
        public string Mid { get; set; }
        public string Material { get; set; }
        public double? W { get; set; }
        public double? L { get; set; }
        public double? Smts { get; set; }
        public double? Unitprice { get; set; }
        public double? Units { get; set; }
        public double? Bal { get; set; }
        public double? Price { get; set; }
    }
}
