using Application.DTOs;
using AutoMapper;
using Domain.Entities;
namespace Application.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
