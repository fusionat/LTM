using DtoModels.Retain;
using MediatR;

namespace Retain.Handlers.Book
{
    public class GetBookByIdQuery : IRequest<BookDto>
    {
    }
}
