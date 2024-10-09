using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstRealAspWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            string first = TextFirst.Text;

            string last = TextLast.Text;

            string result = $"Hello {first} {last}";

            Label1.Text = result;
        }

        protected void TextFirst_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextLast_TextChanged(object sender, EventArgs e)
        {

        }
    }
}