using System.ComponentModel.DataAnnotations;

namespace _FluentValidationApp.Models
{
    public class UserInfo
    {
       // [Required(ErrorMessage = "olmadi bu is"),MaxLength(50)]
        public string NameSurname { get; set; }
        public string? Status { get; set; }
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public IList<UserAddress> UserAddresses { get; set; }
        public Gender Cinsiyet { get; set; }
    }
    public enum Gender
    {
        Kadin,
        Erkek
    }
}
