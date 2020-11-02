using HamedApple.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.Business.ViewModels
{
    public class ProductDetailAnswersVM
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
