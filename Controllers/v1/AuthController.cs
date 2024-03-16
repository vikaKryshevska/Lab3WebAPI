using Asp.Versioning;
using AutoMapper;
using Lab3WebAPI.Entities;
using Lab3WebAPI.Models;
using Lab3WebAPI.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab3WebAPI.Controllers.v1
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Subscribers")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IMapper mapper;
        private readonly ILogger logger;
        private readonly AuthService authService;

        public AuthController(ILogger logger, AuthService authService, IMapper mapper)
        {
            this.authService = authService;
            this.mapper = mapper;
            this.logger = logger;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public ActionResult<string> Login(LoginRequestModel userModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (this.authService.IsAuthenticated(userModel.Name, userModel.Password))
                    {
                        var user = this.authService.GetByName(userModel.Name);
                        var token = this.authService.GenerateJwtToken(userModel.Name, user.Name);

                        return Ok(Json(token));
                    }
                    return BadRequest("Email or password are not correct!");
                }

                return BadRequest(ModelState);
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public ActionResult<string> Register(RegisterInputModel userModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (userModel.Password != userModel.ConfirmedPassword)
                    {
                        return BadRequest("Passwords does not match!");
                    }

                    if (this.authService.DoesSubscribersExists(userModel.Name))
                    {
                        return BadRequest("User already exists!");
                    }

                    var mappedModel = this.mapper.Map<RegisterInputModel, Subscriber>(userModel);
                    mappedModel.Role ="User";
                    var user = this.authService.RegisterUser(mappedModel);

                    if (user != null)
                    {
                        var token = this.authService.GenerateJwtToken(user.Name, mappedModel.Role);
                        return Ok(Json(token));

                    }

                    return BadRequest("Email or password are not correct!");
                }

                return BadRequest(ModelState);
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }
    }
}
