using System;

namespace Api.Domain.Model.Plan
{
    public class PlanUserModel
    {
        public Guid idPlan { get; set; }
        public Guid idUser { get; set; }
        public string statusPlan { get; set; }
        public DateTime dateAcquisition { get; set; }
        public DateTime dateExpired { get; set; }
    }
}
