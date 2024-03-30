using Asp.Versioning;
using AutoMapper;
using Lab3WebAPI.Entities;
using Lab3WebAPI.Interfaces;
using Lab3WebAPI.Models;
using Lab3WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Lab3WebAPI.Controllers.v1
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Subscribers")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtService _jwtService;
        private readonly IConfiguration _configuration;
        private readonly RoleSeed _roleSeeder;

        public AuthenticationController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IJwtService jwtService, RoleSeed roleSeeder)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _jwtService = (JwtService)jwtService;
            _roleSeeder = roleSeeder;
        }




        // Route -> Register
        [HttpPost]
        [Route("register")]
        
        public async Task<ActionResult<string>> Register([FromBody] RegisterRequestModel registerRequestModel)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new User { UserName = registerRequestModel.Name };

            var result = await _userManager.CreateAsync(user, registerRequestModel.Password);

            if (!result.Succeeded)
            {
                return BadRequest("Error while creating");
            }

            await _userManager.AddToRoleAsync(user, UserRoles.ADMIN);   
            
            return CreatedAtAction(nameof(Register), registerRequestModel);
        }


        // Route -> Login
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] AuthRequestModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Name);
            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return Unauthorized("Invalid username or password.");
            }
            var role = await _userManager.GetRolesAsync(user);
            var token = _jwtService.GenerateToken(user, role.FirstOrDefault());
            await _userManager.SetAuthenticationTokenAsync(user,"", "", token);
            return Ok(new { Token = token });

        }

      
        // Route For Seeding my roles to DB
        [HttpPost]
        [Route("seed-roles")]
        public async Task<IActionResult> SeedRoles()
        {

            try
            {
                await _roleSeeder.SeedRolesAsync();
                return Ok("Roles seeded successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to seed roles: " + ex.Message);
            }

        }

        [HttpGet("profile")]
        [Authorize] // This requires an authenticated user with a valid token
        public IActionResult GetUserProfile()
        {
            // Access the user's claims
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userName = User.FindFirst(ClaimTypes.Name)?.Value;

            // Access a specific claim
            var role = User.FindFirst(ClaimTypes.Actor)?.Value;

            // Example of role-based authorization
            if (role == UserRoles.ADMIN)
            {
                // Return admin-specific data
                return Ok("Admin Profile");
            }
            else
            {
                // Return subscriber-specific data
                return Ok("Subscriber Profile");
            }
        }





        /*        // Route -> make user -> admin
                [HttpPost]
                [Route("make-admin")]
                public async Task<IActionResult> MakeAdmin([FromBody] UpdatePermission updatePermissionDto)
                {
                    var user = await _userManager.FindByNameAsync(updatePermissionDto.Name);

                    if (user is null)
                        return BadRequest("Invalid User name!!!!!!!!");

                    await _userManager.AddToRoleAsync(user, UserRoles.ADMIN);

                    return Ok("User is now an ADMIN");
                }*/

    }
}
