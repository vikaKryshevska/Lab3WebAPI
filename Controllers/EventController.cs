using AutoMapper;
using Lab3WebAPI.Entities;
using Lab3WebAPI.Models;
using Lab3WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Lab3WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EventController : Controller
    {

        private readonly EventService eventService;
        private readonly AuthService authService;
        private readonly IMapper mapper;
        private readonly ILogger logger;

        public EventController(EventService eventService, AuthService authService, IMapper mapper, ILogger logger)
        {
            this.eventService = eventService;
            this.authService = authService;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet("All")]
        [Authorize]
        public ActionResult<Service[]> GetAll()
        {
            try
            {
                var events = this.eventService.GetAll();
                return Ok(events);
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult<Service[]> GetAllForUser()
        {
            try
            {
                var userName = this.authService.DecodeNameFromToken(this.Request.Headers["Authorization"]);
                var events = this.eventService.GetAllForUser(userName);
                return Ok(events);
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [HttpGet("{name}")]
        [Authorize]
        public ActionResult<Service> GetByName(string name)
        {
            try
            {
                var eventEntity = this.eventService.GetByName(name);

                if (eventEntity != null)
                {
                    return Ok(eventEntity);
                }

                return NotFound();
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Subscriber")]
        public ActionResult<Service> Create(ServiceModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var mappedModel = this.mapper.Map<ServiceModel, Service>(model);
                    var users = model.Subscribers.Select(x => this.authService.GetById(x));
                    var eventEntity = this.eventService.Create(mappedModel);
                    return Ok(eventEntity);
                }

                return BadRequest(ModelState);
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Authorize(Roles = "Subscriber")]
        public ActionResult<Service> Update(ServiceModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var mappedModel = this.mapper.Map<ServiceModel, Service>(model);
                    var eventEntity = this.eventService.Update(mappedModel);
                    if (eventEntity != null)
                    {
                        return Ok(eventEntity);
                    }

                    return NotFound();
                }

                return BadRequest(ModelState);
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [HttpDelete("{name}")]
        [Authorize(Roles = "Subscriber")]
        public ActionResult<Service> Delete(string id)
        {
            try
            {
                var eventEntity = this.eventService.Delete(id);
                if (eventEntity != null)
                {
                    return Ok(eventEntity);
                }

                return NotFound();
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }
    }
}
