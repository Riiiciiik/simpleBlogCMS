using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace SimpleBlogCMS.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string PasswordHash { get; set; }
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