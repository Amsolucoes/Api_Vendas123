using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Book
{
    public interface IBookServices
    {
        Task<BookEntity> SearchName(string book);

        Task<IEnumerable<BookEntity>> SearchAuthor(string author);
    }
}
