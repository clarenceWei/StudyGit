<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADDMemberNews.aspx.cs" Inherits="Nui.MallInfo.Web.ManageHTML.ADDMemberNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
       <title>政策法则</title>
        <style type="text/css">
            .style1
            {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 25px;
                color: #000000;
                height: 30px;
            }
            .style2
            {
                height: 30px;
            }
            #news_content
            {
                height: 88px;
                width: 200px;
            }
        </style>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.4.1.js" type="text/javascript"></script>
    <link href="../skins/default.css" rel="stylesheet" type="text/css" />
    <link href="/kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <link href="/kindeditor/themes/default/default.css" rel="stylesheet" type="text/css" />
    <script src="/kindeditor/kindeditor.js" type="text/javascript"></script>
    <script src="/kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script src="/kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
    <script src="../js/jquery.artDialog.js" type="text/javascript"></script>
    <script src="../js/iframeTools.js" type="text/javascript"></script>
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor1 = K.create('#newscontent', {
                cssPath: '/kindeditor/plugins/code/prettify.css',
                uploadJson: 'upload_json.ashx',
                fileManagerJson: 'file_manager_json.ashx',
                allowFileManager: true,
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=form1]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=form1]')[0].submit();
                    });
                }
            });
            prettyPrint();
        });
         
	</script>
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
      <%-- <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>--%>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif" colspan="2"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">会员动态</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
      <%-- <td height="71" valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>--%>
    <td valign="top" bgcolor="#F7F8F9" colspan="2"><table width="100%" height="138" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td height="13" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td valign="top"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td class="left_txt">当前位置：添加</td>
          </tr>
          <tr>
            <td height="20"><table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
              <tr>
                <td></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" height="55" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td width="10%" height="55" valign="middle"><img src="../images/title.gif" width="54" height="55"></td>
                <td width="90%" valign="top"><span class="left_txt2">
                    在这里，您可以根据您的网站要求，添加、修改申请会员、会员单位动态 </span></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2">&nbsp;&nbsp;&nbsp;&nbsp;政策法则添加</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0" style=" line-height:45px">
			
              <tr>
                <td width="20%" height="30" align="right" bgcolor="#f2f2f2" class="left_txt2">类型：</td>
                <td width="3%" bgcolor="#f2f2f2">&nbsp;</td>
                <td width="32%" height="30" bgcolor="#f2f2f2">
                    <asp:DropDownList ID="DropDownCateID" runat="server" Width="260">
                    </asp:DropDownList>
                  </td>
                <td width="45%" height="30" bgcolor="#f2f2f2" class="left_txt">
                    &nbsp;</td>
              </tr>

                 <tr>
                <td width="20%" height="30" align="right" bgcolor="#f2f2f2" class="left_txt2">标题：</td>
                <td width="3%" bgcolor="#f2f2f2">&nbsp;</td>
                <td width="32%" height="30" bgcolor="#f2f2f2">
                    <asp:TextBox ID="txt_title" runat="server" Width="400px"></asp:TextBox>
                  </td>
                <td width="45%" height="30" bgcolor="#f2f2f2" class="left_txt">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txt_title" ErrorMessage="文本不为空！" ForeColor="Red"></asp:RequiredFieldValidator>
                     </td>
              </tr>

                <tr>
                <td width="20%" height="30" align="right" bgcolor="#f2f2f2" class="left_txt2">来源：</td>
                <td width="3%" bgcolor="#f2f2f2">&nbsp;</td>
                <td width="32%" height="30" bgcolor="#f2f2f2">
                    <asp:TextBox ID="txt_Source" runat="server" Width="400px"></asp:TextBox>
                  </td>
                <td width="45%" height="30" bgcolor="#f2f2f2" class="left_txt">
                    &nbsp;</td>
              </tr>

                <tr>
                <td width="20%" height="30" align="right" bgcolor="#f2f2f2" class="left_txt2">点击量：</td>
                <td width="3%" bgcolor="#f2f2f2">&nbsp;</td>
                <td width="32%" height="30" bgcolor="#f2f2f2">
                    <asp:TextBox ID="txt_ClickRate" runat="server" Width="400px">0</asp:TextBox>
                  </td>
                <td width="45%" height="30" bgcolor="#f2f2f2" class="left_txt">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txt_ClickRate" ErrorMessage="请输入数字！" ForeColor="Red" 
                        ValidationExpression="^[0-9]\d*$"></asp:RegularExpressionValidator>
                    </td>
              </tr>

                 <tr>
                <td width="20%" height="30" align="right" bgcolor="#f2f2f2" class="left_txt2">
                    来源地址：</td>
                <td width="3%" bgcolor="#f2f2f2">&nbsp;</td>
                <td width="32%" height="30" bgcolor="#f2f2f2">
                    <asp:TextBox ID="txt_SourceUrl" runat="server" Width="400px"></asp:TextBox>
                  </td>
                <td width="45%" height="30" bgcolor="#f2f2f2" class="left_txt">
                    &nbsp;</td>
              </tr>


			
              <tr>
                <td align="right" class="style1">内容：</td>
                <td class="style2">&nbsp;&nbsp;</td>
                <td colspan="2" class="style2">
                    <textarea id="newscontent" cols="100" rows="8" style="width:700px;height:200px;visibility:hidden;" runat="server"></textarea>
                    </td>
              </tr>  
                
              <tr>
                <td height="30" colspan="3" align="right" class="left_txt2"></td>                    
                 <td height="30" class="left_txt">&nbsp;</td>
              </tr>
                         <tr>
                <td height="30" colspan="3" align="center" class="left_txt2">
               
                    &nbsp;&nbsp;<asp:Button ID="btn_ok" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" Height="25px" onclick="btn_ok_Click" Text="提交内容" 
                        Width="65px" />
                             </td>
                 <td height="30" class="left_txt">
                            &nbsp;</td>
              </tr>
              <tr>
                <td height="30" colspan="3" class="left_txt2">
               
                    &nbsp;</td>
              </tr>
              </table></td>
          </tr>
        </table>
                        </td>
      </tr>
    </table></td>
    <td style="background-image:"../images/mail_rightbg.gif"">&nbsp;</td>
  </tr>
  <tr>
      <%--   <td valign="middle" style="background:"../images/mail_leftbg.gif""><img alt="" src="../images/buttom_left2.gif" width="17" height="17" /></td>--%>
      <td height="17" valign="top" background="../images/buttom_bgs.gif" colspan="2"><img alt="" src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif"><img alt="" src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </form>
</body>
</html>
