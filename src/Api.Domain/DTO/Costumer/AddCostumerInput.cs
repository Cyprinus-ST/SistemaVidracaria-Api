using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Costumer
{
    public class AddCostumerInput
    {
        [Required(ErrorMessage = "IdUser é um campo obrigatório!")]
        public Guid IdUser { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório!")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
