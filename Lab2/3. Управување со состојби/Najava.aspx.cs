using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    
    public partial class Najava : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            int brojac;

            if (txtLozinka.Text.Equals("mp"))
            {
                Session["korisnik"] = txtKorisnik.Text;
                Response.Redirect("GlavnaStranica.aspx");
            }
            else
            {
                if(ViewState["Brojac"] == null)
                {
                    brojac = 1;
                }
                else
                {
                    brojac = (int)ViewState["Brojac"] + 1;
                }
                ViewState["Brojac"] = brojac;
                lblObidi.Text = brojac.ToString();
                if (brojac > 3)
                {
                    btnPodnesi.Enabled = false;
                    lblObidi.Text = "Ја надминавте квотата на дозволени обиди";
                }
                
                

            }
        }
    }
}