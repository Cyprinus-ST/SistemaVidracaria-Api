using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.User
{
    public class UserUpdateDTO
    {
        [Required(ErrorMessage ="ID é um campo obrigatório!")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name é um campo obrigatório!")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail é um campo obrigatório!")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido!")]
        [StringLength(160, ErrorMessage = "E-mail deve ter no máximo {1} caracteres!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password é um campo obrigatório")]
        [StringLength(20, ErrorMessage = "Password deve ter no máximo {1} caracteres!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "CPF é um campo obrigatório")]
        [StringLength(14, ErrorMessage = "CPF deve ter no máximo {1} caracteres")]
        public string CPF { get; set; }

        [StringLength(450, ErrorMessage = "PathAvatar deve ter no máximo {1} caracteres")]
        public string PathAvatar { get; set; }

        [Required(ErrorMessage = "Type é um campo obrigatório")]
        public string Type { get; set; }

        [StringLength(150, ErrorMessage = "Street deve ter no máximo {1} caracteres")]
        public string Street { get; set; }

        [StringLength(100, ErrorMessage = "Neighborhood deve ter no máximo {1} caracteres")]
        public string Neighborhood { get; set; }

        [StringLength(100, ErrorMessage = "City deve ter no máximo {1} caracteres")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "State deve ter no máximo {1} caracteres")]
        public string State { get; set; }

        [StringLength(30, ErrorMessage = "Country deve ter no máximo {1} caracteres")]
        public string Country { get; set; }

        [StringLength(15, ErrorMessage = "Number deve ter no máximo {1} caracteres")]
        public string Number { get; set; }

        [StringLength(150, ErrorMessage = "Complement deve ter no máximo {1} caracteres")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "Phone é um campo obrigatório")]
        public string Phone { get; set; }
    }
}
