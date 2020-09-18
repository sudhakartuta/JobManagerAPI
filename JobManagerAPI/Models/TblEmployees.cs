using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblEmployees
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string EmpName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Exist { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? Dor { get; set; }
        public string Remarks { get; set; }
        public double? Salary { get; set; }
    }
}
