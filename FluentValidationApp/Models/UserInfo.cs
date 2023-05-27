using System.ComponentModel.DataAnnotations;

namespace FluentValidationApp.Models
{
    public class UserInfo
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Dolu Olmali")]
        public string NameSurname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Dolu Olmali")]
        public string Status { get; set; }
        public int Age { get; set; }
    }
}
