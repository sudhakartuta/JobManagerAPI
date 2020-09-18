using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblExpenseMstr
    {
        public int Id { get; set; }
        public string TransactionType { get; set; }
        public string ExpenceType { get; set; }
        public string Fileds { get; set; }
    }
}
