using AutoMapper;
using Lab3WebAPI.Entities;
using Lab3WebAPI.Models;
using Microsoft.AspNet.Identity;

namespace Lab3WebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterInputModel, Subscriber>().ReverseMap();
        }
    }
}
