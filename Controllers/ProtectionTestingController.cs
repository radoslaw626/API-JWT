using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace API_Protected_Endpoints.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectionTestingController : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            return "test";
        }





    }
}
