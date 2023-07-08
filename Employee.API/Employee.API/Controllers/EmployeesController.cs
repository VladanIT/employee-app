using Employee.API.Data;
using Employee.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : Controller
    {
        private readonly EmployeesDbContext _employeesDbContext;
        public EmployeesController(EmployeesDbContext employeesDbContext) 
        {
            _employeesDbContext = employeesDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeesDbContext.Employees.ToListAsync();

            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employees employeeRequest)
        {
            employeeRequest.Id = Guid.NewGuid();
            await _employeesDbContext.Employees.AddAsync(employeeRequest);
            await _employeesDbContext.SaveChangesAsync();

            return Ok(employeeRequest);
        }
    }
}
