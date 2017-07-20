using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class ViewOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                List<ClassCustomerOrder> order = DataUtilityClass.GetOrderEntries();
                BuildHTMLTable(order);
                BuildOrderDropDown(order);
            }
        }

        private void BuildHTMLTable(List<ClassCustomerOrder> order)
        {
            var html = "<h1>All Orders</h1>";
            html += "<table id='TblOrders'><tr><th>Order Number</th><th>Customer Name</th><th>Order Date</th><th>Order Total</th></tr>";
            if (order == null)
            {
                html = "<tr><td>There are no orders stored in the application yet.</td></tr>";
            }
            else
            {
                for (int i = 0; i < order.Count; i++)
                {
                    html += "<tr";
                    if (i % 2 == 1)
                        html += " class='colors' ";
                    html += ">";
                    html += "<td>";
                    html += order[i].Orders.ID;
                    html += "</td>";
                    html += "<td>";
                    html += order[i].Customers.FirstName + " " + order[i].Customers.LastName;
                    html += "</td>";
                    html += "<td>";
                    html += order[i].Orders.Date;
                    html += "</td>";
                    html += "<td>$";
                    html += order[i].Orders.Total;
                    html += "</td>";
                    html += "</tr>";
                }
            }
            html += "</table>";
            DivTableResults.InnerHtml = html;
        }

        private void BuildOrderDropDown(List<ClassCustomerOrder> order)
        {
            for (int i = 0; i < order.Count; i++)
            {
                DDBOrderID.Items.Add(new ListItem(order[i].Customers.ID + ": " + order[i].Orders.Date.ToString() + ", " + order[i].Customers.FirstName + " " +order[i].Customers.LastName, order[i].Orders.ID.ToString())); //the second ID is the value that it is passed down.
            }
        }

        protected void DDBOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDBOrderID.SelectedIndex != 0)
            {
                Response.Redirect("ViewSingleOrder.aspx?Order.Id=" + DDBOrderID.SelectedValue);
            }
        }

    }
}