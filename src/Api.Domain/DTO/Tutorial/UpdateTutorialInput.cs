using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Tutorial
{
    public class UpdateTutorialInput
    {
        [Required(ErrorMessage = "ID é um campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Titulo é um campo obrigatório")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage ="URL é um campo obrigatório")]
        public string Url { get; set; }
    }
}
