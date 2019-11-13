using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.Cookies["UserCookie"] != null)
        {
            Label1.Text = "Your cookie name is <i> '" + Request.Cookies["UserCookie"]["Name"].ToString() + "'</i> has been creted";
        }
        else
        {
            Label1.Text = "Cookie Not Found....";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie mycookie = new HttpCookie("UserCookie");
        mycookie.Expires = DateTime.Now.AddDays(-1d);
        Response.Cookies.Add(mycookie);

        Response.Redirect("Result.aspx");
    }
}