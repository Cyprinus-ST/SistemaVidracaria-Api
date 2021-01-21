using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Material
{
    public class UpdateMaterialInput
    {
        [Required(ErrorMessage = "O campo ID é obrigatório")]
        public Guid id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo quantidade é obrigatório")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "O campo IdUser é obrigatório")]
        public Guid IdUser { get; set; }
    }
}
