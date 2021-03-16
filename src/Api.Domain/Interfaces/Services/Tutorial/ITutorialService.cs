using Api.Domain.DTO.Tutorial;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Tutorial
{
    public interface ITutorialService
    {
        public Task<object> AddTutorial(AddTutorialInput input);
        public Task<object> GetAllTutorial();
        public Task<object> GetByIdTutorial(Guid Id);
        public Task<object> UpdateTutorial(UpdateTutorialInput input);
        public Task<object> DeleteTutorial(Guid Id);
    }
}
