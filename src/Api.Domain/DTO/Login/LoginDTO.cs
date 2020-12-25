using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Login
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para Login!")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        [StringLength(100, ErrorMessage = "Email dever ter no máximo {1} caracteres!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é um campo obrigatório para Login!")]
        public string Senha { get; set; }
        
    }
}
