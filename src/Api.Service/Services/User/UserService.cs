using Api.Domain.DTO.User;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Model.User;
using Api.Service.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Api.Service.Services.User
{
    public class UserService : IUserService
    {
        private IUserRepository repository;
        private readonly IMapper mapper;

        private IConfiguration configuration { get; }

        public UserService(IUserRepository _repository, IConfiguration _configuration, IMapper _mapper)
        {
            repository = _repository;
            configuration = _configuration;
            mapper = _mapper;
        }

        /// <summary>
        ///  Método para atualizar os dados cadastrais do usuário
        /// </summary>
        /// <param name="user"></param>
        /// <returns>
        ///  message : Descrição da situação
        ///  valid : Indica se foi possível realizar a ação do método ou não.
        /// </returns>
        public async Task<object> UpdateUser(UserDTO user)
        {
            Cryptography crp = new Cryptography(SHA512.Create());

            try
            {
                var model = mapper.Map<UserModel>(user);
                var userOld = await repository.SelectAsync(model.Id);
                string senhaPadrao = crp.CriptografarSenha("alterar_senha");
                model.Password = crp.CriptografarSenha(model.Password);

                if (model.Password == senhaPadrao)
                    model.Password = userOld.Password;

                var email = await repository.FindByEmail(user.Email);

                if (email != null && email.Email != userOld.Email)
                {
                    return new
                    {
                        valid = false,
                        message = "Não foi possível alterar o cadastro do usuário, pois o e-mail fornecido já está cadastrado na nossa base de dados"
                    };
                }

                var entity = mapper.Map<UserEntity>(model);
                var data = await repository.UpdateAsync(entity);

                if (data == null)
                {
                    return new
                    {
                        valid = false,
                        message = "Não foi possível alterar o cadastro do usuário, ocorreu um erro interno, favor tentar novamente mais tarde!"
                    };
                }
                else
                {
                    return new
                    {
                        valid = true,
                        message = "Usuário alterado com sucesso!"
                    };
                }

            }
            catch (Exception ex)
            {
                return new
                {
                    message = "Ocorreu um erro ao atualizar os dados cadastrais do usuário. Erro: " + ex.Message
                };
            }
        }


        public async Task<object> UpdateAvatarFile(IFormFile file, Guid idUser)
        {
            UploadFile up = new UploadFile(configuration);
            DateTime moment = DateTime.Now;

            try
            {
                if(file != null)
                {
                    string fileName = moment.Millisecond.ToString() + file.FileName;
                    string path = await up.Upload("UserAvatar", file, idUser, fileName);

                    return new
                    {
                        valid = true,
                        message = "Upload feito com sucesso!",
                        path = path
                    };
                }
                else
                {
                    return new
                    {
                        valid = false,
                        message = "Favor enviar um arquivo!"
                    };
                }

            }
            catch (Exception ex)
            {
                return new
                {
                    valid = false,
                    message = "Ocorreu um erro ao fazer o upload do arquivo:" + ex.Message,

                };
            }
        }
    }
}
