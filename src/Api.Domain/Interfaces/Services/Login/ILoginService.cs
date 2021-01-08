using Api.Domain.DTO.Login;
using Api.Domain.DTO.User;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Login
{
    public interface ILoginService
    {
        Task<object> DoLogin(LoginDTO user);
        Task<object> CreateUser(UserCreateDTO newUser);
        Task<ForgotPasswordOutput> GenerateTokenByEmail(string email);
        Task<object> RecoveryTokenIsValid(string token);
        Task<bool> UpdatePassword(Guid userId, string password);
    }
}
