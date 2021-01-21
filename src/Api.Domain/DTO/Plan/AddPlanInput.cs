namespace Api.Domain.DTO.Plan
{
    public class AddPlanInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Installments { get; set; }
        public string Status { get; set; }
    }
}
