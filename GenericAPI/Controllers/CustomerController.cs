using GenericAPI.Models;
using GenericAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _repository;
       
        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Index()
        {
            return _repository.GetAll().ToList();
        }

        [HttpPost]
        public async Task Post([FromBody] Customer value)
        {
            value.CreateOn = DateTime.Now;
            value.UpdateOn = DateTime.Now;
            await _repository.CreatedAsync(value);
        }
    }
}
