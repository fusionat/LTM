using MediatR;
using Retain.Handlers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retain.Handlers.Book
{
    public class GetBookByIdQuery : IRequest<BookDto>
    {
    }
}
