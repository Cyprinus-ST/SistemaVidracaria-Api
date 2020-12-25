namespace Api.Domain.Entities.User
{
    public class UserEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
