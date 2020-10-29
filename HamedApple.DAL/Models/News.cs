using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HamedApple.DAL
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        public string SmallDesc { get; set; }
        [Required]
        public string ImageName { get; set; }
        [Required]
        public int OrderValue { get; set; }
        public bool IsActive { get; set; }
    }
}