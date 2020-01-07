using Application.ProjectHandler.Models;
using MediatR;

namespace Application.ProjectHandler.Queries.GetProjects
{
    public class GetProjectsQuery : IRequest<ProjectListVm>
    {
        
    }
}