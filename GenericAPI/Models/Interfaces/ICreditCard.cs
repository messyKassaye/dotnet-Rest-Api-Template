using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAPI.Models.Interfaces
{
   public interface ICreditCard:IEntity
    {
        public string Name { get; set; }
        public string BankName { get; set; }
    }
}
