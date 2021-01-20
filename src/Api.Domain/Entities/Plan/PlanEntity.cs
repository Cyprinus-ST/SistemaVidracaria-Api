namespace Api.Domain.Entities.Plan
{
    public class PlanEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Installments { get; set; }
        public string Status { get; set; }
    }
}
