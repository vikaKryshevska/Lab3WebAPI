using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab3WebAPI.Entities;
using Asp.Versioning;
using Lab3WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Lab3WebAPI.Models;

namespace Lab3WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Subscribers")]
    [ApiController]
    public class SubscribersController : ControllerBase
    {
            private readonly ILogger logger;
            private readonly AuthService authService;

            public SubscribersController(ILogger logger, AuthService authService)
            {
                this.authService = authService;
                this.logger = logger;
            }

            [Authorize]
            [HttpGet]
            public ActionResult<Subscriber[]> GetAll()
            {
                try
                {
                    throw new NotImplementedException();
                    return Ok();
                }
                catch (Exception error)
                {
                    logger.LogError(error.Message);
                    return StatusCode(500);
                }
            }

            
        }
}
