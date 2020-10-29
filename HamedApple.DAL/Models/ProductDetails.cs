using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HamedApple.DAL
{
    public class ProductDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int RefrenceId { get; set; }
        [Required]
        public virtual Refrence Refrence { get; set; }
        [Required]
        public int OrderValue { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ProductDetailAnswers> ProductDetailAnswers { get; set; }
    }
}