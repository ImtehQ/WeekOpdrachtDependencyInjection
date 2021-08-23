﻿using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiController : ControllerBase
    {
        private readonly ICalculatePiService calculatePiService;

        public PiController(ICalculatePiService CalculatePiService)
        {
            calculatePiService = CalculatePiService;
        }

        [HttpGet]
        [Route("add/{number}")]
        public IActionResult Add(int number)
        {
            return Ok(new
            {
                result = (calculatePiService.Add(number))
            });
        }

        [HttpGet]
        [Route("minus/{number}")]
        public IActionResult Minus(int number)
        {
            return Ok(new
            {
                result = (calculatePiService.Minus(number))
            });
        }
    }
}
