<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EfCodeFastAndMvpAsp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Phone Numbet"></asp:Label>
        <asp:TextBox ID="PhoneNumbetTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Is Alive"></asp:Label>
        <asp:CheckBox ID="IsAliveCheckBox" runat="server" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Dpt"></asp:Label>
        <asp:Calendar ID="DptCalendar" runat="server"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="PhoneNumbet" HeaderText="PhoneNumber" />
                <asp:BoundField DataField="DateofBirth" HeaderText="DateofBirth" SortExpression="DateofBirth" />
                <asp:CheckBoxField DataField="IsAlive" Text="IsAlive" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
