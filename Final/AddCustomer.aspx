<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="Final.AddCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>I Sock</title>
    <link href="LIB/jquery-ui/jquery-ui.css" rel="stylesheet" />
    <link href="styles/styles.css" rel="stylesheet" />
</head>
<body id="Background" runat="server">
    <br />
    <form id="FrmOrderingSystem" runat="server">
    <h1 class="main">I SOCK</h1>
    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="menu" BackColor="#FF99CC" BorderColor="#FFCCFF" BorderStyle="Solid" BorderWidth="2px" RenderingMode="Table">
    <Items>
        <asp:MenuItem Text="New Customer" NavigateUrl="AddCustomer.aspx"/>
        <asp:MenuItem Text="New Order" NavigateUrl="AddOrder.aspx" />
        <asp:MenuItem Text="View Orders" NavigateUrl="ViewOrders.aspx" />
    </Items>
    </asp:Menu>
    <div id="AddCustomer">
    <h1>Customer Information</h1>
    <asp:Label ID="LblFirst" runat="server" Text="First Name: "></asp:Label>
    <asp:TextBox ID="TBFirstName" runat="server"></asp:TextBox>
    <asp:Label ID="LblErrorFirstName" CssClass="error" runat="server" Text=""></asp:Label> 
    <br /><br />
    <asp:Label ID="LblLastName" runat="server" Text="Last Name: "></asp:Label>
    <asp:TextBox ID="TBLastName" runat="server"></asp:TextBox>
    <asp:Label ID="LblErrorLastName" CssClass="error" runat="server" Text=""></asp:Label> 
    <br /><br />
    <asp:Label ID="LblStreet" runat="server" Text="Address: "></asp:Label>
    <asp:TextBox ID="TBAddress" runat="server"></asp:TextBox>
    <asp:Label ID="LblErrorAddress" CssClass="error" runat="server" Text=""></asp:Label> 
    <br /><br />
    <asp:Label ID="LblCity" runat="server" Text="City: "></asp:Label>
    <asp:TextBox ID="TBCity" runat="server"></asp:TextBox>
    <asp:Label ID="LblErrorCity" CssClass="error" runat="server" Text=""></asp:Label> 
    <br /><br />
    <asp:Label ID="LblState" runat="server" Text="State: "></asp:Label>
    <asp:DropDownList ID="DDLState" runat="server">
    <asp:ListItem Value="">Please choose a state..</asp:ListItem>
	<asp:ListItem Value="AL">Alabama</asp:ListItem>
	<asp:ListItem Value="AK">Alaska</asp:ListItem>
	<asp:ListItem Value="AZ">Arizona</asp:ListItem>
	<asp:ListItem Value="AR">Arkansas</asp:ListItem>
	<asp:ListItem Value="CA">California</asp:ListItem>
	<asp:ListItem Value="CO">Colorado</asp:ListItem>
	<asp:ListItem Value="CT">Connecticut</asp:ListItem>
	<asp:ListItem Value="DC">District of Columbia</asp:ListItem>
	<asp:ListItem Value="DE">Delaware</asp:ListItem>
	<asp:ListItem Value="FL">Florida</asp:ListItem>
	<asp:ListItem Value="GA">Georgia</asp:ListItem>
	<asp:ListItem Value="HI">Hawaii</asp:ListItem>
	<asp:ListItem Value="ID">Idaho</asp:ListItem>
	<asp:ListItem Value="IL">Illinois</asp:ListItem>
	<asp:ListItem Value="IN">Indiana</asp:ListItem>
	<asp:ListItem Value="IA">Iowa</asp:ListItem>
	<asp:ListItem Value="KS">Kansas</asp:ListItem>
	<asp:ListItem Value="KY">Kentucky</asp:ListItem>
	<asp:ListItem Value="LA">Louisiana</asp:ListItem>
	<asp:ListItem Value="ME">Maine</asp:ListItem>
	<asp:ListItem Value="MD">Maryland</asp:ListItem>
	<asp:ListItem Value="MA">Massachusetts</asp:ListItem>
	<asp:ListItem Value="MI">Michigan</asp:ListItem>
	<asp:ListItem Value="MN">Minnesota</asp:ListItem>
	<asp:ListItem Value="MS">Mississippi</asp:ListItem>
	<asp:ListItem Value="MO">Missouri</asp:ListItem>
	<asp:ListItem Value="MT">Montana</asp:ListItem>
	<asp:ListItem Value="NE">Nebraska</asp:ListItem>
	<asp:ListItem Value="NV">Nevada</asp:ListItem>
	<asp:ListItem Value="NH">New Hampshire</asp:ListItem>
	<asp:ListItem Value="NJ">New Jersey</asp:ListItem>
	<asp:ListItem Value="NM">New Mexico</asp:ListItem>
	<asp:ListItem Value="NY">New York</asp:ListItem>
	<asp:ListItem Value="NC">North Carolina</asp:ListItem>
	<asp:ListItem Value="ND">North Dakota</asp:ListItem>
	<asp:ListItem Value="OH">Ohio</asp:ListItem>
	<asp:ListItem Value="OK">Oklahoma</asp:ListItem>
	<asp:ListItem Value="OR">Oregon</asp:ListItem>
	<asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
	<asp:ListItem Value="RI">Rhode Island</asp:ListItem>
	<asp:ListItem Value="SC">South Carolina</asp:ListItem>
	<asp:ListItem Value="SD">South Dakota</asp:ListItem>
	<asp:ListItem Value="TN">Tennessee</asp:ListItem>
	<asp:ListItem Value="TX">Texas</asp:ListItem>
	<asp:ListItem Value="UT">Utah</asp:ListItem>
	<asp:ListItem Value="VT">Vermont</asp:ListItem>
	<asp:ListItem Value="VA">Virginia</asp:ListItem>
	<asp:ListItem Value="WA">Washington</asp:ListItem>
	<asp:ListItem Value="WV">West Virginia</asp:ListItem>
	<asp:ListItem Value="WI">Wisconsin</asp:ListItem>
	<asp:ListItem Value="WY">Wyoming</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="LblErrorState" CssClass="error" runat="server" Text=""></asp:Label> 
    <br /><br />
    <asp:Label ID="LblZipCode" runat="server" Text="Zip Code: "></asp:Label>
    <asp:TextBox ID="TBZipCode" runat="server" TextMode="Number" placeholder="5 Digit Zip" MaxLength="5"></asp:TextBox>
    <asp:Label ID="LblErrorZipCode" CssClass="error" runat="server" Text=""></asp:Label> 
    <br /><br />
    <asp:Label ID="LblPhone" runat="server" Text="Phone Number: "></asp:Label>
    <asp:TextBox ID="TBPhone" runat="server" TextMode="Number" MaxLength="11" placeholder="Numbers Only"></asp:TextBox>
    <asp:Label ID="LblErrorPhone" CssClass="error" runat="server" Text=""></asp:Label> 
    <br /><br />
    <asp:Label ID="LblMessage" CssClass="error" runat="server" Text="Please fill in all of the required fields *" Visible="false"></asp:Label> 
    <br /><br />
    <asp:Button ID="BtnSubmit" runat="server" Text="Add Customer" OnClick="BtnSubmit_Click" />
    <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" />
    </div>
    </form>
    <script src="LIB/jquery-ui/external/jquery/jquery.js"></script>
    <script src="LIB/jquery-ui/jquery-ui.js"></script>
    <script src="scripts/scripts.js"></script>
</body>
</html>
