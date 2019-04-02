using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class DefaultB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
           
                if(rfv1.IsValid && rfv2.IsValid && rfv3.IsValid &&
                    rfv4.IsValid && rfv5.IsValid && rfv6.IsValid &&
                    rfv7.IsValid && rfv8.IsValid && rexv1.IsValid && 
                    rexv2.IsValid && cv1.IsValid)
                {
                    bool selectedItem = false;
                    foreach (ListItem item in ddlZanimanje.Items)
                    {
                        if (ddlZanimanje.SelectedItem != null)
                        {
                            selectedItem = true;
                            break;
                        }
                    }
                    bool isLetter = false;
                    char[] letter = txtGodini.Text.ToCharArray();
                    foreach (char c in letter)
                    {
                        if (char.IsLetter(c))
                        {
                            isLetter = true;
                            break;
                        }
                    }
                    if (selectedItem == false)
                    {
                        lblZanimanje.Text = "Не одбравте занимање!";
                        lblSmetka.Text = "";
                    }
                    if (isLetter)
                    {
                        lblGodini.Text = "Недозволена вредност!";
                        lblSmetka.Text = "";
                    }
                    
                    if (selectedItem == true && isLetter == false)
                    {
                        string s = new string(letter);
                        if(string.IsNullOrEmpty(s))
                    {
                        lblGodini.Text = "Внесете вредност за години!";
                        lblSmetka.Text = "";
                    }
                    int x = 0;
                    if(Int32.TryParse(s, out x))
                    {
                        int godini = int.Parse(s);
                        if(godini>=5)
                        {
                            lblSmetka.Text = txtFinkiID.Text+ "@finki.ukim.mk";
                            lblGodini.Text = "";
                        }
                        else
                        {
                            lblGodini.Text = "";
                            lblSmetka.Text = "Немате доволно искуство";
                        }
                    }
                    
                        
                    }
                }
            
        }

        
    }
}