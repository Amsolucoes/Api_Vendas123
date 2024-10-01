using System.Threading.Tasks;
using Domain.Dtos;

namespace Api.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
