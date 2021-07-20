<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormBroadsheets.aspx.vb" Inherits="RTPSWeb.FormBroadsheets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/images/unibenlogo.png" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="MatNo"></asp:Label>


            <br />
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="136px" style="margin-right: 0px" Width="330px">
                <asp:Panel ID="Panel2" runat="server" Height="133px" Width="108px">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </asp:Panel>
            </asp:Panel>


        </div>
    </form>
</body>
</html>
