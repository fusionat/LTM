
using MediatR;
using Retain.ProjectHandler.Models;

namespace Retain.ProjectHandler.Commands.NewProject
{
    public class NewProjectCommand : IRequest<ProjectDto>
    {
        public string ProjectName { get; set; }
    }
}