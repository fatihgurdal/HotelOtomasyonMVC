using System.ComponentModel.DataAnnotations;

namespace ProjectTemplate.Core.Enums
{
    public enum Role
    {
        [Display(Name = "Admin")]
        Admin,
        [Display(Name = "Kullanıcı")]
        User
    }
}