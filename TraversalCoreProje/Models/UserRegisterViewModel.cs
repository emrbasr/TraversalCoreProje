using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soy adınızı giriniz")]
		public string SurName { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı adınızı giriniz")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen Mailinizi giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi tekrar giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; }

	}
}
