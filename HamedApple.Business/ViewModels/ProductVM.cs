﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamedApple.DAL;

namespace HamedApple.Business.ViewModels
{
    public class ProductVM
    {
        [Key]
        public int Id { get; set; }
        public int TypeId { get; set; }
        public virtual Refrence Type { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int OrderValue { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
