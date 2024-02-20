using BookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs
{
    public class CustomerLoginMsgsDTO
    {
        public string? NameMsg { get; set; }
        public string? UserNameMsg { get; set; }
        public string? PasswordMsg { get; set; }
        public string? EmailMsg { get; set; }
        public string? PhoneMsg { get; set; }
        public CheckStatusEnum IsSavedMsg { get; set; }
    }
}
