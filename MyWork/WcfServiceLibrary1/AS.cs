using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using MyWork;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AS : IAS
    {
        
        public string Insertdata(employee employee)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
           
            MyWork.Models.NorthwindEntities enz = new MyWork.Models.NorthwindEntities();
            enz.InsertCustomers(employee.CustomerID, employee.CompanyName, employee.ContactName, employee.ContactTitle, employee.Address, employee.City, employee.Region, employee.PostalCode, employee.Country, employee.Phone, employee.Fax);
            return "success";
        }
      
        
    }
}
