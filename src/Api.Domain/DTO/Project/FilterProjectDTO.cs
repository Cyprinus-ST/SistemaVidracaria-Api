namespace Api.Domain.DTO.Project
{
    public class FilterProjectDTO
    {
        public int Start { get; set;}
        public int MaxResults { get; set; }
        public int ProjectType { get; set; }
        public int NumberGlass { get; set; }
        public int Page { get; set; }
        public string Title { get; set; }
        
    }
}
