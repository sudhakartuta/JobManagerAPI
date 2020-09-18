using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblMaterials
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string MaterialType { get; set; }
        public string Code { get; set; }
        public string Material { get; set; }
        public string Imgpath { get; set; }
    }
}
