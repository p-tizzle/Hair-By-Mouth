<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebUserForm.aspx.cs" Inherits="hairByMouth2.WebUserForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Welcome to Hair By Mouth</p>
        <p>
            Enter your first name:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter your last name:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p class="col-sm-4">
            Enter your salon name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Stylist name:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Share Info" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

    
   



</body>
</html>
