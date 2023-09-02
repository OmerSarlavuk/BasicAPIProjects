using Holding.Business.Interfaces;
using Holding.Model.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Holding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoldingController : ControllerBase
    {
        private readonly IHoldingService _holdingService;
        public HoldingController(IHoldingService holdingService)
        {
            _holdingService = holdingService;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _holdingService.GetAll();
        }

        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            return _holdingService.GetById(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _holdingService.Delete(id);
        }

        [HttpPost]
        public Student Post([FromBody] Student student) 
        {
            return _holdingService.Create(student);
        }

        [HttpPut]
        public Student PostById([FromBody] Student student) 
        {
            return _holdingService.Update(student);
        }
    }
}
