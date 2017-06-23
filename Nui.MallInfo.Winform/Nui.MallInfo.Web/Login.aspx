<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Nui.MallInfo.Web.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>后台管理</title>
<style type="text/css">
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #1D3647;
}
        .style1
        {
            height: 35px;
        } 
    </style>

    <link href="images/skin.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        //        function createQueryString() {//获取传递参数字符串
        //            var Name = encodeURI($("#txt_username").val());
        //            var pwd = encodeURI($("#txt_passwd").val());
        //            var code = encodeURI($("#txt_validay").val())
        //            var queryString = { name: Name, pwd: pwd, code: code };
        //            return queryString;
        //        }
        //        $("#loginform").submit(function () {
        //            debugger;
        //            $.ajax({
        //                type: "POST",
        //                url: "ASHX/Login.ashx",
        //                data: createQueryString(),
        //                success: function (state) { 
        //                    alert(state);
        //                }
        //            });
        //        });        
    </script>
    </head>
<body>
<table width="100%" height="166" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td height="42" valign="top"><table width="100%" height="42" border="0" cellpadding="0" cellspacing="0" class="login_top_bg">
      <tr>
        <td width="1%" height="21">&nbsp;</td>
        <td height="42">&nbsp;</td>
        <td width="17%">&nbsp;</td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td valign="top"><table width="100%" height="532" border="0" cellpadding="0" cellspacing="0" class="login_bg">
      <tr>
        <td width="49%" align="right"><table width="91%" height="532" border="0" cellpadding="0" cellspacing="0" class="login_bg2">
            <tr>
              <td height="138" valign="top"><table width="89%" height="427" border="0" cellpadding="0" cellspacing="0">
                <tr>
                  <td height="149">&nbsp;</td>
                </tr>
                <tr>
                  <td height="80" align="right" valign="top"><img src="images/logo.png" width="279" height="68"></td>
                </tr>
                <tr>
                  <td height="198" align="right" valign="top">
                  <table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                      <td width="35%">&nbsp;</td>
                      <td height="25" colspan="2" class="left_txt" style=" text-align:right;"><p>1- 地区商家信息网门户站建立的首选方案...</p></td>
                    </tr>
                    <tr>
                      <td width="35%">&nbsp;</td>
                      <td height="25" colspan="2" class="left_txt" style=" text-align:right;"><p>2- 一站通式的整合方式，方便用户使用...</p></td>
                    </tr>
                    <tr>
                      <td width="35%">&nbsp;</td>
                      <td height="25" colspan="2" class="left_txt" style=" text-align:right;"><p>3- 强大的后台系统，管理内容易如反掌...</p></td>
                    </tr>
                   <%-- <tr>
                      <td width="35%">&nbsp;</td>
                      <td width="30%" height="40"><img src="images/icon-demo.gif" width="16" height="16"><a href="#" target="_blank" class="left_txt3"> 使用说明</a> </td>
                      <td width="35%"><img src="images/icon-login-seaver.gif" width="16" height="16"><a href="#" class="left_txt3"> 在线客服</a></td>
                    </tr>--%>
                    </table>
                  </td>
                </tr>
              </table></td>
            </tr>
            
        </table></td>
        <td width="1%" >&nbsp;</td>
        <td width="50%" valign="bottom">
        <table width="100%" height="59" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="4%">&nbsp;</td>
              <td width="96%" height="38"><span class="login_txt_bt">登陆网站后台管理</span></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td height="21"><table cellpadding="0" cellspacing="0" width="100%" border="0" id="table211" height="300">
                  <tr>
                    <td height="164" colspan="2" align="center">
                    <form id="loginform" runat="server">
                        <table cellSpacing="0" cellPadding="0" width="100%" border="0" height="143" id="table212">
                          <tr >
                            <td width="13%" height="38" align="center" ><span class="login_txt">管理员：&nbsp; </span></td>
                            <td height="38" colspan="2"  align="left">
                                <asp:TextBox ID="txt_username" runat="server" Width="180px"></asp:TextBox>
&nbsp;</td>
                          </tr>
                          <tr>
                            <td width="13%" height="35" align="center"><span class="login_txt"> 密 码： &nbsp;&nbsp; </span></td>
                            <td height="35" colspan="2" align="left">
                                <asp:TextBox ID="txt_passwd" runat="server" Width="160px" TextMode="Password" ></asp:TextBox>
&nbsp;<img src="images/luck.gif" width="19" height="18"> </td>
                          </tr>
                          <tr>
                            <td width="13%" height="35" align="center" ><span class="login_txt">验证码：</span></td>
                            <td height="35" colspan="2" align="left">
                                <asp:TextBox ID="txt_validay" runat="server" Width="100px" style=" vertical-align:middle;" ></asp:TextBox>
&nbsp;<asp:ImageButton ID="yzm" style=" vertical-align:middle; padding-right:5px;" runat="server" ImageUrl="~/Admin/Images.aspx" /><asp:LinkButton ID="ChangeCode" style=" vertical-align:middle;" runat="server" Text="看不清楚？换一个验证码" OnClick="ChangeCode_Click" /> </td>
                          </tr>
                          <tr>
                            <td class="style1" ></td>
                            <td width="20%" class="style1" align="center">
                                <asp:Button ID="btn_login" runat="server" Text="登  录" 
                                    onclick="btn_login_Click" />
                                    <input id="state" type="hidden" />
&nbsp;</td>
                            <td width="67%" class="style1" align="left"  style="padding-left:20px">
                                <asp:Button ID="btn_cancle" runat="server" Text="取  消" 
                                    onclick="btn_cancle_Click" /></td>
                          </tr>
                        </table></form>
                        <br>
                    </td>
                  </tr>
                  <tr>
                    <td width="433" height="164" align="right" valign="bottom"><img src="images/login-wel.gif" width="242" height="138"></td>
                    <td width="57" align="right" valign="bottom">&nbsp;</td>
                  </tr>
              </table></td>
            </tr>
          </table>
          </td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="20"><table width="100%" border="0" cellspacing="0" cellpadding="0" class="login-buttom-bg">
      <tr>
        <td align="center"><span class="login-buttom-txt">Copyright &copy; 2009-2010 www.865171.cn</span></td>
      </tr>
    </table></td>
  </tr>
</table>
</body>
</html>