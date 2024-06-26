﻿using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lab3WebAPI.Entities
{
    public class TelephoneDbContext :DbContext
    {

        public TelephoneDbContext(DbContextOptions<TelephoneDbContext> options)
            : base(options) { }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Bill> Bills { get; set; }
        //public DbSet<SubscriberServices> SubscriberS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

          

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TelephoneDbContext).Assembly);
            base.OnModelCreating(modelBuilder);

       /*    modelBuilder.Entity<Subscriber>()
            .HasKey(u => new { u.Id });

            modelBuilder.Entity<Service>()
                .HasKey(e => new { e.Id });

            modelBuilder.Entity<SubscriberServices>()
                .HasKey(ue => new { ue.UserName, ue.ServicesName });

            modelBuilder.Entity<SubscriberServices>()
                .HasOne(ue => ue.Subscriber)
                .WithMany(user => user.Services)
                .HasForeignKey(u => u.Id);

            modelBuilder.Entity<SubscriberServices>()
                .HasOne(uc => uc.Service)
                .WithMany(ev => ev.Subscribers)
                .HasForeignKey(ev => ev.Id);*/
        }



    }
}
