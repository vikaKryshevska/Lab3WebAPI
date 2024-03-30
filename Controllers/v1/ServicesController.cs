using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab3WebAPI.Entities;
using Asp.Versioning;
using Lab3WebAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace Lab3WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize(Roles = "ADMIN")]
    [Route("api/v{version:apiVersion}/Services")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly TelephoneDbContext _context;
        private readonly IMapper _mapper;

        public ServicesController(TelephoneDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Services
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Service>>> GetServices()
        {
            return await _context.Services.ToListAsync();
        }

        // GET: api/Services/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetService(string id)
        {
            var service = await _context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return service;
        }


        // POST: api/Services
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Service>> PostService(ServiceModel serviceModel)
        {
            var service = _mapper.Map<Service>(serviceModel);
            _context.Services.Add(service);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetService", new { id = service.Id }, service);
        }

        // DELETE: api/Services/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(string id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
