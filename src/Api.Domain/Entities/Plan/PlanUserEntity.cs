using System;

namespace Api.Domain.Entities.Plan
{
    public class PlanUserEntity : BaseEntity
    {
        public Guid idPlan { get; set; }
        public Guid idUser { get; set; }

        /// <summary>
        /// Os status podem ser : active, inactive, canceled 
        /// </summary>
        public string statusPlan { get; set; }

        /// <summary>
        /// Data de aquisição do plano
        /// </summary>
        public DateTime dateAcquisition { get; set; }

        public DateTime dateExpired { get; set; }

    }
}
