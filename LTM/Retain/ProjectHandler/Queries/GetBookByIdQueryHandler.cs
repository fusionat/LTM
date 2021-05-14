using DataLayer;
using EMP.Handlers.ProjectHandler.Queries.GetProjects;
using MediatR;
using Retain.Handlers.Book;
using Retain.Handlers.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Retain.ProjectHandler.Queries
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDto>
    {
        private IMediator _mediator;
        public GetBookByIdQueryHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<BookDto> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var list = await _mediator.Send(new GetProjectsQuery());

            return await Task.FromResult(new BookDto()
            {
                ProjectName = list.Projects[0].ProjectName
            }); ;
        }
    }
}
