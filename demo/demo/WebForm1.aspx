<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="Nametextbox" runat="server" Text = " Please enter the name "></asp:TextBox><br/><br/><br/>
            <asp:Label ID="Id" runat="server" Text=" Id"></asp:Label>
            <asp:TextBox ID="IDTextBox" runat="server" Text =" Please enter the id  "></asp:TextBox><br/><br/><br/>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" /><br/>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView><br/>
            <asp:Button ID="ViewEmployees" runat="server"OnClick="ViewEmployeesProc" Text="View  Employees" />
        </div>
    </form>
</body>
</html>
