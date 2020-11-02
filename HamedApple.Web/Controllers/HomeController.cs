using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Routing;
using HamedApple.Business.Interfaces;
using HamedApple.Business.ViewModels;

namespace HamedAppleMVCNew.Controllers
{
    public class HomeController : Controller
    {
        IIndexService _IndexService;
        public HomeController(IIndexService IndexService)
        {
            _IndexService = IndexService;
        }
        public ActionResult Index()
        {
            var IndexItems = _IndexService.GetIndexData();

            return View(IndexItems);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoadTopNavBar()
        {
            IEnumerable<RefrenceVM> RefrenceList = _IndexService.GetRefrenceList(false);
            string PermissionId = "";
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                if (HttpContext.User.IsInRole("Admin"))
                {
                    PermissionId = RefrenceList.Where(pi => pi.Name == "Admin" &&
                            pi.Parent.Name == "Permissions").Select(pi => pi.Id).FirstOrDefault().ToString();
                }
                else if (HttpContext.User.IsInRole("Customer"))
                {
                    PermissionId = RefrenceList.Where(pi => pi.Name == "Customer" &&
                            pi.Parent.Name == "Permissions").Select(pi => pi.Id).FirstOrDefault().ToString();
                }
            }
            else
            {
                PermissionId = RefrenceList.Where(pi => pi.Name == "Guest" &&
                            pi.Parent.Name == "Permissions").Select(pi => pi.Id).FirstOrDefault().ToString();
            }
            //
            var layoutVModel = new LayoutVM();
            layoutVModel.NavbarItems = RefrenceList.Where(ni => ni.Parent.Name == "SitePages" &&
                                            ni.GroupRef.Contains(PermissionId)).OrderBy(nio => nio.OrderValue).ToList();

            return PartialView("_LoadTopNavBar", layoutVModel);
        }
    }
}