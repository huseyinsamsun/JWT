using AuthServer.Core.DTOs;
using SharedLibrary.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByName(string userName);
        Task<Response<UserAppDto>> GetUserByEmail(string email);

    }
}
