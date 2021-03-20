using System;

namespace Api.Domain.DTO.Budget
{
    public class ProjectBudgetDTO
    {
        public Guid Id { get; set; }
        public Guid IdProject { get; set; }
        public Guid IdBudget { get; set; }
        public int IdGlassColor { get; set; }
        public int IdAluminumColor { get; set; }
        public int IdStructureColor { get; set; }
        public string Location { get; set; }
        public double MeterValue { get; set; }
        public double HeightValue { get; set; }
        public double WidthValue { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double UnitValue { get; set; }
        public double Total { get; set; }

        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

    }
}
