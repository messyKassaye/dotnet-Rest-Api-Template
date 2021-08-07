using GenericAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAPI.Repository.Interfaces
{
   public interface ICreditCardRepository:IGenericRepository<CreditCard>
    {
        public Task<CreditCard> GetCoolestCard();
    }
}
