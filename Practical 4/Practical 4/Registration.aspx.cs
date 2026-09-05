using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_4
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // nothing needed here for this practical
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                pnlResult.Visible = false;
                return;
            }

            lblStudentName.Text = txtStudentName.Text;
            lblEnrollment.Text = txtEnrollment.Text;
            lblAge.Text = TextBox1.Text;
            lblPassword.Text = TextBox2.Text;
            lblConfirmPassword.Text = TextBox3.Text;
            lblEmail.Text = txtEmail.Text;
            lblMobile.Text = txtMobile.Text;
            lblDepartment.Text = ddlDepartment.SelectedItem.Text;
            lblGender.Text = rblGender.SelectedItem.Text;

            List<string> chosenEvents = new List<string>();

            if (CheckBox1.Checked) chosenEvents.Add(CheckBox1.Text);
            if (CheckBox2.Checked) chosenEvents.Add(CheckBox2.Text);
            if (CheckBox3.Checked) chosenEvents.Add(CheckBox3.Text);

            lblEvent.Text = string.Join(", ", chosenEvents);

            lblDate.Text = (Calendar1.SelectedDate != DateTime.MinValue)
                ? Calendar1.SelectedDate.ToShortDateString()
                : "No Date Selected";

            pnlResult.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e){}

        protected void cvEvent_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool anyChecked = CheckBox1.Checked || CheckBox2.Checked || CheckBox3.Checked;
            args.IsValid = anyChecked;
        }

        protected void cvDate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = Calendar1.SelectedDate != DateTime.MinValue;
        }
    }
}