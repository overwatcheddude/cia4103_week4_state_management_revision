using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // read the value of the query string passed from the home page
        String id = Request.QueryString["id"];

        //save it into the cookie
        if (Request.Cookies["drinkCookie"] != null)
        {
            //Get cookie object.
            HttpCookie drinkCookie = Request.Cookies["drinkCookie"];

            //Read value from cookie, if no value exists, then set initial value as 0.
            int smoothie1 = 0;
            int smoothie2 = 0;
            int smoothie3 = 0;

            //If the cookie value is not empty, then get the current value from the cookie.
            if (drinkCookie.Values["smoothie1"] != null)
            {
                smoothie1 = int.Parse(drinkCookie.Values["smoothie1"]);
            }
            if (drinkCookie.Values["smoothie2"] != null)
            {
                smoothie2 = int.Parse(drinkCookie.Values["smoothie2"]);
            }
            if (drinkCookie.Values["smoothie3"] != null)
            {
                smoothie3 = int.Parse(drinkCookie.Values["smoothie3"]);
            }

            //Increase the quantity based on the id.
            if (id == "1")
            {
                smoothie1++;
            }
            if (id == "2")
            {
                smoothie2++;
            }
            if (id == "3")
            {
                smoothie3++;
            }

            //Add to cookie values
            drinkCookie.Values["smoothie1"] = smoothie1.ToString();
            drinkCookie.Values["smoothie2"] = smoothie2.ToString();
            drinkCookie.Values["smoothie3"] = smoothie3.ToString();

            //Confirm changes to cookie object.
            Response.Cookies.Add(drinkCookie);
        }

        //After saving the value in the cookie, the user should be redirected to the home page.
        Response.Redirect("Default.aspx");
    }
}