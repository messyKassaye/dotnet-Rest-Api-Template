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
    public class CreditCardController : ControllerBase
    {
        private ICreditCardRepository _repository;

        public CreditCardController(ICreditCardRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CreditCard>> Index()
        {
            return _repository.GetAll().ToList();
        }

        [HttpPost]
        public async Task Post([FromBody] CreditCard value)
        {
            var entity = value;
            entity.CreateOn = DateTime.Now;
            entity.UpdateOn = DateTime.Now;
            await _repository.CreatedAsync(entity);
        }
    }
}
