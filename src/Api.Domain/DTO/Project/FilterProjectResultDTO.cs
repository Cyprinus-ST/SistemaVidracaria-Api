using System;

namespace Api.Domain.DTO.Project
{
    public class FilterProjectResultDTO
    {
        public class Project
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public int NumberGlass { get; set; }
            public string Descripition { get; set; }
            public Guid IdUser { get; set; }
            public string ImageUrl { get; set; }
            public int ProjectType { get; set; }
        }
        public int Pages { get; set; }
        public int ActualPage { get; set; }

    }
}
