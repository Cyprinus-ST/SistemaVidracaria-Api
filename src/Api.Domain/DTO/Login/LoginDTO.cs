using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Login
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para Login!")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é um campo obrigatório para Login!")]
        public string Password { get; set; }
    }
}
