using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Repositories;
using DtoModels.EMP;
using EMP.Handlers.ProjectHandler.Queries.GetProjects;
using MediatR;

namespace Application.ProjectHandler.Queries.GetProjects
{
    public class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, ProjectListVm>
    {
        private readonly IProjectRepository _projectRepository;
        private ILtmDataContext _ltmContext;

        public GetProjectsQueryHandler(ILtmDataContext ltm, IProjectRepository projectRepository)
        {
            _ltmContext = ltm;
            _projectRepository = projectRepository;
        }

        public async Task<ProjectListVm> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
            var projectList = new ProjectListVm();
            projectList.Projects = _projectRepository.GetAll()
                .Select(s =>
                    new ProjectDto
                    {
                        Id = s.Id,
                        ProjectName = s.ProjectName
                    }).ToList();
            return projectList;
        }
    }
}