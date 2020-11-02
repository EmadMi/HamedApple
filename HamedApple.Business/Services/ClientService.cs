using HamedApple.Business.Interfaces;
using HamedApple.Business.ViewModels;
using HamedApple.DAL;
using HamedApple.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.Business.Services
{
    public class ClientService : IClientService
    {
        HamedAppleContext db;
        public ClientService()
        {
            db = new HamedAppleContext();
        }
        public void Dispose()
        {
            db?.Dispose();
        }
        public IEnumerable<ProductVM> GetProducts()
        {
            return db.Product.Select(x => new ProductVM()
            {
                Id = x.Id,
                Title = x.Title,
                TypeId = x.TypeId,
                Type = x.Type,
                IsActive = x.IsActive,
                OrderValue = x.OrderValue,
                ProductDetails = x.ProductDetails
            }).ToList();
        }
        public Product GetProduct(int Id)
        {
            return db.Product.Find(Id);
        }
        public IEnumerable<ProductDetailsVM> GetProductDetails(int? IdProduct)
        {
            if (IdProduct == null)
            {
                return db.ProductDetail.Select(x => new ProductDetailsVM()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    Product = x.Product,
                    RefrenceId = x.RefrenceId,
                    Refrence = x.Refrence,
                    ProductDetailAnswers = x.ProductDetailAnswers,
                    IsActive = x.IsActive,
                    OrderValue = x.OrderValue
                }).ToList();
            }
            else
            {
                return db.ProductDetail.Where(x => x.Id == IdProduct).Select(x => new ProductDetailsVM()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    Product = x.Product,
                    RefrenceId = x.RefrenceId,
                    Refrence = x.Refrence,
                    ProductDetailAnswers = x.ProductDetailAnswers,
                    IsActive = x.IsActive,
                    OrderValue = x.OrderValue
                }).ToList();
            }
        }
        public IEnumerable<ProductDetailAnswersVM> GetProductDetailAnswer()
        {
            return db.ProductDetailAnswer.Select(x => new ProductDetailAnswersVM()
            {
                Id = x.Id,
                AnswerValue = x.AnswerValue,
                ProductDetailId = x.ProductDetailId,
                ProductDetail = x.ProductDetail,
                IsActive = x.IsActive,
                OrderValue = x.OrderValue
            }).ToList();
        }
        public IEnumerable<ProductDetailAnswersVM> GetProductDetailAnswer(int ProductId)
        {
            return db.ProductDetailAnswer.Where(x => x.ProductDetail.ProductId == ProductId).Select(x => new ProductDetailAnswersVM()
            {
                Id = x.Id,
                AnswerValue = x.AnswerValue,
                ProductDetailId = x.ProductDetailId,
                ProductDetail = x.ProductDetail,
                IsActive = x.IsActive,
                OrderValue = x.OrderValue
            }).ToList();
        }
        public IEnumerable<ProductDetailAnswersVM> GetProductDetailAnswer(int ProductId,int ProductDetailId)
        {
            return db.ProductDetailAnswer.Where(x => x.ProductDetailId == ProductDetailId && x.ProductDetail.ProductId == ProductId).Select(x => new ProductDetailAnswersVM()
            {
                Id = x.Id,
                AnswerValue = x.AnswerValue,
                ProductDetailId = x.ProductDetailId,
                ProductDetail = x.ProductDetail,
                IsActive = x.IsActive,
                OrderValue = x.OrderValue
            }).ToList();
        }
    }
}
