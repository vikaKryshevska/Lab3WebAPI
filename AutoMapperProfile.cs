using AutoMapper;
using Lab3WebAPI.Entities;
using Lab3WebAPI.Models;

namespace Lab3WebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterRequestModel, Subscriber>().ReverseMap();
        }
    }
}
