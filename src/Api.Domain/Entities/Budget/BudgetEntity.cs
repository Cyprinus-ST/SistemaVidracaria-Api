using System;

namespace Api.Domain.Entities.Budget
{
    public class BudgetEntity : BaseEntity
    {

        /// Id do vidraceiro dono desse orçamento  
        public Guid IdUser;
        
        // ID do Cliente
        public Guid IdCostumer;

        public Guid IdProject;

        public double MeterValue;

        public double HeightValue;

        public double WidthValue;

        public string Description;

        public double Total;

        public double Discount;

    }
}
