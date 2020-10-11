using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Purchase
    {

        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Number { get; set; }
        public int CoffeeId { get; set; }
        public DateTime Date { get; set; }
    }
}