using Api.Domain.DTO.Login;
using Api.Domain.DTO.User;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Login;
using Api.Domain.Model.User;
using Api.Domain.Security;
using Api.Service.Utils;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Api.Service.Services.User
{
    public class LoginService : ILoginService
    {
        private IUserRepository repository;
        public SigningConfigurations signingConfigurations;
        public TokenConfigurations tokenConfigurations;
        private readonly IMapper mapper;

        private IConfiguration configuration { get; }

        public LoginService(IUserRepository _repository, SigningConfigurations _signingConfigurations, TokenConfigurations _tokenConfigurations, IConfiguration _configuration, IMapper _mapper)
        {
            repository = _repository;
            signingConfigurations = _signingConfigurations;
            tokenConfigurations = _tokenConfigurations;
            configuration = _configuration;
            mapper = _mapper;

        }

        public async Task<object> DoLogin(LoginDTO user)
        {
            Cryptography crp = new Cryptography(SHA512.Create());

            try
            {
                var baseUser = new UserEntity();

                if (user != null && !string.IsNullOrWhiteSpace(user.Email))
                {
                    user.Password = crp.CriptografarSenha(user.Password);
                    baseUser = await repository.FindByLoginAndPassword(user.Email, user.Password); ;

                    if (baseUser == null)
                    {
                        return new
                        {
                            authenticated = false,
                            message = "E-mail ou senha inválidos!"
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

                        var userDTO = mapper.Map<UserDTO>(baseUser);

                        return new
                        {
                            authenticated = true,
                            created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                            expiration = experationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                            acessToken = token,
                            user = userDTO,
                            message = "Usuário Logado com sucesso!"
                        };

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

        public async Task<object> CreateUser(UserCreateDTO newUser)
        {
            Cryptography crp = new Cryptography(SHA512.Create());

            try
            {
                var hasUser = await repository.FindByEmail(newUser.Email);
                if(hasUser == null)
                {
                    if (!newUser.Type.Equals("admin") && !newUser.Type.Equals("user"))
                    {
                        return new
                        {
                            message = "Favor inserir um tipo de usuário válido!"
                        }; 
                    }

                    var model = mapper.Map<UserModel>(newUser);
                    model.Password = crp.CriptografarSenha(model.Password);
                    var entity = mapper.Map<UserEntity>(model);
                    var result = await repository.InsertAsync(entity);

                    return new
                    {
                        user = result,
                        message = "Usuário cadastrado com sucesso!"
                    };
                }
                else
                {
                    return new
                    {
                        message = "E-mail já cadastrado na nossa base de dados!"
                    };
                }
    
            }
            catch (Exception)
            {

                throw;
            }
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

        public async Task<object> GenerateTokenByEmail(string email)
        {
            var hasUser = await repository.FindByEmail(email);

            if(hasUser == null)
            {
                return new
                {
                    message = "E-mail não encontrado"
                };
            }

            hasUser.TokenPassword = Guid.NewGuid().ToString();

            await repository.UpdateAsync(hasUser);

            return hasUser.TokenPassword;
        }
    }
}

