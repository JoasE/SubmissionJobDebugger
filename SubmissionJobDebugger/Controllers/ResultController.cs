using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SubmissionJobDebugger.Dtos;

namespace SubmissionJobDebugger.Controllers
{
    [Route("api/receive_result")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        [HttpPut()]
        public IActionResult Get([FromBody] ValidationResult result)
        {
            Console.WriteLine("Received: \n" + JsonConvert.SerializeObject(result, Formatting.Indented));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}
