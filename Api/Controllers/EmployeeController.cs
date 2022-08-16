using Domain.Entities;
using Domain.Interfaces;
using Domain.Specifications;

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IGenericRepository<Employee> _repository;
        public EmployeeController(IGenericRepository<Employee> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var developers = await _repository.GetAllAsync();
            return Ok(developers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var developer = await _repository.GetByIdAsync(id);
            return Ok(developer);
        }
        [HttpGet("specify")]
        public async Task<IActionResult> Specify()
        {
            var specification = new EmployeeWithLevelNSpecification(3);
           // var specification = new EmployeeByProposedSalarySpecification();
            var developers = _repository.FindWithSpecificationPattern(specification);
            return Ok(developers);
        }
    }
}
