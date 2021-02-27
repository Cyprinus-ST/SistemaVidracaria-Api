using System;

namespace Api.Domain.DTO.Budget
{
   
    public class BudgetCompleteDTO
    {
        #region Usuário
        public Guid Id { get; set; }

        /// Id do vidraceiro dono desse orçamento  
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }

        #endregion

        #region Cliente
        // ID do Cliente
        public Guid IdCostumer { get; set; }
        public string NameCostumer { get; set; }
        public string EmailCostumer { get; set; }
        public string Phone { get; set; }

        #endregion

        #region Projeto

        public Guid IdProject { get; set; }
        public string TitleProject { get; set; }
        public int NumberGlassProject { get; set; }
        public string DescriptionProject { get; set;}
        public string ImageUrlProject { get; set;}
        public int TypeProject { get; set; }

        #endregion

        #region Orçamento
        public double MeterValue { get; set; }
        public double HeightValue { get; set; }
        public double WidthValue { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? CreateAt { get; set; }
        public string Status { get; set; }

        #endregion
    }
}
