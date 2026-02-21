using Application.DTOs;
using Application.Interfaces.IRepository;
using Application.Interfaces.IServices;
using AutoMapper;
using Domain.Entities;


namespace Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
        public async Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            return _mapper.Map<List<EmployeeDto>>( await _employeeRepository.GetAllEmployeesAsync());
        }
    }
}
