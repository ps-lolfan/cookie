using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie mycookie = new HttpCookie("UserCookie");
        mycookie["Name"] = TextBox1.Text;
        mycookie.Expires = DateTime.Now.AddDays(1d);
        Response.Cookies.Add(mycookie);

        Label1.Text = "Cookies has been added successfully...";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Result.aspx");
    }
}