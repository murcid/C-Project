<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrders.aspx.cs" Inherits="Final.ViewOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>I Sock</title>
    <link href="styles/styles.css" rel="stylesheet" />
    <link href="LIB/jquery-ui/jquery-ui.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <h1 class="main">I SOCK</h1>
    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="menu" BackColor="#FF99CC" BorderColor="#FFCCFF" BorderStyle="Solid" BorderWidth="2px" RenderingMode="Table">
    <Items>
        <asp:MenuItem Text="New Customer" NavigateUrl="AddCustomer.aspx" />
        <asp:MenuItem Text="New Order" NavigateUrl="AddOrder.aspx" />
        <asp:MenuItem Text="View Orders" NavigateUrl="ViewOrders.aspx" />
    </Items>
    </asp:Menu>
    <div>
        <br />
        <div id="DivTableResults" runat="server" class="orderTable"></div>
        <br />

        <asp:Label ID="LblDDBOrderID" runat="server" Text="Select an order to view:"></asp:Label>
        &#160;&#160;
        <asp:DropDownList ID="DDBOrderID" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DDBOrderID_SelectedIndexChanged" >
        <asp:ListItem Value="">Please select an order..  </asp:ListItem>
        </asp:DropDownList>
     </div>
    </form>
    <script src="LIB/jquery-ui/external/jquery/jquery.js"></script>
    <script src="LIB/jquery-ui/jquery-ui.js"></script>
    <script src="scripts/scripts.js"></script>

</body>
</html>
