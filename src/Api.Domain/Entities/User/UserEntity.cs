namespace Api.Domain.Entities.User
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CPF { get; set;}
        public string PathAvatar { get; set; }
        public string Type { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Phone { get; set; }
        public string TokenPassword { get; set; }

    }
}
