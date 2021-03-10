using System;
using Microsoft.AspNetCore.Mvc;

namespace SpireDocLicenseTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var helper = new DocumentHelper();
            helper.Run();
            return Ok(new { status = "Success", date = DateTime.Now });
        }
    }
}