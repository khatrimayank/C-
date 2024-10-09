using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navigation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Check if the session variable exists and is not null
                if (Session["pw"] != null && Session["pw"].ToString() != "cc")
                {
                    // Display the session variable
                    LabelResult.Text = "Welcome" + Request.QueryString["q"] +"Your Password is :" + Session["pw"].ToString();
                }
                else
                {
                    // Redirect to Default.aspx if session variable is not set
                    Response.Redirect("Default.aspx");
                }
            }

            else
            {
                LabelResult.Text = "Welcome";
            }
        }
    }
}