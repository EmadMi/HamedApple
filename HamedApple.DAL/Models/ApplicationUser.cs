using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
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

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

    }
}
