
using MediatR;
using Retain.ProjectHandler.Models;

namespace Retain.ProjectHandler.Queries.GetProjects
{
    public class GetProjectsQuery : IRequest<ProjectListVm>
    {
    }
}