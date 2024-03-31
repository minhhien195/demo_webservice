using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_Service_demo
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
   // [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        //[WebMethod(MessageName = "Sum of Ints")]
        [WebMethod]
        public int Sum(int x, int y)
        {
            return x + y;
        }
        [WebMethod(MessageName = "Sum of Floats")]
        public float Sum(float x, float y)
        {
            return x + y;
        }
        [WebMethod(MessageName = "Product of Numbers")]
        public float Products(float x, float y)
        {
            return x * y;
        }
        [WebMethod(MessageName = "Division of Numbers")]
        public float Divisions(float x, float y)
        {
            return x / y;
        }

    }
}
