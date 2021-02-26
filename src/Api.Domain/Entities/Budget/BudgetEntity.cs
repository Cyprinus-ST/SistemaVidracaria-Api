using System;

namespace Api.Domain.Entities.Budget
{
    public class BudgetEntity : BaseEntity
    {

        /// Id do vidraceiro dono desse orçamento  
        public Guid IdUser { get; set; }

        // ID do Cliente
        public Guid IdCostumer { get; set; }

        public Guid IdProject { get; set; }

        public double MeterValue { get; set; }

        public double HeightValue { get; set; }

        public double WidthValue { get; set; }

        public string Description { get; set; }

        public double Total { get; set; }

        public double Discount { get; set; }

        public string Status { get; set; }
    }
}
