using System;

namespace Api.Domain.Model.Budget
{
    public class BudgetModel : BaseModel
    {
        /// Id do vidraceiro dono desse orçamento  
        public Guid IdUser;

        // ID do Cliente
        public Guid IdCostumer;

        private int _idProject;
        public int IdProject
        {
            get { return _idProject; }
            set
            {
                _idProject = value == null ? 99 : value;
            }
        }

        public double MeterValue;

        public double HeightValue;

        public double WidthValue;

        public string Description;

        public double Total;

        public double Discount;

    }
}
