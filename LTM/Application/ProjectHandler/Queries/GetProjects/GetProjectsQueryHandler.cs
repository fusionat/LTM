using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.ProjectHandler.Models;
using DataLayer;
using DataLayer.Repositories;
using MediatR;

namespace Application.ProjectHandler.Queries.GetProjects
{
    public class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, ProjectListVm>
    {
        private ILtmDataContext _ltmContext;
        private readonly IProjectRepository _projectRepository;
        public GetProjectsQueryHandler(ILtmDataContext ltm, IProjectRepository projectRepository)
        {
            _ltmContext = ltm;
            _projectRepository = projectRepository;
        }

        public async Task<ProjectListVm> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
           var projectList = new ProjectListVm();
           projectList.Projects = _projectRepository.GetAll()
               .Select(s=> 
                    new ProjectDto()
                    {
                        Id = s.Id,
                        ProjectName = s.ProjectName
                    }).ToList();
            return projectList;                    
        }
    }
}