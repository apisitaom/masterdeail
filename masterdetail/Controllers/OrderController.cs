using masterdetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult saveOrder(string name, string address, Order[] order) {
            string result = "Error! Order is not complete!!!";
            if (name != null || address != null || order != null) {
                var customerId = Guid.NewGuid();
                Customer model = new Customer();
                model.CustomerId = customerId;
                model.Name = name;
                model.Address = address;
                model.OrderDate = DateTime.Now;
                db.Customers.Add(model);

                foreach (var item in order) {
                    var orderId = Guid.NewGuid();
                    Order O = new Order();
                    O.OrderId = orderId;
                    O.ProductName = item.ProductName;
                    O.Quantity = item.Quantity;
                    O.Price = item.Price;
                    O.Amount = item.Amount;
                    O.CustomerId = customerId;
                    db.Orders.Add(O);
                }
                db.SaveChanges();
                result = "SUCCESS FOR ORDER ^_^";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}