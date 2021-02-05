using System;

namespace Api.Domain.DTO.Payment
{
    public class AddProductInput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
