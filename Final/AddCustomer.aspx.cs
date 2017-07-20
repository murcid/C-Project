using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        static List<ClassCustomer> customer = new List<ClassCustomer>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected Boolean ValidateFields()
        {
            Boolean isValid = true;
            ClearMessages();

            if (String.IsNullOrEmpty(TBFirstName.Text))
            {
                LblErrorFirstName.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (String.IsNullOrEmpty(TBLastName.Text))
            {
                LblErrorLastName.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (String.IsNullOrEmpty(TBAddress.Text))
            {
                LblErrorAddress.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (String.IsNullOrEmpty(TBCity.Text))
            {
                LblErrorCity.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (DDLState.SelectedIndex == 0)
            {
                LblErrorState.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (String.IsNullOrEmpty(TBZipCode.Text))
            {
                LblErrorZipCode.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            if (String.IsNullOrEmpty(TBPhone.Text))
            {
                LblErrorPhone.Text = "*";
                LblMessage.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            ClearMessages();
            ClearTB();
        }

        protected void ClearMessages()
        {
            LblErrorFirstName.Text = "";
            LblErrorLastName.Text = "";
            LblErrorAddress.Text = "";
            LblErrorCity.Text = "";
            LblErrorState.Text = "";
            LblErrorZipCode.Text = "";
            LblErrorPhone.Text = "";
            LblMessage.Visible = false;
        }

        protected void ClearTB()
        {
            TBFirstName.Text = "";
            TBLastName.Text = "";
            TBAddress.Text = "";
            TBCity.Text = "";
            DDLState.SelectedIndex = 0;
            TBZipCode.Text = "";
            TBPhone.Text = "";
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                DataUtilityClass.AddEntry(new ClassCustomer(TBFirstName.Text, TBLastName.Text, TBAddress.Text, TBCity.Text, DDLState.SelectedValue, TBZipCode.Text, TBPhone.Text));
                Response.Redirect("AddOrder.aspx");
            }
        }
    }
}