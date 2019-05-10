using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelKavrami.Models
{
    public class User
    {
        [Required]
        [StringLength(50,ErrorMessage ="Adınız en fazla 50 karakter uzunluğunda olabilir.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Soyadınız en fazla 50 karakter uzunluğunda olabilir.")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&.])[A-Za-z\d$@$!%*?&.]{6, 15}/")]
        [StringLength(15, ErrorMessage = "Şifreniz en fazla 15 karakter uzunluğunda olabilir.",MinimumLength =6)]
        public string Password { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Şifre bilgilerinizi kontrol ediniz.", MinimumLength = 6)]
        public string ConfirmPassword { get; set; }      
        [Required]
        [Range(18,100,ErrorMessage ="Yaşınız 18-100 arasında olmalıdır.")]
        public string BirthDay { get; set; }
        [CreditCard]
        public string CreditCard { get; set; }      
        [Url]
        public string FacebookProfileUrl { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }      
    }
}