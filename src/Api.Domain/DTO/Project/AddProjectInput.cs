using System;

namespace Api.Domain.DTO.Project
{
    public class AddProjectInput
    {
        public string Title { get; set; }
        public int NumberGlass { get; set; }
        public string Descripition { get; set; }
        public Guid IdUser { get; set; }
        public string ImageUrl { get; set; }
        public int ProjectType { get; set; }
    }
}
