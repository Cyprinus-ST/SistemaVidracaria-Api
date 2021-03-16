namespace Api.Domain.Entities.Tutorial
{
    public class TutorialEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
