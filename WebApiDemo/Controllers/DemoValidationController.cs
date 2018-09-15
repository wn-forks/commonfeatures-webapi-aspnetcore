﻿using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiDemo.Attributes;
using WebApiDemo.Models;
using WebApiDemo.Validators;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoValidationController : ControllerBase
    {
        private readonly ILogger<DemoValidationController> _logger;

        public DemoValidationController(ILogger<DemoValidationController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [ValidateModel]
        public IActionResult Post(User user)
        {
            _logger.LogInformation("Validation of user succeed");
            return NoContent();
        }
    }
}
