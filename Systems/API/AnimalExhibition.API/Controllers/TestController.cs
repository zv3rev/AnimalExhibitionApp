using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalExhibition.API.Controllers
{
    [Route("v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// Returns "hello" string
        /// </summary>
        [ProducesResponseType(typeof(String),200)]
        [ApiVersion("1.0")]
        [HttpGet("")]
        public string Get()
        {
            return "hello";
        }

        [ProducesResponseType(typeof(String), 200)]
        [ApiVersion("2.0")]
        [HttpGet("")]
        public string Get2()
        {
            return "ne hello";
        }

        [ProducesResponseType(typeof(String), 200)]
        [ApiVersion("3.0")]
        [HttpGet("")]
        public string Get3()
        {
            return "ne ne";
        }
    }
}
