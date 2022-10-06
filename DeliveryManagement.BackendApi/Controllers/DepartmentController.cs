using DeliveryManagement.Application.Catalog.Department;
using DeliveryManagement.ViewModels.Catalog.Department;
using DeliveryManagement.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace DeliveryManagement.BackendApi.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IManageDepartmentService _manageDepartmentService;
        public DepartmentController(IManageDepartmentService managePetService)
        {
            _manageDepartmentService = managePetService;
        }

        [HttpGet("public-paging")]
        [SwaggerOperation(Summary = "Get all paging")]
        public async Task<IActionResult> Get([FromQuery] PagingRequestBase request)
        {
            var deps = await _manageDepartmentService.GetAllPaging(request);
            return Ok(deps);
        }


        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get dep by id")]
        public async Task<IActionResult> GetDepartmentById(string id)
        {
            var dep = await _manageDepartmentService.GetById(id);
            if (dep == null) return BadRequest("Cannot find department");
            return Ok(dep);
        }


        [HttpPost]
        [SwaggerOperation(Summary = "Create dep")]
        public async Task<IActionResult> Create([FromForm] DepartmentCreateRequest request)
        {
            var depId = await _manageDepartmentService.Create(request);
            if (depId.Equals(null)) return BadRequest("Cannot Create");
            var dep = await _manageDepartmentService.GetById(depId);
            return CreatedAtAction(nameof(GetDepartmentById), new { id = depId }, dep);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Update all info in the dep")]
        public async Task<IActionResult> Update([FromForm] DepartmentUpdateRequest request)
        {
            var affectedResult = await _manageDepartmentService.Update(request);
            if (affectedResult.Equals(null)) return BadRequest("Cannot Update");

            return Ok(affectedResult);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var affectedResult = await _manageDepartmentService.Delete(id);
            if (affectedResult.Equals(null)) return BadRequest("Cannot Delete");

            return Ok(affectedResult);
        }
    }
}
