using System;

namespace Api.Domain.Entities.Costumer
{
    public class CostumerEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid IdUser { get; set; }
    }
}
