<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebApp1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 453px">
    <form id="form1" runat="server">
        <h1>Welcome</h1>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
    <div>
    
    </div>
        Enter You Name<br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="371px"></asp:TextBox>
        <br />
        <br />
        Your Fav Movie<br />
        <asp:DropDownList ID="DDFavList1" runat="server" OnSelectedIndexChanged="DDFavList1_SelectedIndexChanged">
            <asp:ListItem Selected="True">Select Your Fav Movie</asp:ListItem>
            <asp:ListItem>Shole</asp:ListItem>
            <asp:ListItem>Agnipath</asp:ListItem>
            <asp:ListItem>Lax</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:RadioButton ID="RButtonOk" runat="server" Checked="True" GroupName="RButtonGroup" Text="LoveToWatchAgain" />
        <asp:RadioButton ID="RButtonNot" runat="server" GroupName="RButtonGroup" Text="Dont Want to Watch" />
        <br />
        <br />
        <asp:ListBox ID="LBSongs" runat="server" Height="178px" SelectionMode="Multiple" Width="291px">
            <asp:ListItem>Take My Breath Away</asp:ListItem>
            <asp:ListItem>I Got You</asp:ListItem>
            <asp:ListItem>RolerCoster</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" Width="155px" />
        <br />
        <br />
        <asp:Label ID="Display" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="TestError" />
        <br />
    </form>
</body>
</html>
