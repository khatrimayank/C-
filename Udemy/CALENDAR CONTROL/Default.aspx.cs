using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CALENDAR_CONTROL
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LabelResult.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            LabelResult.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void BtnSet_Click(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = DateTime.Parse("2024/8/9");
            Calendar1.VisibleDate = Calendar1.SelectedDate;
            
        }

        protected void BtnDiff_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                LabelResult.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }

            else
            {
                LabelResult.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString();
            }
        }
    }
}