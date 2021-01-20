using System;

namespace Api.Domain.DTO.User
{
    public class UserPlanDTO
    {
        #region User

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAt { get; set; }

        #endregion

        #region PlanUser

        public Guid  IdPlan { get; set; }
        public string StatusPlan { get; set; }
        public DateTime DateAcquisition { get; set; }
        public DateTime DateExpired { get; set; }

        #endregion

        #region Plan
        public string NamePlan { get; set; }

        #endregion

    }
}
