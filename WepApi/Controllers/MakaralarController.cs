using Bussiness.Abstract;
using Bussiness.Concrate;
using DataAccess.EntityFramework;
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
    public class MakaralarController : ControllerBase
    {
        IMakaraService _makaraService;

        public MakaralarController(IMakaraService makaraService)
        {
            _makaraService = makaraService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result=  _makaraService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }

        [HttpPost]
        public IActionResult Add(Makara makara)
        {
            var result = _makaraService.Add(makara);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

