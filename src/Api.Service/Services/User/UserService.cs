using Api.Domain.DTO.User;
using Api.Domain.Entities.User;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Model.User;
using Api.Service.Utils;
using AutoMapper;
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
        /// </returns>
        public async Task<object> UpdateUser(UserDTO user)
        {
            Cryptography crp = new Cryptography(SHA512.Create());

            try
            {
                var model = mapper.Map<UserModel>(user);
                model.Password = crp.CriptografarSenha(model.Password);
                var entity = mapper.Map<UserEntity>(model);
                var data = await repository.UpdateAsync(entity);
                return new
                {
                    message = "Usuário alterado com sucesso!"
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    message = "Ocorreu um erro ao atualizar os dados cadastrais do usuário. Erro: " + ex.Message
                };
            }
        }
    }
}
