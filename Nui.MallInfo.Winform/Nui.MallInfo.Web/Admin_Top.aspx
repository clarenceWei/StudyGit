<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Top.aspx.cs" Inherits="Nui.MallInfo.Web.Admin_Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>后台管理</title>
</head>
<base target="_top"/>
<link href="images/skin.css" rel="stylesheet" type="text/css"/>
<body >
    <form id="form1" runat="server"  >
<table width="100%" height="64" border="0" cellpadding="0" cellspacing="0" class="admin_topbg">
  <tr>
    <td width="61%" height="64"><img src="images/logo.gif" width="262" height="64"></td>
    <td width="39%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="74%" height="38" class="admin_txt">管理员：<asp:Label ID="Label1" 
                runat="server" Text="Label"></asp:Label>
&nbsp;您好,感谢登陆使用！</td>
        <td width="22%"><a href="#" target="_self">
            <asp:ImageButton ID="ImageButton1" ImageUrl="images/out.gif" runat="server"    
                width="46" height="20" onclick="ImageButton1_Click"     /></a></td>
        <td width="4%">&nbsp;</td>
      </tr>
      <tr>
        <td height="19" colspan="3">&nbsp;</td>
        </tr>
    </table></td>
  </tr>
</table>
    </form>
</body>
</html>
