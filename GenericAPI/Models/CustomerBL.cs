using GenericAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAPI.Models
{
    public class CustomerBL
    {
        private IGenericRepository<Customer> _repository { get; set; }

        public CustomerBL(IGenericRepository<Customer> repository)
        {
            _repository = repository;
        }

        public List<Customer> GetAllCustomer()
        {
            var result = new List<Customer>();
            result = _repository.GetAll().ToList();
            return result;
        }
    }
}
