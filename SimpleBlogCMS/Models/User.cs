using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace SimpleBlogCMS.Models
{
    public class User
    {
        private const int WorkFactor = 13;
        public static void FakeHash()
        {
            BCrypt.Net.BCrypt.HashPassword("", WorkFactor);
        }
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string PasswordHash { get; set; }

        public virtual void SetPassword(string password)
        {
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password, WorkFactor);
        }

        public virtual bool CheckPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
        }
    }

    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Table("users");

            Id(λ => λ.Id, λ=> λ.Generator(Generators.Identity));

            Property(λ => λ.Username, λ => λ.NotNullable(true));
            Property(λ => λ.Email, λ=> λ.NotNullable(true));
            Property(λ => λ.PasswordHash, λ =>
            {
                λ.Column("password_hash");
                λ.NotNullable(true);
            });
        }
    }
}