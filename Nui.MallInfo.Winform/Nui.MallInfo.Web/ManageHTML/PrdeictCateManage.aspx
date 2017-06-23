<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrdeictCateManage.aspx.cs" Inherits="Nui.MallInfo.Web.ManageHTML.PrdeictCateManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>新闻分类管理</title>
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
        <td height="31"><div class="titlebt">产品分类</div></td>
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
            <td class="left_txt">当前位置：关于我们分类管理</td>
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
                <td width="90%" valign="top"><span class="left_txt2">在这里，您可以根据您的网站要求，对新闻分类进行有效管理！</span><br>
                          <span class="left_txt2">包括对新闻分类的添加，修改，删除。</span></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2">&nbsp;&nbsp;&nbsp;&nbsp;新闻分类具体信息</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
			
              <tr>
                <td width="20%" height="30" align="right" bgcolor="#f2f2f2" class="left_txt2">分类名称：</td>
                <td width="3%" bgcolor="#f2f2f2">&nbsp;</td>
                <td width="32%" height="30" bgcolor="#f2f2f2">
                    <asp:TextBox ID="txt_name" runat="server" Width="240px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txt_name" ErrorMessage="文本不为空！" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    </td>
                <td width="45%" height="30" bgcolor="#f2f2f2" class="left_txt">
                    <asp:Label ID="lb_catename" runat="server" Font-Size="9pt" ForeColor="Red"></asp:Label>
                                                    </td>
              </tr>
                      <tr>
                <td width="20%" height="30" align="right" bgcolor="#f2f2f2" class="left_txt2">描述：</td>
                <td width="3%" bgcolor="#f2f2f2">&nbsp;</td>
                <td width="32%" height="30" bgcolor="#f2f2f2">
                    <asp:TextBox ID="txt_des" runat="server" Width="240px"></asp:TextBox>
                                                    </td>
                <td width="45%" height="30" bgcolor="#f2f2f2" class="left_txt">
                    <asp:Label ID="Label1" runat="server" Font-Size="9pt" ForeColor="Red"></asp:Label>
                                                    </td>
              </tr>
                <%--          <tr>
                <td height="30" align="right" class="left_txt2">新闻分类描述：</td>
                <td>&nbsp;</td>
                <td height="30">
                    <asp:TextBox ID="txt_catedes" runat="server" Width="239px" Height="105px" 
                        TextMode="MultiLine"></asp:TextBox>
                                                    </td>
                <td height="30" class="left_txt">
                    <asp:Label ID="lb_des" runat="server" Font-Size="9pt" ForeColor="Red"></asp:Label>
                                                    </td>
              </tr>--%>
              <tr>
                <td height="17" colspan="4" align="right" >&nbsp;</td>
              </tr>
              </table></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td colspan="3">
              <table width="100%" border="0" cellpadding="0" cellspacing="0" >
              <tr><td><table  width="100%" border="0" cellpadding="0" cellspacing="0" class="nowtable"><tr><td class="left_bt2">&nbsp;&nbsp;&nbsp;&nbsp;新闻分类列表</td></tr></table></td></tr>
                <tr><td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                      Width="90%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" 
                      BorderWidth="1px" CellPadding="3" 
                      DataKeyNames="ID" onrowdeleting="GridView1_RowDeleting"   >
                      <RowStyle ForeColor="#000066" />
                      <Columns>
                          <asp:BoundField DataField="ID" HeaderText="编号" >
                          <ItemStyle HorizontalAlign="Center" />
                          </asp:BoundField>
                          <asp:HyperLinkField DataNavigateUrlFields="ID" DataTextField="TypeName" 
                              HeaderText="分类名称" NavigateUrl="SysAdmin/ManageHTML/NewsCateManage.aspx" 
                              DataNavigateUrlFormatString="PrdeictCateManage.aspx?id={0}" >
                          <ItemStyle HorizontalAlign="Center" />
                          </asp:HyperLinkField>
                          <asp:BoundField DataField="AddTime" DataFormatString="{0:yyyy-MM-dd}" 
                              HeaderText="添加时间">
                          <ItemStyle HorizontalAlign="Center" />
                          </asp:BoundField>
                           <asp:CommandField ShowDeleteButton="True" HeaderText="删除" />
                      </Columns>
                      <FooterStyle BackColor="White" ForeColor="#000066" />
                      <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                      <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                      <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                  </asp:GridView>

                  </td></tr>              
               </table>
                </td>
            </tr>
           <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr>      
              <tr>
              <td width="70%" height="30" align="left" style="padding-left:100px">
                  <asp:Label ID="lb_message" runat="server" Font-Size="9pt" ForeColor="#CCCCCC"></asp:Label>
                  <asp:Button ID="btn_add" runat="server" onclick="btn_add_Click" Text="添   加" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="btn_update" runat="server" Text="修   改" Visible="False" 
                      onclick="btn_update_Click" />
                  <asp:Button ID="btn_cancle" runat="server" Text="取   消" 
                      onclick="btn_cancle_Click" />
                </td>
              <td width="6%" height="30" align="left">&nbsp;</td>
              <td width="44%" height="30">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </td>
            </tr>
            <tr>
              <td height="30" colspan="3">&nbsp;</td>
            </tr>
          </table></td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
      <%--<td valign="middle" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>--%>
      <td height="17" valign="top" background="../images/buttom_bgs.gif" colspan="2"><img src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </form>
</body>
</html>
