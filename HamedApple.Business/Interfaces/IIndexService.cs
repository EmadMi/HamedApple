using HamedApple.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamedApple.Business.Interfaces
{
    public interface IIndexService : IDisposable
    {
        ///<summary>
        /// لیست تمامی آبجکت های موجود در ایندکس
        ///</summary>
        ///

        IndexVM GetIndexData();
        IEnumerable<RefrenceVM> GetRefrenceList(bool WithParents);
    }
}
