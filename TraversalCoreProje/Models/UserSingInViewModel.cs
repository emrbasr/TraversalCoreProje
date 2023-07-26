using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSingInViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Girin")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Girin")]
        public string password { get; set; }


    }
}
