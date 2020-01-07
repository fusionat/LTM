using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ProjectHandler;
using Application.ProjectHandler.Commands.NewProject;
using Application.ProjectHandler.Queries.GetProjects;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.ProjectHandler.Models;
using WebUI.ViewModel.Project;
using Microsoft.AspNetCore.Http;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : BaseController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProjectController> _logger;

        public ProjectController(ILogger<ProjectController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get all Projects.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProjects()
        {
            var list = await Mediator.Send(new GetProjectsQuery());            
            return Ok(list);
        }

        /// <summary>
        /// Create a new project 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProjectDto>> NewProject(ProjectPost newProject)
        {
            var createdProject = await Mediator.Send(new NewProjectCommand()
            {
                ProjectName = newProject.ProjectName
            });

            return Ok(createdProject);
        }
    }
}