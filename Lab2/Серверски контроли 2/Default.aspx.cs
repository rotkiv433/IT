using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPanela.Visible = false;
            lblPosluga.Text = "";
            if (!this.IsPostBack)
            {
                for (int i=1;i<=31;i++)
                {
                    ddlDen.Items.Add(i.ToString());
                }
                string[] niza = {"Јануари","Февруари","Март","Април",
                                 "Мај","Јуни","Јули","Август","Септември",
                                  "Октомври","Ноември","Декември"};

                for(int i=0;i<niza.Length;i++)
                {
                    ddlMesec.Items.Add(niza[i]);
                }
                for(int i=2019;i<=2024;i++)
                {
                    ddlGodina.Items.Add(i.ToString());
                }


                for(int i=0;i<=2;i++)
                {
                    for(int j=0;j<=9;j++)
                    {
                        ddlVreme.Items.Add(i.ToString() + j.ToString()+":00");
                        if (i == 2 && j == 3)
                            break;
                    }
                }
                
                
                
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            bool checkIme = !string.IsNullOrEmpty(txtBoxIme.Text);
            bool checkPrezime = !string.IsNullOrEmpty(txtBoxPrezime.Text);
            bool checkBoxList = false;
            bool checkRblKlasa = rblKlasa.SelectedItem!=null;
            bool checkRblZona = rblZona.SelectedItem != null;
            bool checkLstSredstvo = lstSredstvo.SelectedIndex != -1;
            foreach(ListItem item in cblPosluga.Items)
            {
                if (item.Selected == false)
                    checkBoxList = false;
                else
                {
                    checkBoxList = true;
                    break;
                }
            }

            if (checkIme == false || checkPrezime == false || checkBoxList == false
                || checkRblKlasa == false || checkRblZona == false || checkLstSredstvo == false)
                lblWarning.Text = "Ве молиме пополнете ги сите полиња!";
            else
            {
                lblPanela.Visible = true;
                lblWarning.Text = "";
                lblPatnik.Text = txtBoxIme.Text + " " + txtBoxPrezime.Text;
                lblSredstvo.Text = lstSredstvo.SelectedItem.Text;

                lblOd.Text = ddlOd.SelectedItem.Text;
                lblDo.Text = ddlDo.SelectedItem.Text;
                lblVreme.Text = ddlVreme.SelectedItem.Text;
                lblZona.Text = rblZona.SelectedItem.Text;
                lblKlasa.Text = rblKlasa.SelectedItem.Text;
                if(lblSredstvo.Text.Equals("Воз"))
                {
                    slika.ImageUrl = "~/train.jpg";
                }
                else
                {
                    slika.ImageUrl = "~/airplane.jpg";
                }
                foreach(ListItem item in cblPosluga.Items)
                {
                    if(item.Selected)
                    {
                        lblPosluga.Text += item.Text+" ";
                    }
                }
            }
            
        }
    }
}