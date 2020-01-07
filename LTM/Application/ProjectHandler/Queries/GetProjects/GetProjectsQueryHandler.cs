using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.ProjectHandler.Models;
using DataLayer;
using MediatR;

namespace Application.ProjectHandler.Queries.GetProjects
{
    public class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, ProjectListVm>
    {
        public ILtmDataContext _ltmContext { get; }
        public GetProjectsQueryHandler(ILtmDataContext ltm)
        {
            _ltmContext = ltm;
        }

        public async Task<ProjectListVm> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
           var projectList = new ProjectListVm();
           projectList.Projects = _ltmContext.Projects
            .Where(w=> w.Id != Guid.Empty)
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