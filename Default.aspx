<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body runat="server" id="BodyTag">
    <center>
    <form id="form1" runat="server">
    <div>
    Enter value:  
        <asp:TextBox ID="TextBox1" runat="server" style="width: 200px; height:23px;"></asp:TextBox>
        <br /> <br />
        <asp:Button ID="Button1" runat="server" Text="Create Cookie" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Get Cookie" OnClick="Button2_Click"  />
        <br /> <br />
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Green" Font-Bold="true"></asp:Label>
    </div>
    </form>
    </center>
</body>
</html>
