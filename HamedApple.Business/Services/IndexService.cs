using HamedApple.Business.Interfaces;
using HamedApple.Business.ViewModels;
using HamedApple.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.Business.Services
{
    public class IndexService : IIndexService
    {
        HamedAppleContext db;
        public IndexService()
        {
            db = new HamedAppleContext();
        }
        public void Dispose()
        {
            db?.Dispose();
        }

        public IndexVM GetIndexData()
        {
            var IndexVm = new IndexVM();
            IndexVm.NewsList = db.News.Where(n => n.IsActive == true).OrderBy(no => no.OrderValue).Select(x => new NewsVM() {
                Id = x.Id,
                Caption = x.Caption,
                SmallDesc = x.SmallDesc,
                ImageName = x.ImageName,
                IsActive = x.IsActive,
                OrderValue = x.OrderValue
            }).ToList();
            IndexVm.ProductList = db.Product.Where(p => p.IsActive == true && p.Type.Name == "AppleId").OrderBy(po => po.OrderValue).Select(x => new ProductVM()
            {
                Id = x.Id,
                Title = x.Title,
                TypeId = x.TypeId,
                IsActive = x.IsActive,
                OrderValue = x.OrderValue,
                ProductDetails = x.ProductDetails,
                Type = x.Type
            }).ToList();

            return IndexVm;

        }
        public IEnumerable<RefrenceVM> GetRefrenceList(bool WithParents)
        {
            IEnumerable<RefrenceVM> RefrenceList;
            if (WithParents)
            {
                RefrenceList = db.Refrence.Select(x => new RefrenceVM()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Name = x.Name,
                    RoleCode = x.RoleCode,
                    GroupRef = x.GroupRef,
                    ParentId = x.ParentId,
                    IsActive = x.IsActive,
                    OrderValue = x.OrderValue,
                    Parent = x.Parent,
                    Children = x.Children,
                    ProductDetails = x.ProductDetails,
                    Products = x.Products
                }).ToList();
            }
            else
            {
                RefrenceList = db.Refrence.Where(x => x.ParentId != null).Select(x => new RefrenceVM()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Name = x.Name,
                    RoleCode = x.RoleCode,
                    GroupRef = x.GroupRef,
                    ParentId = x.ParentId,
                    IsActive = x.IsActive,
                    OrderValue = x.OrderValue,
                    Parent = x.Parent,
                    Children = x.Children,
                    ProductDetails = x.ProductDetails,
                    Products = x.Products
                }).ToList();
            }
            return RefrenceList;
        }
    }
}
