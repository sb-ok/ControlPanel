<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MainSite.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Пришло с Arduino: "></asp:Label>
    
        <asp:Label ID="titleLbl" runat="server"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="ID датчика темературы: "></asp:Label>
        <asp:Label ID="sensorId" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Текущая температура: "></asp:Label>
        <asp:Label ID="currentTemp" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <p>
        <asp:Button ID="Button1" runat="server" style="margin-bottom: 0px" Text="Refresh" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
