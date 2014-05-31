<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Raspundeti la urmatoarele intrebari iar noi va vom ajuta sa va gasiti destinatia perfecta de vacanta."></asp:Label>
    <br />
        <asp:Label ID="Label2" runat="server" Visible="False" Width="400px"></asp:Label>
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:RadioButton GroupName="RB" ID="RadioButton1" runat="server" Visible="False" Checked=false />
        <br />
        <asp:RadioButton GroupName="RB" ID="RadioButton2" runat="server" Visible="False" Checked=false/>
        <br />
        <asp:RadioButton GroupName="RB" ID="RadioButton3" runat="server" Visible="False" Checked=false/>
        <br />
        <asp:RadioButton GroupName="RB" ID="RadioButton4" runat="server" Visible="False" Checked=false/>
        <br />
        <br />
        <asp:Button ID="ButtonIntrebareaUrmatoare" runat="server" OnClick="ButtonIntrebareaUrmatoare_Click" Text="Intrebarea urmatoare" Visible="False" />
        <asp:Button ID="ButtonTerminaTest" runat="server" Text="Finalizare test" Visible="False" OnClick="ButtonTerminaTest_Click" />
    </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
</asp:Content>
