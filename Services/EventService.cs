using Lab3WebAPI.Entities;
using System.Data.Entity;

namespace Lab3WebAPI.Services
{
    public class EventService
    {


        private readonly TelephoneDbContext dataContext;

        public EventService(TelephoneDbContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Service[] GetAll()
        {
            return this.dataContext.Services
                                   .Include(ev => ev.Subscribers)
                                   .ToArray();
        }

        public Service[] GetAllForUser(string name)
        {
            throw new NotImplementedException();
        }

        public Service GetByName(string name)
        {
            return this.dataContext.Services
                                   .Include(ev => ev.Subscribers)
                                   .FirstOrDefault(c => c.Name == name);
        }

        public Service Create(Service model)
        {
            var name = IdGenerator.CreateLetterName(6);
            var existWithId = this.GetByName(name);
            while (existWithId != null)
            {
                name = IdGenerator.CreateLetterName(6);
                existWithId = this.GetByName(name);
            }
            model.Name = name;

            var eventEntity = this.dataContext.Services.Add(model);
            this.dataContext.SaveChanges();

            return eventEntity.Entity;
        }

        public Service Update(Service model)
        {
            var eventEntity = this.dataContext.Services
                                              .Include(ev => ev.Subscribers)
                                              .FirstOrDefault(c => c.Id == model.Id);
            if (eventEntity != null)
            {
                eventEntity.Name = model.Name != null ? model.Name : eventEntity.Name;
                eventEntity.Status = model.Status != null ? model.Status : eventEntity.Status;
                eventEntity.Prise = model.Prise != null ? model.Prise : eventEntity.Prise;
                eventEntity.Subscribers = model.Subscribers?.Count! > 0 ? model.Subscribers : eventEntity.Subscribers;

                this.dataContext.SaveChanges();
            }

            return eventEntity;
        }

        public Service Delete(string name)
        {
            var eventEntity = this.GetByName(name);
            if (eventEntity != null)
            {
                this.dataContext.Services.Remove(eventEntity);
                this.dataContext.SaveChanges();
            }

            return eventEntity;
        }
    }
}
