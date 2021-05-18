using DtoModels.EMP;
using MediatR;

namespace EMP.Handlers.ProjectHandler.Commands.NewProject
{
    public class NewProjectCommand : IRequest<ProjectDto>
    {
        public string ProjectName { get; set; }
    }
}