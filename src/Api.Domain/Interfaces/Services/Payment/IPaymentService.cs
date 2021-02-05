using Api.Domain.DTO.Payment;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Payment
{
    public interface IPaymentService
    {
        Task AddProduct(AddProductInput input);
    }
}
