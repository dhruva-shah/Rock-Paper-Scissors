<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Player:<br />
        <br />
        Choose :&nbsp;
        <asp:RadioButton ID="rb_rock" runat="server" Text="Rock" checked="true" Groupname="user"/>
&nbsp;<asp:RadioButton ID="rb_paper" runat="server" Text="Paper"  Groupname="user"/>
&nbsp;<asp:RadioButton ID="rb_scissor" runat="server" Text="Scissor" Groupname="user" />
        <br />
        <br />
        <br />
        Computer :&nbsp;&nbsp; 
        <asp:Label ID="PC_Rock" runat="server" BorderColor="Black" BorderStyle="Outset" BorderWidth="1px" Text="Rock"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="PC_Paper" runat="server" BorderColor="Black" BorderStyle="Outset" BorderWidth="1px" Text="Paper"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="PC_Scissor" runat="server" BorderColor="Black" BorderStyle="Outset" BorderWidth="1px" Text="Scissor"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label_result" runat="server" Text="Label" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_play" runat="server" Text="Play" OnClick="Button_play_Click" />
    
    &nbsp;<asp:Button ID="Button_replay" runat="server" OnClick="Button_replay_Click" Text="Replay" Visible="False" />
    
    </div>
    </form>
</body>
</html>
