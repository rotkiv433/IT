using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                lblVreme1.Text = DateTime.Now.ToString();
        }

        protected void btnVreme1_Click(object sender, EventArgs e)
        {
            lblVreme2.Text = DateTime.Now.ToString();
        }
    }
}