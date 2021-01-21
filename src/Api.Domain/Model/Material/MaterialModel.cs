using System;

namespace Api.Domain.Model.Material
{
    public class MaterialModel
    {
        public string Title { get; set; }
        public int Amount { get; set; }

        /// <summary>
        /// Para identificar de qual usuário essa material pertence
        /// </summary>
        public Guid IdUser { get; set; }
    }
}
