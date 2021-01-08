using System;

namespace Api.Domain.DTO.Login
{
    public class UpdatePasswordInput
    {
        public string user_id { get; set; }
        public Guid id { get => new Guid(user_id); }
        public string password { get; set; }
    }
}
