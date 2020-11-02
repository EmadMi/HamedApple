using HamedApple.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HamedApple.Business.ViewModels
{
    public class IndexVM
    {
        public List<NewsVM> NewsList { get; set; }
        public List<ProductVM> ProductList { get; set; }
    }
}