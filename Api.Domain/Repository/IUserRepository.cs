using System.Threading.Tasks;
using Api.Domain.Entities;
using Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email);
    }
}
