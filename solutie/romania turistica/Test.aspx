<%@ Page Title="" Language="C#" MasterPageFile="~/romania turistica/MasterPage.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="romania_turistica_Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <font size="3" color="maroon">  Raspundeti la urmatoarele intrebari pentru a va ajuta sa va gasiti destinatia perfecta de vacanta<br />
    </font>
&nbsp;
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

