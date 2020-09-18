using System;
using System.Collections.Generic;

namespace JobManagerAPI.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccessLevel { get; set; }
    }
}
