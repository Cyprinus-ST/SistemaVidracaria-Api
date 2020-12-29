using Api.Domain.DTO.Login;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Login;
using Api.Domain.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Api.Service.Services.User
{
    public class LoginService : ILoginService
    {
        private IUserRepository repository;
        public SigningConfigurations signingConfigurations;
        public TokenConfigurations tokenConfigurations;

        private IConfiguration configuration { get; }

        public LoginService(IUserRepository _repository, SigningConfigurations _signingConfigurations, TokenConfigurations _tokenConfigurations, IConfiguration _configuration)
        {
            repository = _repository;
            signingConfigurations = _signingConfigurations;
            tokenConfigurations = _tokenConfigurations;
            configuration = _configuration;
        }

        public async Task<object> DoLogin(LoginDTO user)
        {
            try
            {
                var baseUser = new UserEntity();

                if (user != null && !string.IsNullOrWhiteSpace(user.Email))
                {
                    baseUser = await repository.FindByLoginAndPassword(user.Email, user.Senha); ;

                    if (baseUser == null)
                    {
                        return new
                        {
                            authenticated = false,
                            message = "Falha ao autenticar"
                        };
                    }
                    else
                    {
                        ClaimsIdentity identity = new ClaimsIdentity(
                            new GenericIdentity(user.Email),
                            new[]
                            {
                            new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.Email)
                            }
                         );

                        DateTime createDate = DateTime.Now;
                        DateTime experationDate = createDate + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                        var handler = new JwtSecurityTokenHandler();
                        string token = CreateToken(identity, createDate, experationDate, handler);
                        return SucessObject(createDate, experationDate, token, user);

                    }
                }
                else
                {
                    return new
                    {
                        authenticated = false,
                        message = "Falha ao autenticar"
                    };
                }
            }
            catch (Exception e)
            {
                throw;
            }

        }
        private object SucessObject(DateTime createDate, DateTime expirationDate, string token, LoginDTO user)
        {
            return new
            {
                authenticated = true,
                created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                acessToken = token,
                userName = user.Email,
                message = "Usuário Logado com sucesso!"
            };
        }

        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime experationDate, JwtSecurityTokenHandler handler)
        {
            try
            {
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = createDate,
                    Expires = experationDate
                });

                var token = handler.WriteToken(securityToken);
                return token;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}

