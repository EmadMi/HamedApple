using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HamedApple.DAL
{
    public class ProductDetailAnswers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductDetailId { get; set; }
        public virtual ProductDetails ProductDetail { get; set; }
        [Required]
        public string AnswerValue { get; set; }
        [Required]
        public int OrderValue { get; set; }
        public bool IsActive { get; set; }
    }
}