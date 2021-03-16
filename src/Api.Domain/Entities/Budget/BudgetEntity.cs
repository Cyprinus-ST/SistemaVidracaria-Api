using System;

namespace Api.Domain.Entities.Budget
{
    public class BudgetEntity : BaseEntity
    {
        public Guid IdUser { get; set; }
        public Guid IdCostumer { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public string Status { get; set; }
    }
}
