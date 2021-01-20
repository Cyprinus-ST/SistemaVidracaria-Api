using System;

namespace Api.Domain.DTO.User
{
    public class UserPlanCompleteDTO
    {
        #region User
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Type { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Phone { get; set; }
        public string CEP { get; set; }
        public DateTime? CreateAt { get; set; }
        public string PathAvatar { get; set; }
        #endregion

        #region PlanUser

        public Guid IdPlan { get; set; }
        public string StatusPlan { get; set; }
        public DateTime DateAcquisition { get; set; }
        public DateTime DateExpired { get; set; }

        #endregion

        #region Plan

        public string NamePlan { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

        #endregion
    }
}
