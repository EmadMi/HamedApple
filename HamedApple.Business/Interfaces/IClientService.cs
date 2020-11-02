using HamedApple.Business.ViewModels;
using HamedApple.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.Business.Interfaces
{
    public interface IClientService : IDisposable
    {
        IEnumerable<ProductVM> GetProducts();
        Product GetProduct(int Id);
        IEnumerable<ProductDetailsVM> GetProductDetails(int? IdProduct);
        IEnumerable<ProductDetailAnswersVM> GetProductDetailAnswer();
        IEnumerable<ProductDetailAnswersVM> GetProductDetailAnswer(int ProductId);
        IEnumerable<ProductDetailAnswersVM> GetProductDetailAnswer(int ProductId,int ProductDetailId);
    }
}
