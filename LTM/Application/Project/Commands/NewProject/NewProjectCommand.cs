using System;
using MediatR;

namespace Application.Project.Commands.NewProject
{
    public class NewProjectCommand : IRequest<Guid>
    {
        public string ProjectName {get;set;}
    }
}