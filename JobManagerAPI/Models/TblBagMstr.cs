using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblBagMstr
    {
        public int Id { get; set; }
        public string Bag { get; set; }
        public string BagCode { get; set; }
        public string Image { get; set; }
    }
}
