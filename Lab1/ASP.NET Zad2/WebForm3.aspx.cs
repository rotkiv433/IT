using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void btnProveri_Click(object sender, EventArgs e)
        {
            if(txtLozinka.Text.Equals("мрежно програмирање"))
            {
                txtPoraka.ReadOnly = false;
                txtPoraka.Text = "";
                txtPoraka.Focus();
            }
            else
            {
                txtPoraka.ReadOnly = true;
                Response.Write("<script>alert('Грешна лозинка')</script>");
            }
        }

        protected void txtPoraka_TextChanged(object sender, EventArgs e)
        {
            btnPrvaStrana.Enabled = true;
        }
        protected void txtPoraka_MouseOut(object sender, EventArgs e)
        {
            if(txtPoraka.Text!="")
            {
                btnPrvaStrana.Enabled = true;
            }
        }


        protected void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnPrvaStrana_Click(object sender, EventArgs e)
        {

        }
    }
}