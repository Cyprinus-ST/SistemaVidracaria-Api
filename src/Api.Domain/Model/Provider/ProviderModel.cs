namespace Api.Domain.Entities.Provider
{
    public class ProviderModel : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Descripition { get; set;}

    }
}
