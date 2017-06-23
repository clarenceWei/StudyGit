<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Nui.MallInfo.Web.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head id="Head1" runat="server">
<title>管理中心</title>
<meta http-equiv="Content-Type" content="text/html;charset=gb2312s">
    <link href="skins/default.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="js/jquery.artDialog.js" type="text/javascript"></script>
    <script src="js/iframeTools.js" type="text/javascript"></script>
</head>
<frameset rows="64,*"  frameborder="NO" border="0" framespacing="0">
	<frame src="Admin_Top.aspx" noresize="noresize" frameborder="NO" name="topFrame"  scrolling="no" marginwidth="0" marginheight="0"  target="_top" />
  <frameset cols="200,*"  rows="800,*" id="frame">
	<frame src="Left.aspx" name="leftFrame" noresize="noresize" marginwidth="0" marginheight="0" frameborder="0" scrolling="no" target="main" />
	<frame src="Right.aspx" name="main" marginwidth="0" marginheight="0" frameborder="0" scrolling="auto" target="_self" />
  </frameset>
<noframes>
  <body></body>
    </noframes>
</html>
