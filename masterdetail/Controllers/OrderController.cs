using masterdetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace masterdetail.Controllers
{
    public class OrderController : Controller
    {
        OnlineShopEntities db = new OnlineShopEntities();
        public ActionResult Index()
        {
            List<Customer> OrderAndCustomerList = db.Customers.ToList(); 
            return View(OrderAndCustomerList);
        }
    }
}