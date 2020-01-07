using System;
using Application.ProjectHandler.Models;
using MediatR;

namespace Application.ProjectHandler.Commands.NewProject
{
    public class NewProjectCommand : IRequest<ProjectDto>
    {
        public string ProjectName {get;set;}
    }
}