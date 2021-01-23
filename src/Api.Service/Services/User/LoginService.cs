using Api.Domain.DTO.Login;
using Api.Domain.DTO.User;
using Api.Domain.Entities.Plan;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Login;
using Api.Domain.Model.Plan;
using Api.Domain.Model.User;
using Api.Domain.Security;
using Api.Domain.Utils;
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
        private IPlanRepository planRepository;
        private IPlanUserRepository planUserRepository;
        public SigningConfigurations signingConfigurations;
        public TokenConfigurations tokenConfigurations;
        private readonly IMapper mapper;

        private IConfiguration configuration { get; }

        public LoginService(IUserRepository _repository, IPlanRepository _planRepository, IPlanUserRepository _planUserRepository, SigningConfigurations _signingConfigurations, TokenConfigurations _tokenConfigurations, IConfiguration _configuration, IMapper _mapper)
        {
            repository = _repository;
            planRepository = _planRepository;
            planUserRepository = _planUserRepository;
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
                    baseUser = await repository.FindByLoginAndPassword(user.Email, user.Password);

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

                    //Buscando o plano experimental, para cadastrar no usuário
                    PlanEntity plan = await planRepository.FindByName("Plano Experimental");

                    PlanUserModel pu = new PlanUserModel();
                    pu.dateAcquisition = DateTime.Now;

                    //O período experimental é de 7 dias
                    pu.dateExpired = DateTime.Now.AddDays(7);
                    pu.idPlan = plan.Id;
                    pu.idUser = result.Id;
                    pu.statusPlan = "ACTIVE";

                    var modelPlanUser = mapper.Map<PlanUserEntity>(pu);

                    var planUser = await planUserRepository.InsertAsync(modelPlanUser);

                    return new
                    {
                        user = result,
                        message = "Usuário cadastrado com sucesso! Você tem um período de 7 dias grátis!"
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

        public async Task<ForgotPasswordOutput> GenerateTokenByEmail(string email)
        {
            try
            {
                var hasUser = await repository.FindByEmail(email);

                if (hasUser == null)
                {
                    throw new Exception("Email não cadastrado na base de dados");
                }

                hasUser.TokenPassword = Guid.NewGuid().ToString();

                await repository.UpdateAsync(hasUser);

                var bodyEmail = new ForgotPassworBodyEmail(hasUser.TokenPassword);
                string FORGOT_PASSWORD_BODY = bodyEmail.FORGOT_PASSWORD_BODY;
                const string subject = "Redefinir sua senha";

                var smtpClient = new SmptClient();
                smtpClient.SendEmail(email, null, null, subject, FORGOT_PASSWORD_BODY);

                return new ForgotPasswordOutput
                {
                    sentEmail = true,
                    message = "Email de recuperação enviado!! Verifique sua caixa de email."
                };

            } catch (Exception e)
            {
                return new ForgotPasswordOutput
                {
                    sentEmail = false,
                    message = e.Message
                };
            }
        }

        public async Task<object> RecoveryTokenIsValid(string token)
        {
            try
            {
                var hasUser = await repository.FindByToken(token);

                if (hasUser == null)
                {
                    throw new Exception("Token Inválido");
                }

                return new RecoveryTokenIsValidOutput
                {
                    recoveryTokenIsValid = true,
                    userId = hasUser.Id
                };

            } catch(Exception e)
            {
                return new
                {
                    recoveryTokenIsValid = false,
                    message = e.Message
                };
            }
        }

        public async Task<bool> UpdatePassword(Guid userId, string password)
        {
            Cryptography crypto = new Cryptography(SHA512.Create());
            try
            {
                var user = await repository.SelectAsync(userId);

                user.Password = crypto.CriptografarSenha(password);
                user.TokenPassword = null;

                await repository.UpdateAsync(user);

                return true;

            } catch (Exception)
            {
                return false;
            }
        }
    }
}

