using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace web
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HA7S6MU\SQLEXPRESS;Initial Catalog = LTMCB_BT1;Integrated Security=True");
        [WebMethod]
        public DataSet getdata(string cmd) 
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(cmd, conn); 
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            conn.Close();
            adapter.Fill(ds);
            return ds;
        }

        [WebMethod]
        public string excute(string cmds)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(cmds, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                return "Yes";
            }
            catch (Exception)
            {
                return "No";
            }
                
        }
    }
}
