using System;

namespace Api.Domain.Model.Costumer
{
    public class CostumerModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid IdUser { get; set; }
    }
}
