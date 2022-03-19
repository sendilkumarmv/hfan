using HFan.Web.Application.Handlers;
using HFan.Web.Application.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HFan.Web.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerApplicationController : ControllerBase
    {
        private readonly IPublishApplication _publishApplication;
        private readonly ICustomerApplicationHandler _customerApplicationHandler;
        public CustomerApplicationController(
            IPublishApplication publishApplication,
            ICustomerApplicationHandler customerApplicationHandler
        )
        {
            _publishApplication = publishApplication;
            _customerApplicationHandler = customerApplicationHandler;   
        }

        // GET: api/<ApplicationController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CustomerApplication>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<CustomerApplication>> Get()
        {
            try
            {
                var result = _customerApplicationHandler.GetCustomerApplications();
                return Ok(result);
            }
            catch
            {
                return NoContent();
            }
        }

        // GET api/<ApplicationController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomerApplication), StatusCodes.Status200OK)]
        public ActionResult<CustomerApplication> Get(int id)
        {
            return NoContent();
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
