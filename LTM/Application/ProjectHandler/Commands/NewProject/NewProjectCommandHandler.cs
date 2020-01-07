using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.ProjectHandler.Models;
using DataLayer;
using Domain;
using MediatR;
using LtmProject = Domain.Project;
namespace Application.ProjectHandler.Commands.NewProject
{
    public class NewProjectCommandHandler : IRequestHandler<NewProjectCommand, ProjectDto>
    {
        public ILtmDataContext _ltmContext { get; }
        public NewProjectCommandHandler(ILtmDataContext ltm) 
        {
            _ltmContext = ltm;
        }

        public async Task<ProjectDto> Handle(NewProjectCommand request, CancellationToken cancellationToken)
        {
            var newProject = new LtmProject() 
            {
                ProjectName = request.ProjectName
            };

            //TO DO - Move to Repository.
            _ltmContext.Projects.Add(newProject);
            _ltmContext.Save();
            
            //TO DO - Use AutoMapper.
            var projectDto = new ProjectDto() 
            {
                Id = newProject.Id,
                ProjectName = newProject.ProjectName
            };

            return projectDto;
        }
    }
}