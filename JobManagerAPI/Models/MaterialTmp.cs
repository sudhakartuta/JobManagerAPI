using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class MaterialTmp
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Typeofmaterial { get; set; }
        public string Material { get; set; }
        public string Code { get; set; }
        public double? Qty { get; set; }
        public string UnitType { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalAmt { get; set; }
        public string Updatedby { get; set; }
        public double? L { get; set; }
        public double? W { get; set; }
        public double? Smts { get; set; }
        public double? SunitPrice { get; set; }
    }
}
