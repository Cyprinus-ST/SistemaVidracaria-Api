using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTO.Budget
{
    public class AddBudgetInput
    {
        
        [Required(ErrorMessage = "IdUser é um campo obrigatório!")]
        public Guid IdUser { get; set; }

        [Required(ErrorMessage = "IdCostumer é um campo obrigatório!")]
        public Guid IdCostumer { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public string Status { get; set; }

        public List<ProjectBudgetDTO> Projects { get; set; }

    }
}
