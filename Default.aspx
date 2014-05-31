<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 686px">
       
       <div id="MesajTitlu" runat="server"></div>
        Titlu:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="titlul" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <div id="MesajDescriere" runat="server"></div>
        Descriere:<br />
&nbsp;<asp:TextBox ID="descrierea" runat="server" Height="121px" Width="323px"></asp:TextBox>
        <br />
        <br />
        <div id="MesajFotografie" runat="server"></div>
        Fotografii:<br />
        <br />
        <asp:FileUpload ID="poza" runat="server" />
        <br />
        <br />
        <br />
        <br />
       
        <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
       
        <br />
        <br />
        <br />
        <br />
       
    </div>
    </form>
</body>
</html>
