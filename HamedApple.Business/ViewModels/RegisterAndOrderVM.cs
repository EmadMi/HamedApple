using HamedApple.DAL;
using HamedApple.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.Business.ViewModels
{
    public class RegisterAndOrderVM
    {
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        [Display(Name = "شماره موبایل")]
        [StringLength(maximumLength: 11, MinimumLength = 11)]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "کدملی")]
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        public string NationCode { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "پست الکترونیک")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "{0} باید حداقل {2} کاراکتر باشد.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمزعبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تایید رمزعبور")]
        [Compare("Password", ErrorMessage = "رمز عبور و تایید رمز عبور باید یکسان باشند.")]
        public string ConfirmPassword { get; set; }
        public int OrderPrice { get; set; }
    }
}
