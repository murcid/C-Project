using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class AddOrder : System.Web.UI.Page
    {
        static List<ClassOrder> order = new List<ClassOrder>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                List<ClassCustomer> customer = DataUtilityClass.GetEntries();
                BuildCustomerDropDown(customer);

                TBImage1.Text = "0";
                TBImage2.Text = "0";
                TBImage3.Text = "0";
            }
        }

        protected void DDBCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuildCustomerDropDown(List<ClassCustomer> customer)
        {
            for (int i = 0; i < customer.Count; i++)
            {
                DDBCustomerID.Items.Add(new ListItem(customer[i].ID + ": " + customer[i].FirstName.ToString() + " " + customer[i].LastName.ToString(), customer[i].ID.ToString())); //the second ID is the value that it is passed down.
            }
        }

        protected Boolean ValidateFields()
        {
            Boolean isValid = true;
            ClearMessages();

            if (String.IsNullOrEmpty(DDBCustomerID.Text))
            {
                LblErrorDDBCustomerID.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (String.IsNullOrEmpty(TBDate.Text))
            {
                LblErrorDate.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (String.IsNullOrEmpty(TBSubtotal.Text))
            {
                LblErrorQuantity.Text = "* Please add at least one item";
                LblMessage.Visible = true;
                isValid = false;
            }

            if ((TBSubtotal.Text == "0"))
            {
                LblErrorQuantity.Text = "* Please add at least one item";
                LblMessage.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        protected void ClearMessages()
        {
            LblErrorDDBCustomerID.Text = "";
            LblErrorDate.Text = "";
            LblErrorQuantity.Text = "";
            LblMessage.Visible = false;
        }

        protected void ClearTB()
        {
            DDBCustomerID.SelectedIndex = 0;
            TBDate.Text = "";
            TBImage1.Text = "0";
            TBImage2.Text = "0";
            TBImage3.Text = "0";
            TBSubtotal.Text = "";
            TBTax.Text = "";
            TBTotal.Text = "";
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            ClearMessages();
            ClearTB();
        }

        protected void Calculate(int tb1, int tb2, int tb3)
        {
            tb1 *= 10;
            tb2 *= 12;
            tb3 *= 8;
            TBSubtotal.Text = (Convert.ToDecimal(tb1 + tb2 + tb3)).ToString();
            TBTax.Text = (Convert.ToDecimal(TBSubtotal.Text) * .08m).ToString();
            TBTotal.Text = (Convert.ToDecimal(TBSubtotal.Text) + Convert.ToDecimal(TBTax.Text)).ToString();
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                DataUtilityClass.AddEntryOrder(new ClassOrder(Convert.ToInt16(DDBCustomerID.SelectedValue), TBDate.Text, Convert.ToInt16(TBImage1.Text), Convert.ToInt16(TBImage2.Text), Convert.ToInt16(TBImage3.Text), Convert.ToDecimal(TBSubtotal.Text), Convert.ToDecimal(TBTax.Text), Convert.ToDecimal(TBTotal.Text)));
                Response.Redirect("ViewOrders.aspx");
            }
        }


        protected void BtnAdd1_Click(object sender, EventArgs e)
        {
            int tb1, tb2, tb3;
            tb1 = Convert.ToInt16(TBImage1.Text);
            tb2 = Convert.ToInt16(TBImage2.Text);
            tb3 = Convert.ToInt16(TBImage3.Text);
            tb1 += 1;
            TBImage1.Text = Convert.ToString(tb1);
            Calculate(tb1, tb2, tb3);
        }

        protected void BtnAdd2_Click(object sender, EventArgs e)
        {
            int tb1, tb2, tb3;
            tb1 = Convert.ToInt16(TBImage1.Text);
            tb2 = Convert.ToInt16(TBImage2.Text);
            tb3 = Convert.ToInt16(TBImage3.Text);
            tb2 += 1;
            TBImage2.Text = Convert.ToString(tb2);
            Calculate(tb1, tb2, tb3);
        }

        protected void BtnAdd3_Click(object sender, EventArgs e)
        {
        int tb1, tb2, tb3;
        tb1 = Convert.ToInt16(TBImage1.Text);
        tb2 = Convert.ToInt16(TBImage2.Text);
        tb3 = Convert.ToInt16(TBImage3.Text);
        tb3 += 1;
        TBImage3.Text = Convert.ToString(tb3);
        Calculate(tb1, tb2, tb3);
        }

        protected void BtnSub1_Click(object sender, EventArgs e)
        {
            int tb1, tb2, tb3;
            tb1 = Convert.ToInt16(TBImage1.Text);
            tb2 = Convert.ToInt16(TBImage2.Text);
            tb3 = Convert.ToInt16(TBImage3.Text);
            if (!(TBImage1.Text == "0"))
            {
                tb1 -= 1;
                TBImage1.Text = Convert.ToString(tb1);
                Calculate(tb1, tb2, tb3);
            }
        }

        protected void BtnSub2_Click(object sender, EventArgs e)
        {
                int tb1, tb2, tb3;
                tb1 = Convert.ToInt16(TBImage1.Text);
                tb2 = Convert.ToInt16(TBImage2.Text);
                tb3 = Convert.ToInt16(TBImage3.Text);
            if (!(TBImage2.Text == "0"))
            {
                tb2 -= 1;
                TBImage2.Text = Convert.ToString(tb2);
                Calculate(tb1, tb2, tb3);
            }

        }

        protected void BtnSub3_Click(object sender, EventArgs e)
        {
                int tb1, tb2, tb3;
                tb1 = Convert.ToInt16(TBImage1.Text);
                tb2 = Convert.ToInt16(TBImage2.Text);
                tb3 = Convert.ToInt16(TBImage3.Text);
            if (!(TBImage3.Text == "0"))
            {
                tb3 -= 1;
                TBImage3.Text = Convert.ToString(tb3);
                Calculate(tb1, tb2, tb3);
            }
        }
    }
}