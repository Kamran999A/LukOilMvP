using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukoilMVP.Models
{
    public class PetrolPaymentOperation
    {
        public int PetrolPaymentOperationID { get; set; }
        public Petrol Petrol { get; set; }
        public bool IsBoughtLitr { get; set; }
        public decimal BoughtPrice { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public override string ToString()
        {
            string state = IsBoughtLitr ? "Bought with litr" : "Bought with price";
            return $"Name: {Petrol.Name}, Initial Price: {Petrol.InitialPrice:C}, {state}, Bought Price: {BoughtPrice:C}, Date: {Date}";
        }

    }
}
