using Application.Interfaces.IServices;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCleanBoilerplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet(Name = "GetAllEmployee")]
        public async Task<IActionResult> Get()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            return Ok(employees);
        }
    }
}

