using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Tutorial
{
    public class AddTutorialInput
    {
        [Required(ErrorMessage = "Titulo é um campo obrigatório")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "URL é um campo obrigatório")]
        public string Url { get; set; }
    }
}
