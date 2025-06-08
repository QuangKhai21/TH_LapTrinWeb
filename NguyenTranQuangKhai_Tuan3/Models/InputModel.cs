using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace NguyenTranQuangKhai_Tuan3.Models
{
    public class InputModel
    {
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The password must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> RoleList { get; set; }

        // Thêm ngày sinh
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }



        // Thêm địa chỉ
        [StringLength(200)]
        public string Address { get; set; }

        // Thêm số điện thoại (nếu cần)
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

}
