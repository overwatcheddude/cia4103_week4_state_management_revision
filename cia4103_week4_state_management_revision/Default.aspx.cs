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
        if (Request.Cookies["drinkCookie"] == null)
        {
            HttpCookie drinkCookie = new HttpCookie("drinkCookie");
            drinkCookie.Expires = DateTime.Today.AddDays(3);
            Response.Cookies.Add(drinkCookie);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("checkout.aspx");
    }
}