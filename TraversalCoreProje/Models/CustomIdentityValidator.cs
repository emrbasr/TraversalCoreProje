using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description=$"Şifre minimum {length} haneli olmalıdır"
            };
        }
    }
}
