using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumingWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btncalculate_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            int result = client.Sum(Convert.ToInt32(txtFirstNumber.Text),
                                    Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
        }
    }
}