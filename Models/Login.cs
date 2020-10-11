using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Login
    {
        public string Person { get; set; }
        public string Email { get; set; }
        public int Card { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
    }
}