using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWebForm
{
    public partial class PaginaError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = Session["errorLoco"].ToString();
        }
    }
}