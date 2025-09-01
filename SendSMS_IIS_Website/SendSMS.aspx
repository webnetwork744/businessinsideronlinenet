<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendSMS.aspx.cs" Inherits="SendSMS" %>
<!DOCTYPE html>
<html>
<head>
    <title>Free SMS Sender</title>
</head>
<body>
    <h2>Send Free SMS via Your Gateway</h2>
    <form id="form1" runat="server">
        <label>Phone Number:</label>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br/><br/>
        <label>Message:</label>
        <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="4" Columns="40"></asp:TextBox><br/><br/>
        <asp:Button ID="btnSend" runat="server" Text="Send SMS" OnClick="btnSend_Click" /><br/><br/>
        <asp:Label ID="lblResult" runat="server" ForeColor="Green"></asp:Label>
    </form>
</body>
</html>
