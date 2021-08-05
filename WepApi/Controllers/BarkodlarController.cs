using Bussiness.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarkodlarController : ControllerBase
    {
        IBarkodService _barkodService;

        public BarkodlarController(IBarkodService barkodService)
        {
            _barkodService = barkodService;
        }

        [HttpPost]
        public IActionResult Add(Barkod barkod)
        {
            var result = _barkodService.Add(barkod);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
