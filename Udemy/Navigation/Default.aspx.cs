using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navigation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {

            Session["pw"] = TxtPass.Text;

            Response.Redirect("Page2.aspx" + "?q=" + TextBox1.Text );

            
        }
    }
}