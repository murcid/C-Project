<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSingleOrder.aspx.cs" Inherits="Final.ViewSingleOrder" %>

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
        <div id="DivTableResults" runat="server"></div>
        <br />

    </div>
    </form>
    <script src="LIB/jquery-ui/external/jquery/jquery.js"></script>
    <script src="LIB/jquery-ui/jquery-ui.js"></script>
    <script src="scripts/scripts.js"></script>

</body>
</html>
