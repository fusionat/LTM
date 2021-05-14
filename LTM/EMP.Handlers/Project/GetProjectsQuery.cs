
using EMP.Handlers.ProjectHandler.Models;
using MediatR;

namespace EMP.Handlers.ProjectHandler.Queries.GetProjects
{
    public class GetProjectsQuery : IRequest<ProjectListVm>
    {
    }
}