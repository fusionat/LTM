
using DtoModels.EMP;
using MediatR;

namespace EMP.Handlers.ProjectHandler.Queries.GetProjects
{
    public class GetProjectsQuery : IRequest<ProjectListVm>
    {
    }
}