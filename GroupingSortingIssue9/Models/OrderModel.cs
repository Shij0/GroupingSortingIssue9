using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupingSortingIssue9.Models
{
    public class OrderRequest
    {
        public int filterscount { get; set; }
        public int groupscount { get; set; }
        public int pagenum { get; set; }
        public int pagesize { get; set; }
        public int recordstartindex { get; set; }
        public int recordendindex { get; set; }
        public string sortdatafield { get; set; }
        public string sortorder { get; set; }
        public List<filter> filters { get; set; }
    }
    public class filter
    {
        public string datafield { get; set; }
        public string filtervalue { get; set; }
        public string filtercondition { get; set; }
    }
    public class OrderReturn
    {
        public OrderReturn()
        {
            Orders = new List<OrderModel>();
        }
        public List<OrderModel> Orders { get; set; }
        public int TotalRows { get; set; }
    }
    public class OrderModel
    {
        public DateTime ShippedDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
    }
}