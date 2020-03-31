using GroupingSortingIssue9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupingSortingIssue9.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult GetOrders(OrderRequest orderRequest)
        {
            OrderReturn OrderReturns = new OrderReturn();
            List<OrderModel> orders = getOrderCollection();

            if (orderRequest.filters != null && orderRequest.filters.Count > 0)
            {
                foreach (var item in orderRequest.filters)
                {
                    switch (item.datafield)
                    {
                        case "ShipName":
                            orders = orders.Where(x => x.ShipName.Contains(item.filtervalue)).ToList();
                            break;
                        case "ShipAddress":
                            orders = orders.Where(x => x.ShipAddress.Contains(item.filtervalue)).ToList();
                            break;
                        case "ShipCity":
                            orders = orders.Where(x => x.ShipCity.Contains(item.filtervalue)).ToList();
                            break;
                        case "ShipCountry":
                            orders = orders.Where(x => x.ShipCountry.Contains(item.filtervalue)).ToList();
                            break;

                    }
                }

            }
            if (!String.IsNullOrWhiteSpace(orderRequest.sortdatafield))
            {
                switch (orderRequest.sortdatafield)
                {
                    case "ShipName":
                        if (string.IsNullOrWhiteSpace(orderRequest.sortorder) || orderRequest.sortorder == "asc")
                        {
                            orders = orders.OrderBy(x => x.ShipName).ToList();
                        }
                        else
                        {
                            orders = orders.OrderByDescending(x => x.ShipName).ToList();
                        }

                        break;
                    case "ShipAddress":
                        if (string.IsNullOrWhiteSpace(orderRequest.sortorder) || orderRequest.sortorder == "asc")
                        {
                            orders = orders.OrderBy(x => x.ShipAddress).ToList();
                        }
                        else
                        {
                            orders = orders.OrderByDescending(x => x.ShipAddress).ToList();
                        }

                        break;
                    case "ShipCity":
                        if (string.IsNullOrWhiteSpace(orderRequest.sortorder) || orderRequest.sortorder == "asc")
                        {
                            orders = orders.OrderBy(x => x.ShipCity).ToList();
                        }
                        else
                        {
                            orders = orders.OrderByDescending(x => x.ShipName).ToList();
                        }

                        break;
                    case "ShipCountry":
                        if (string.IsNullOrWhiteSpace(orderRequest.sortorder) || orderRequest.sortorder == "asc")
                        {
                            orders = orders.OrderBy(x => x.ShipCountry).ToList();
                        }
                        else
                        {
                            orders = orders.OrderByDescending(x => x.ShipName).ToList();
                        }

                        break;

                }
            }
            OrderReturns.TotalRows = orders.Count;
            orders = orders.Skip((orderRequest.pagenum) * orderRequest.pagesize).Take(orderRequest.pagesize).ToList();
            OrderReturns.Orders = orders;
            return Json(OrderReturns);
        }
        public ActionResult Index()
        {
            return View();
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

        public List<OrderModel> getOrderCollection()
        {
            var orders = new List<OrderModel>
            {
                new OrderModel { ShipName="Package1" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package2" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package3" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package4" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package5" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package6" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package7" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package8" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package9" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package10" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package11" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package12" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package13" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package14" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package15" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package16" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package17" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package18" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},
                new OrderModel { ShipName="Package19" , ShipAddress="EC3R 7LP. London Street" , ShipCity="London", ShipCountry="Engalnd",ShippedDate=DateTime.Now},

                new OrderModel { ShipName="Package20" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package21" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package22" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package23" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package24" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package25" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package26" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package27" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package28" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package29" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
                new OrderModel { ShipName="Package30" , ShipAddress="Gougvon,street 123" , ShipCity="Noida", ShipCountry="India",ShippedDate=DateTime.Now.AddDays(1)},
            };



            return orders;

        }
    }
}