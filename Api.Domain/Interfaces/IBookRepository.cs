using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBookRepository<T> where T : BookEntity
    {
        Task<T> SearchNmae(string name);
        Task<IEnumerable<T>> SearchAuthor(string author);
    }
}
