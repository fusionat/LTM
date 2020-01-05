using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Application.Project.Commands.NewProject
{
    public class NewProjectCommandHandler : IRequestHandler<NewProjectCommand, Guid>
    {
        public async Task<Guid> Handle(NewProjectCommand request, CancellationToken cancellationToken)
        {
            return Guid.NewGuid();
        }
    }
}