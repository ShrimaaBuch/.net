using System;
using System.Web;

namespace Practical_5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserID"] != null)
                {
                    txtUserId.Text = Request.Cookies["UserID"].Value;
                    chkRemember.Checked = true;
                }
                else
                {
                    chkRemember.Checked = false;
                }
            }
        }

        protected void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkRemember.Checked)
            {
                if (Request.Cookies["UserID"] != null)
                {
                    HttpCookie cookie = new HttpCookie("UserID");
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie);
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text.Trim();
            string password = txtPassword.Text;

            if (userId == "Shrimaa" && password == "0410")
            {
                if (chkRemember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserID");
                    cookie.Value = userId;
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    if (Request.Cookies["UserID"] != null)
                    {
                        HttpCookie cookie = new HttpCookie("UserID");
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }
                }

                Session["LoggedIn"] = true;
                Response.Redirect("home.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid User ID or Password";
            }
        }
    }
}