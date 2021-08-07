using GenericAPI.Contexts;
using GenericAPI.Models;
using GenericAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAPI.Repository
{
    public class CreditCardRepository : GenericRepository<CreditCard>,ICreditCardRepository
    {
        public CreditCardRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<CreditCard> GetCoolestCard()
        {
            return await GetAll().OrderByDescending(e => e.Name).FirstOrDefaultAsync();
        }
    }
}
