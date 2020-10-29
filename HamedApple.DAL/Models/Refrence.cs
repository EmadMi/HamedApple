using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HamedApple.DAL
{
    public class Refrence
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

    }
}