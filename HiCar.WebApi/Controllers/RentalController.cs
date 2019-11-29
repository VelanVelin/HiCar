using System.Net;
using HiCar.Logic.Entities;
using HiCar.Logic.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HiCar.WebApi.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RentalController : BaseController
    {
        private readonly Messages _messages;

        public RentalController(Messages messages)
        {
            _messages = messages;
        }

        //[HttpPost]
        //public IActionResult RentCar()
        //{
        //    return new OkResult();
        //}
        //[HttpPost]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public IActionResult ReturnCar()
        //{
        //    return new OkResult();
        //}

        /// <summary>
        /// Gets rental for customer
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getRental")]
        [ProducesResponseType(typeof(Customer), (int)HttpStatusCode.OK)]
        public IActionResult GetRental()
        {
            return new OkObjectResult(new Customer()
            {
                
            });
        }
    }
}