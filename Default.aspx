<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar of Events</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <h1>Calendar of Events</h1>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="look for events" /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
    </form>
</body>
</html>
