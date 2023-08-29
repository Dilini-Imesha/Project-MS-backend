namespace project_management_system_backend.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using project_management_system_backend.Models;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly RequestDbContext _context;

        public RequestController(RequestDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest(AddRequest request)
        {
            try
            {
                // Create a new entity using the request data
                var newRequest = new AddRequest
                {
                    ProjectName = request.ProjectName,
                    RequirementId = request.RequirementId,
                    Type = request.Type,
                    Priority = request.Priority,
                    Description = request.Description
                };

                // Add the new entity to the context
                _context.Requests.Add(newRequest);

                // Save changes to the database
                await _context.SaveChangesAsync();

                return Ok(new { message = "Request created successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the request" });
            }
        }
    }
}
