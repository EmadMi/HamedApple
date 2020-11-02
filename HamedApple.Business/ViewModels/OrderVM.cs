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
    public class OrderVM
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public ApplicationUser User { get; set; }
        public int OrderPrice { get; set; }
        public long OrderCode { get; set; }
        public string OrderAuthorizeId { get; set; }
        public string OrderAuthorizeLink { get; set; }
        public int OrderAuthorizeStatusId { get; set; }
        public virtual Refrence OrderAuthorizeStatus { get; set; }
        public DateTime AuthorizeDate { get; set; }
    }
}
