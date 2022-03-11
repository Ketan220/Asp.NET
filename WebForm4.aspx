<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            font-family: Consolas;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Page Reload to get current time and date<br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <hr />
    <p>
        &nbsp;</p>
    <p class="MsoNormal">
        <span style="font-size:9.5pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black;mso-ansi-language:EN-US">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style2" style="font-family: Consolas; mso-bidi-font-family: Consolas; color: black; mso-ansi-language: EN-US">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style2" lang="EN-US" style="font-family: Consolas; mso-bidi-font-family: Consolas; color: black; mso-ansi-language: EN-US">view state <o:p></o:p></span>
    </p>
    <p class="MsoNormal">
        <span class="auto-style2" lang="EN-US" style="font-family: Consolas; mso-bidi-font-family: Consolas; color: black; mso-ansi-language: EN-US">it will save the value of textbox which is type by you and it will be retained by textbox when you click the button <o:p></o:p>
        </span>
    </p>
        <p class="auto-style3">
            <o:p>Enter username:-<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </o:p>
    </p>
        <p class="auto-style3">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <o:p></o:p>
    </p>
        <p class="MsoNormal">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
    </body>
</html>
