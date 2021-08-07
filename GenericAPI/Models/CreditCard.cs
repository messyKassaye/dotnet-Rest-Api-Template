using GenericAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAPI.Models
{
    public class CreditCard : ICreditCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BankName { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}
