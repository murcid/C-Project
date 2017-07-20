<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOrder.aspx.cs" Inherits="Final.AddOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>I Sock</title>
    <link href="styles/styles.css" rel="stylesheet" />
    <link href="LIB/jquery-ui/jquery-ui.css" rel="stylesheet" />
</head>
<body>
        <br />
    <form id="form1" runat="server">
    <h1 class="main">I SOCK</h1>
    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="menu" BackColor="#FF99CC" BorderColor="#FFCCFF" BorderStyle="Solid" BorderWidth="2px" RenderingMode="Table">
    <Items>
        <asp:MenuItem Text="New Customer" NavigateUrl="AddCustomer.aspx" />
        <asp:MenuItem Text="New Order" NavigateUrl="AddOrder.aspx" />
        <asp:MenuItem Text="View Orders" NavigateUrl="ViewOrders.aspx" />
    </Items>
    </asp:Menu>
    <div id="AddOrder">
    <h1>Place Order</h1>

        <asp:Label ID="LblDDBCustomerID" runat="server" Text="Select Customer"></asp:Label>
        	&#160;&#160;
        <asp:DropDownList ID="DDBCustomerID" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDBCustomerID_SelectedIndexChanged">
            <asp:ListItem Value="">Please select a customer..  </asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="LblErrorDDBCustomerID" CssClass="error" runat="server" Text=""></asp:Label> 
        <br /><br />
       <asp:Label ID="LblTBDate" runat="server" Text="Order Date"></asp:Label>
        &#160;&#160;
        <asp:TextBox ID="TBDate" runat="server"></asp:TextBox>
        &#160;&#160;
        <asp:Label ID="LblErrorDate" CssClass="error" runat="server" Text=""></asp:Label> 
        <br /><br /><br />
        <asp:Label ID="LblProducts" runat="server" Text="Current Products" CssClass="Product"></asp:Label> 
        <p><img src="Images/image1.jpg" class="image" />&#160;&#160;<asp:Label ID="LblImage1" runat="server" Text="Cool Ranch Doritos Socks $10.00"></asp:Label>&#160;&#160;<asp:Button ID="BtnSub1" runat="server" Text="-" Height="40px" OnClick="BtnSub1_Click" Width="40px" /><asp:TextBox ID="TBImage1" runat="server"  CssClass="quantity" ReadOnly="True" Width="50px"></asp:TextBox><asp:Button ID="BtnAdd1" runat="server" Text="+" OnClick="BtnAdd1_Click" Height="40px" Width="40px" /></p>
        <p><img src="Images/image2.jpg" class="image" />&#160;&#160;<asp:Label ID="LblImage2" runat="server" Text="Extra Flaming Hot Crunchy Cheetos Socks $12.00"></asp:Label>&#160;&#160;<asp:Button ID="BtnSub2" runat="server" Text="-" Height="40px" OnClick="BtnSub2_Click" Width="40px" /><asp:TextBox ID="TBImage2" runat="server"  CssClass="quantity" ReadOnly="True" Width="50px"></asp:TextBox><asp:Button ID="BtnAdd2" runat="server" Text="+" OnClick="BtnAdd2_Click" Height="40px" Width="40px" /></p>
        <p><img src="Images/image3.jpg" class="image" />&#160;&#160;<asp:Label ID="LblImage3" runat="server" Text="Red Ice & Blue Ice Socks $8.00"></asp:Label>&#160;&#160;<asp:Button ID="BtnSub3" runat="server" Text="-" Height="40px" OnClick="BtnSub3_Click" Width="40px" /><asp:TextBox ID="TBImage3" runat="server"  CssClass="quantity" ReadOnly="True" Width="50px"></asp:TextBox><asp:Button ID="BtnAdd3" runat="server" Text="+" OnClick="BtnAdd3_Click" Height="40px" Width="40px" /></p>
        <br /><br />
        <p><asp:Label ID="LblSubtotal" runat="server" Text="Subtotal"></asp:Label>&#160;&#160;<asp:TextBox ID="TBSubtotal" runat="server" ReadOnly="True"></asp:TextBox></p>
        <p><asp:Label ID="LblTax" runat="server" Text="Tax"></asp:Label>&#160;&#160;<asp:TextBox ID="TBTax" runat="server" ReadOnly="True" ></asp:TextBox></p>
        <p><asp:Label ID="LblTotal" runat="server" Text="Total"></asp:Label>&#160;&#160;<asp:TextBox ID="TBTotal" runat="server" ReadOnly="True" ></asp:TextBox></p>
        <br />
        <asp:Label ID="LblMessage" CssClass="error" runat="server" Text="Please fill in all of the required fields" Visible="false"></asp:Label> 
        <br />
        <asp:Label ID="LblErrorQuantity" CssClass="error" runat="server" Text=""></asp:Label> 
        <p><asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" CssClass="Button"/>&#160;&#160;<asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" CssClass="Button" /></p>
    </div>
    </form>
    <script src="LIB/jquery-ui/external/jquery/jquery.js"></script>
    <script src="LIB/jquery-ui/jquery-ui.js"></script>
    <script src="scripts/scripts.js"></script>
</body>
</html>
