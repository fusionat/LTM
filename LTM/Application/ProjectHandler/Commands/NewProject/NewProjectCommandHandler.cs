using System.Threading;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Repositories;
using DtoModels.EMP;
using EMP.Handlers.ProjectHandler.Commands.NewProject;
using MediatR;
using LtmProject = Domain.Project;

namespace Application.ProjectHandler.Commands.NewProject
{
    public class NewProjectCommandHandler : IRequestHandler<NewProjectCommand, ProjectDto>
    {
        private readonly ILtmDataContext _ltmContext;
        private readonly IProjectRepository _projectRepository;

        public NewProjectCommandHandler(ILtmDataContext ltm, IProjectRepository projectRepository)
        {
            _ltmContext = ltm;
            _projectRepository = projectRepository;
        }

        public async Task<ProjectDto> Handle(NewProjectCommand request, CancellationToken cancellationToken)
        {
            var newProject = new LtmProject
            {
                ProjectName = request.ProjectName
            };

            //TO DO - Move to Repository.
            _projectRepository.Add(newProject);
            _ltmContext.Save();

            //TO DO - Use AutoMapper.
            var projectDto = new ProjectDto
            {
                Id = newProject.Id,
                ProjectName = newProject.ProjectName
            };

            return projectDto;
        }
    }
}