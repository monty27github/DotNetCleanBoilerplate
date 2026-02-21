using Application.DTOs;
using Domain.Entities;


namespace Application.Interfaces.IServices
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployeesAsync();
    }
}
