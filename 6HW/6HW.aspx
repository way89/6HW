<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="6HW.aspx.cs" Inherits="_6HW._6HW" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tb_Name" runat="server" Visible="False"></asp:TextBox>
            <asp:Button ID="btn_Del" runat="server" Text="刪除"  Visible="False" OnClick="btn_Del_Click"/><br />
            <asp:Label ID="lb_Msg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>