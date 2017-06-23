﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TIllegaListManage.aspx.cs" Inherits="Nui.MallInfo.Web.ManageHTML.TIllegaListManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"  runat="server">
    <title>关于我们</title>
        <style type="text/css">
            #news_content
            {
                height: 88px;
                width: 200px;
            }
        </style>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.4.1.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <%--<td width="17" height="29" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>--%>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif" colspan="2"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">非法宣传</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <%--<td height="71" valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>--%>
    <td valign="top" bgcolor="#F7F8F9" colspan="2"><table width="100%" height="138" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td height="13" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td valign="top"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td class="left_txt">当前位置：新闻修改</td>
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
                <td width="90%" valign="top"><span class="left_txt2">在这里，您可以根据您的网站要求，</span><span class="left_txt3">对新闻进行管理</span><span class="left_txt2">！</span><br>
                          <span class="left_txt2">包括</span><span class="left_txt3">对新闻标题,新闻关键字，新闻图片，新闻内容的修改或者删除</span><span class="left_txt2">等。 </span></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2">&nbsp;&nbsp;&nbsp;&nbsp;新闻管理</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td align="left" bgcolor="#CCCCCC">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" DataKeyNames="ID"  Width="100%"
                    onrowdeleting="GridView1_RowDeleting">
                    <Columns>
                        <%--<asp:TemplateField HeaderText="午评">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" ToolTip='<%#Eval("AComment") %>'  Text='<%# Eval("AComment").ToString().Length>12?Eval("AComment").ToString().Substring(0,10)+"...":Eval("AComment") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="晚评">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" ToolTip='<%#Eval("EComment") %>' Text='<%# Eval("EComment").ToString().Length>12?Eval("EComment").ToString().Substring(0,10)+"...":Eval("EComment")  %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField DataField="ID" HeaderText="编号" />
                        <asp:BoundField DataField="TypeName" HeaderText="类型" />
                        <asp:TemplateField HeaderText="姓名">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" 
                                    NavigateUrl='<%# Eval("ID", "ADDTIllegaList.aspx?id={0}") %>' ToolTip='<%#Eval("Name") %>' Text='<%# Eval("Name").ToString().Length>35?Eval("Name").ToString().Substring(0,32)+"...":Eval("Name") %>'></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Phone" HeaderText="手机" />
                        <asp:BoundField DataField="Tel" HeaderText="电话" />
                        <asp:BoundField DataField="Email" HeaderText="邮箱" />
                        <asp:BoundField DataField="QQ" HeaderText="QQ" />
                        <asp:BoundField DataField="MicroBlogURL" HeaderText="微博" />
                        <asp:BoundField DataField="WeChat" HeaderText="微信" />
                        <asp:BoundField DataField="HttpUrl" HeaderText="网址" />
                        <asp:BoundField DataField="Address" HeaderText="地址" />
                        <asp:BoundField DataField="AddDate" HeaderText="插入时间" 
                            DataFormatString="{0:yyyy-MM-dd}" />
                        <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
              </td>
          </tr>
        </table>
     </td>
      </tr>
    </table></td>
    <td style="background-image:"../images/mail_rightbg.gif"">&nbsp;</td>
  </tr>
  <tr>
    <%--<td valign="middle" style="background:"../images/mail_leftbg.gif""><img alt="" src="../images/buttom_left2.gif" width="17" height="17" /></td>--%>
      <td height="17" valign="top" background="../images/buttom_bgs.gif" colspan="2"><img alt="" src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif"><img alt="" src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>

    </form>
</body>
</html>