using System.Threading.Tasks;
using Application.ProjectHandler.Commands.NewProject;
using Application.ProjectHandler.Models;
using Application.ProjectHandler.Queries.GetProjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : BaseController
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProjectController> _logger;

        public ProjectController(ILogger<ProjectController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///     Get all Projects.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProjects()
        {
            var list = await Mediator.Send(new Retain.ProjectHandler.Queries.GetProjects.GetProjectsQuery());
            return Ok(list);
        }

        /// <summary>
        ///     Create a new project
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProjectDto>> NewProject(NewProjectCommand newProject)
        {
            var createdProject = await Mediator.Send(newProject);

            return Ok(createdProject);
        }
    }
}