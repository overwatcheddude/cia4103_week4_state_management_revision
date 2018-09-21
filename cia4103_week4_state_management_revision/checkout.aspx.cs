using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkout : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["drinkCookie"] == null)
        {
            Response.Redirect("Default.aspx");
            return;
        }
        //read the values from the cookie
        HttpCookie drinkCookie = Request.Cookies["drinkCookie"];
        int smoothie1 = int.Parse(drinkCookie.Values["smoothie1"]);
        int smoothie2 = int.Parse(drinkCookie.Values["smoothie2"]);
        int smoothie3 = int.Parse(drinkCookie.Values["smoothie3"]);

        double totalPrice = (smoothie1 + smoothie2 + smoothie3) * 18;

        //Creates a table.
        String table = "<table style=\"width:100%\">" +
                        "<tr>" + //Header row
                            "<td><strong>Flavor</strong></td>" +
                            "<td><strong>Quantitiy</strong></td>" +
                            "<td><strong>Price</strong></td>" +
                        "</tr>";

        if (smoothie1 != 0)
        {
            table += "<tr>" +
                         "<td><img src=\"Smoothieimages/smoothie1.jpg\" width=\"115\" height=\"140\"></td>" +
                         "<td>" + smoothie1 + "</td>" +
                         "<td>18</td>" +
                     "</tr>";
        }
        if (smoothie2 != 0)
        {
            table += "<tr>" +
                         "<td><img src=\"Smoothieimages/smoothie2.jpg\" width=\"115\" height=\"140\"></td>" +
                         "<td>" + smoothie2 + "</td>" +
                         "<td>18</td>" +
                     "</tr>";
        }
        if (smoothie3 != 0)
        {
            table += "<tr>" +
                         "<td><img src=\"Smoothieimages/smoothie3.jpg\" width=\"115\" height=\"140\"></td>" +
                         "<td>" + smoothie3 + "</td>" +
                         "<td>18</td>" +
                     "</tr>";
        }

        table += "<tr>" +
            "<td>Total</td>" +
            "<td></td>" + //Left empty intentionally.
            "<td>" + totalPrice + " AED</td>" +
            "</tr>";

        //Closes the table tag.
        table += "</table>";

        //Applies table.
        Label1.Text = table;
    }
}