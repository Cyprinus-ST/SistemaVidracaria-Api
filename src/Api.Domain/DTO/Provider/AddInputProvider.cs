using System;

namespace Api.Domain.DTO.Provider
{
    public class AddInputProvider
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Descripition { get; set; }
        public Guid IdUser { get; set; }
    }
}
