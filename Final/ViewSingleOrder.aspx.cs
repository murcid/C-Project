using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class ViewSingleOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            ClassCustomerOrder order;
            if (int.TryParse(Request.QueryString["Order.Id"], out id))
            {
                order = DataUtilityClass.SelectOrderByID(id);
                if (order != null)
                {
                    var html = "<div id='FirstPart'>";
                    html += "<h1>Order Information</h1>";
                    html += "<table id='TblOrder'><tr><th>Customer Name</th><th>address</th><th>Phone Number</th></tr>";
                    html += "<tr>";
                    html += "<td>";
                    html += order.Customers.FirstName + " " + order.Customers.LastName;
                    html += "</td>";
                    html += "<td>";
                    html += order.Customers.Address + " " + order.Customers.City + " " + order.Customers.State + " " + order.Customers.ZipCode; 
                    html += "</td>";
                    html += "<td>";
                    html += order.Customers.Phone;
                    html += "</td>";
                    html += "</tr>";
                    html += "</table>";
                    html += "</div>";
                    html += "<div id='SecondPart'>";
                    html += "<h3>Products Bought</h3>";
                    if (order.Orders.P1 != 0)
                    {
                        html += "<p><label ID='LblP1'>Cool Ranch Doritos Socks: ";
                        html += order.Orders.P1;
                        html += "</label></p>";
                        //html += "<br />";
                    }
                    if (order.Orders.P2 != 0)
                    {
                        html += "<p><label ID='LblP2'>Extra Flaming Hot Crunchy Cheetos Socks: ";
                        html += order.Orders.P2;
                        html += "</label></p>";
                        //html += "<br />";
                    }
                    if (order.Orders.P3 != 0)
                    {
                        html += "<p><label ID='LblP3'>Red Ice & Blue Ice Socks: ";
                        html += order.Orders.P3;
                        html += "</label></p>";
                        //html += "<br />";
                    }
                    html += "</div>";
                    html += "<div id='ThirdPart'>";
                    html += "<p><label ID='LblSubtotal'>Subtotal: $";
                    html += order.Orders.Subtotal;
                    html += "</label></p>";
                    html += "<p><label ID='LblTax'>Tax: $";
                    html += order.Orders.Tax;
                    html += "</label></p>";
                    html += "<p><label ID='LblTotal'>Total: $";
                    html += order.Orders.Total;
                    html += "</label></p>";
                    html += "</div>";
                    DivTableResults.InnerHtml = html;
                }
            //    else
            //    {
            //        Response.Redirect("ViewOrders.aspx");
            //    }
            }
            //else
            //{
            //    Response.Redirect("ViewOrders.aspx");
            //}
        }
    }
}