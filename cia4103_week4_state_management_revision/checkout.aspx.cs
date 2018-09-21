using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkout : System.Web.UI.Page
{
    private String smoothieRow(string smoothieName, int smoothieQuantitiy)
    {
        if (smoothieQuantitiy != 0)
        {
            String row = "<tr>" +
                         "<td><img src=\"Smoothieimages/" + smoothieName +".jpg\" width=\"115\" height=\"140\"></td>" +
                         "<td>" + smoothieQuantitiy.ToString() + "</td>" +
                         "<td>18</td>" +
                     "</tr>";

            return row;
        }
        else
        {
            return "";
        }
    }

    private int smoothieQuantity(String cookieValue)
    {
        if (cookieValue != null)
        {
            return int.Parse(cookieValue);
        }
        else
        {
            return 0;
        }
    }

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

        //Populates the table with smoothie rows if quantity is more than 0.
        table += smoothieRow("smoothie1", smoothie1);
        table += smoothieRow("smoothie2", smoothie2);
        table += smoothieRow("smoothie3", smoothie3);

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