using HamedApple.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.Business.ViewModels
{
    public class RefrenceVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Name { get; set; }
        public int RoleCode { get; set; }
        public string GroupRef { get; set; }
        public int? ParentId { get; set; }
        public virtual Refrence Parent { get; set; }
        public virtual ICollection<Refrence> Children { get; set; }
        public int OrderValue { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
