using HFan.Web.Application.Handlers;
using HFan.Web.Application.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HFan.Web.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IPublishApplication _publishApplication;
        public ApplicationController(IPublishApplication publishApplication)
        {
            _publishApplication = publishApplication;
        }

        // GET: api/<ApplicationController>
        [HttpGet]
        public IEnumerable<CustomerApplication> Get()
        {
            return new List<CustomerApplication>(); 
        }

        // GET api/<ApplicationController>/5
        [HttpGet("{id}")]
        public CustomerApplication Get(int id)
        {
            return new CustomerApplication();
        }

        // POST api/<ApplicationController>
        [HttpPost]
        public bool Post([FromBody] CustomerApplication value)
        {
            _publishApplication.Publish(value);
            return true;
        }

        // PUT api/<ApplicationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerApplication value)
        {

        }

        // DELETE api/<ApplicationController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {

        }
    }
}
