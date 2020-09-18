using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblDamage
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Mrnid { get; set; }
        public string Type { get; set; }
        public string MaterialType { get; set; }
        public string Material { get; set; }
        public string Qty { get; set; }
        public string Remarks { get; set; }
    }
}
