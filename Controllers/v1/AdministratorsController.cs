using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab3WebAPI.Entities;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;

namespace Lab3WebAPI.Controllers.v1
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Administrators")]
    [ApiController]
    public class AdministratorsController : ControllerBase
    {
        private readonly TelephoneDbContext _context;

        public AdministratorsController(TelephoneDbContext context)
        {
            _context = context;
        }

        // GET: api/Administrators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrator>>> GetAdministrators()
        {
            throw new NotImplementedException();
        }

        // GET: api/Administrators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Administrator>> GetAdministrator(int id)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Administrators/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministrator(int id, Administrator administrator)
        {
            if (id != administrator.Id)
            {
                return BadRequest();
            }

            _context.Entry(administrator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Administrators
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("create-subscriber")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateSubscriber(string username, string email, string password)
        {
            // Only users with the "admin" role can access this action

            // Create subscriber logic
            throw new NotImplementedException();
        }

        // DELETE: api/Administrators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdministrator(int id)
        {
            throw new NotImplementedException();
        }
    }
}
