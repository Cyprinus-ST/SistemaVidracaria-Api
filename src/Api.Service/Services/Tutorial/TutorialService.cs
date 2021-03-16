using Api.Domain.DTO.Tutorial;
using Api.Domain.Entities.Tutorial;
using Api.Domain.Interfaces.Repository.Tutorial;
using Api.Domain.Interfaces.Services.Tutorial;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.Tutorial
{
    public class TutorialService : ITutorialService
    {
        public IMapper mapper;
        public ITutorialRepository repository;


        public TutorialService(ITutorialRepository _repository, IMapper _mapper)
        {
            mapper = _mapper;
            repository = _repository;
        }

        public async Task<object> AddTutorial(AddTutorialInput input)
        {
            try
            {
                var entity = mapper.Map<TutorialEntity>(input);

                var result = await repository.InsertAsync(entity);

                if (result != null)
                {
                    return new
                    {
                        valid = true,
                        message = "Tutorial cadastrado com sucesso!"
                    };

                }
                else
                {
                    throw new Exception("Ocorreu um erro ao cadastrar o Tutorial!");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<object> DeleteTutorial(Guid Id)
        {
            try
            {
                var result = await repository.DeleteAsync(Id);
                if (result)
                {
                    return new
                    {
                        message = "Tutorial excluído com sucesso!"
                    };
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao excluir o Tutorial!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetAllTutorial()
        {
            List<TutorialEntity> listResult = await repository.GetAll();

            if (listResult.Count > 0)
            {
                return new
                {
                    valid = true,
                    listTutorial = listResult
                };
            }
            else
            {
                return new
                {
                    valid = false,
                    message = "Não encontramos tutorial cadastrado!"
                };
            }
        }

        public Task<object> GetByIdTutorial(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateTutorial(UpdateTutorialInput input)
        {
            throw new NotImplementedException();
        }
    }
}
