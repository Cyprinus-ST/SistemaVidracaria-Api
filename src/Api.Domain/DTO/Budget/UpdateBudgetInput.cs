using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Budget
{
    public class UpdateBudgetInput
    {
        [Required(ErrorMessage = "Id é um campo obrigatório!")]
        public Guid Id { get; set; }

        /// <summary>
        /// Id do vidraceiro dono desse orçamento  
        /// </summary>
        [Required(ErrorMessage = "IdUser é um campo obrigatório!")]
        public Guid IdUser { get; set; }

        [Required(ErrorMessage = "IdCostumer é um campo obrigatório!")]
        /// <summary>
        /// ID do Cliente
        /// </summary>
        public Guid IdCostumer { get; set; }

        [Required(ErrorMessage = "IdProject é um campo obrigatório!")]
        public int IdProject { get; set; }

        [Range(0,99999,ErrorMessage ="Valor do metro não pode ser um valor negativo.")]
        public double MeterValue { get; set; }

        [Range(0,99999,ErrorMessage ="Altura não pode ser um valor negativo.")]
        public double HeightValue { get; set; }

        [Range(0, 99999, ErrorMessage = "Largura não pode ser um valor negativo.")]
        public double WidthValue { get; set; }

        public string Description { get; set; }

        public double Total { get; set; }

        [Range(0, 99999, ErrorMessage = "Desconto não pode ser um valor negativo.")]
        public double Discount { get; set; }

        [Required(ErrorMessage = "Status é um campo obrigatório!")]
        public string Status { get; set; }
    }
}
