using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            LabelResult.Text = DropDownList1.Text;
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            LabelAllResult.Text = TextName.Text + " " + LabelResult.Text;

            if (RdoMarketing.Checked == true)
            {
                LabelAllResult.Text += " " +RdoMarketing.Text;
            }
            else if (RdoAccounting.Checked == true)
            {
                LabelAllResult.Text += " " +RdoAccounting.Text;
            }
            else if (RdoLegal.Checked == true)
            {
                LabelAllResult.Text += " " +RdoLegal.Text;
            }

            if (ChkBA.Checked == true)
            {
                LabelAllResult.Text += " " +ChkBA.Text;
            }
            if (ChkMA.Checked == true)
            {
                LabelAllResult.Text += " " +ChkMA.Text;
            }
            if (ChkPHD.Checked == true)
            {
                LabelAllResult.Text += " " +ChkPHD.Text;
            }
        }
    }
}