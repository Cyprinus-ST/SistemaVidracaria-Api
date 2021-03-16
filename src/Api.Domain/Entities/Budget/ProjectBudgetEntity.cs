using System;

namespace Api.Domain.Entities.ProjectBudgetEntity
{
    public class ProjectBudgetEntity : BaseEntity
    {
        public Guid IdProject { get; set; }
        public Guid IdBudget { get; set; }
        public int IdGlassColor { get; set; }
        public int IdAluminumColor{ get; set; }
        public int IdStructureColor { get; set; }
        public string Location { get; set; }
        public double MeterValue { get; set; }
        public double HeightValue { get; set; }
        public double WidthValue { get; set; }
        public string Description { get; set; }
        public int Quantity{ get; set; }
        public double UnitValue { get; set; }
        public double Total { get; set; }
    }
}

//TODO: Criar Tabela de GlassColor
//TODO: Criar Tabela de AluminiumColor
//TODO: Criar Tabela de StructureColor

/*
 Total de vãos, o que seria ???
 */
