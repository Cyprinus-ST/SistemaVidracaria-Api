using Api.Domain.DTO.Payment;
using Api.Domain.Interfaces.Services.Payment;
using System;
using System.Threading.Tasks;
using MercadoPago;
using MercadoPago.Resources;
using MercadoPago.DataStructures.Preference;
using MercadoPago.Common;

namespace Api.Service.Services.Payment
{
    public class PaymentService : IPaymentService
    {
        private Preference preference;
        public PaymentService()
        {
            MercadoPago.SDK.AccessToken = "COLOCAR TOKEN";
            preference = new Preference();
        }
        public Task AddProduct(AddProductInput input)
        {
            preference.Items.Add(
                new Item()
                {
                    Id = input.Id.ToString(),
                    Title = input.Name,
                    CurrencyId = CurrencyId.BRL,
                    UnitPrice = (decimal)input.Price
                }
            );

            preference.Save();
            return null;
        }
    }
}
