<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebUserForm.aspx.cs" Inherits="hairByMouth2.WebUserForm" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Hair By Mouth</title>


     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    

  
</head>
<body style="background-color:slategrey">
    
    <form id="form1" runat="server">
        <p>
            Welcome to Hair By Mouth</p>
        <p>Start by filling out empty fieldss</p>
        <p>
            Enter first name:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter last name:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Search" />
             &nbsp;or complete the following fields to share...</p>
        <p>
            &nbsp;</p>
        <p class="col-sm-4">
            Enter salon name:
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
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

   
   
    
       
</body>
</html>
