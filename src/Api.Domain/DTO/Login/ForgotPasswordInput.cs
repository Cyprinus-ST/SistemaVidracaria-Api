using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Login
{
    public class ForgotPasswordInput
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para Login!")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }
    }
}
