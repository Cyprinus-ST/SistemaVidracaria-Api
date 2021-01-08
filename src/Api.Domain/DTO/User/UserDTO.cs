using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.User
{
    public class UserDTO
    {
        [Required(ErrorMessage = "ID é um campo obrigatório!")]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório para Login!")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        [StringLength(100, ErrorMessage = "Email dever ter no máximo {1} caracteres!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é um campo obrigatório para Login!")]
        public string Password { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string PathAvatar { get; set; }
        public string Type { get; set; }
        public string CEP { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Phone { get; set; }
        public string TokenPassword { get; set; }
    }
}
