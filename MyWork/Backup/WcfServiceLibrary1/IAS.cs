using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Web.Http.Cors;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAS
    {
        

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "Post",RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Insertdata")]
        string Insertdata(employee employee);
       
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class employee
    {
        [DataMember]
        public string CustomerID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }

        [DataMember]
        public string CompanyName
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }
    [DataMember]
        public string ContactName
        {
            get { return ContactName; }
            set { ContactName = value; }
        }
    [DataMember]
        public string ContactTitle
        {
            get { return ContactTitle; }
            set { ContactTitle = value; }
        }
    [DataMember]
        public string Address
        {
            get { return Address; }
            set { Address = value; }
        }
    [DataMember]
        public string City
        {
            get { return City; }
            set { City = value; }
        }
    [DataMember]
        public string Region
        {
            get { return Region; }
            set { Region = value; }
        }
    [DataMember]
        public string PostalCode
        {
            get { return PostalCode; }
            set { PostalCode = value; }
        }
    [DataMember]
        public string Country
        {
            get { return Country; }
            set { Country = value; }
        }
     [DataMember]
        public string Phone
        {
            get { return Phone; }
            set { Phone = value; }
        }
     [DataMember]
        public string Fax
        {
            get { return Fax; }
            set { Fax = value; }
        }
    }
}
