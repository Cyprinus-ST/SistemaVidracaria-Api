using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Provider
{
    public class UpdateInputProvider
    {
        [Required(ErrorMessage = "Id é um campo obrigatório!")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name é um campo obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório!")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone é um campo obrigatório!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Description é um campo obrigatório!")]
        [StringLength(350, ErrorMessage = "Description dever ter no máximo {1} caracteres!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "IdUser é um campo obrigatório!")]
        public Guid IdUser { get; set; }
    }
}
