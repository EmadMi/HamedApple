using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HamedApple.DAL
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderPrice { get; set; }

    }
}