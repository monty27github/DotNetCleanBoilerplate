using Domain.Entities;

namespace Application.Interfaces.IRepository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeesAsync();
    }
}
