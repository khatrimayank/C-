using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizaaStore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*protected void Result_Click(object sender, EventArgs e)
        {
            if (RdoPizza.Checked == true)
            {
                LabelResult.Text = "You Pick " + RdoPizza.Text;
                ImageFood.ImageUrl = "Images/pizza.png";

            }
            else if (RdoMama.Checked == true)
            {
                LabelResult.Text = "You Pick " + RdoMama.Text;
                ImageFood.ImageUrl = "Images/salad.gif";
            }
            else if (RdoPapa.Checked == true)
            {
                LabelResult.Text = "You Pick " + RdoPapa.Text;
                ImageFood.ImageUrl = "Images/peanutbutter.png";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            foreach (ListItem x in CheckBoxList1.Items)
            {   
                if (x.Selected == true)
                {
                    LabelResult.Text += "You Picked " + x.Value + "<br/>";
                }
                
            }
        }*/

        protected void BtnPurchase_Click(object sender, EventArgs e)
        {
            LabelResult.Text = "Total: $";

            double sum = 0.00;

            if (RdoBaby.Checked == true)
            {
                sum += 10.00;
            }
            else if (RdoMama.Checked == true)
            {
                sum += 13.00;
            }
            else if (RdoPapa.Checked == true)
            {
                sum += 16.00;
            }

            if (RdoDeepCrust.Checked == true)
            {
                sum += 2.00;
            }

            if (Chkpepperoni.Checked == true)
            {
                sum += 1.5;
            }
            if (Chkgreenpeppers.Checked == true)
            {
                sum += .75;
            }
            if (Chkanchovies.Checked == true)
            {
                sum += .5;
            }
            if (Chkredpeppers.Checked == true)
            {
                sum += .5;
            }
            if (Chkonions.Checked == true)
            {
                sum += 2;
            }
            
            bool condition1= (Chkpepperoni.Checked == true && Chkanchovies.Checked == true && Chkonions.Checked == true);

            bool condition2= (Chkpepperoni.Checked == true && Chkgreenpeppers.Checked == true && Chkredpeppers.Checked == true);

            if (condition1 || condition2)
            {
                sum -= 2.00;
            }
            LabelResult.Text += sum;
        }
    }
}