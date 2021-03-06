﻿using HoneyWell.Flight.PriorityService.Api.Contracts;
using HoneyWell.Flight.PriorityService.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HoneyWell.Flight.PriorityService.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PriorityController : ControllerBase
    {
        private readonly ILogger<PriorityController> _logger;
        private readonly IProcessRules _processRules;

        public PriorityController(ILogger<PriorityController> logger, IProcessRules processRules)
        {
            _logger = logger;
            _processRules = processRules;
        }
        [HttpGet]
        public async Task<IActionResult> GetPriority(List<int> ruleItems)
        {
            var result = _processRules.ProcessFlightRules(ruleItems);
            return Ok(result);
        }
    }
}
