<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="Nui.MallInfo.Web.Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>后台管理</title>
    <script src="js/prototype.lite.js" type="text/javascript"></script>
    <script src="js/moo.fx.js" type="text/javascript"></script>
    <script src="js/moo.fx.pack.js" type="text/javascript"></script>
    <style type="text/css">
        body {
            font: 12px Arial, Helvetica, sans-serif;
            color: #000;
            background-color: #EEF2FB;
            margin: 0px;
        }

        #container {
            width: 182px;
        }

        H1 {
            font-size: 12px;
            margin: 0px;
            width: 182px;
            cursor: pointer;
            height: 30px;
            line-height: 20px;
        }

            H1 a {
                display: block;
                width: 182px;
                color: #000;
                height: 30px;
                text-decoration: none;
                moz-outline-style: none;
                background-image: url(images/menu_bgS.gif);
                background-repeat: no-repeat;
                line-height: 30px;
                text-align: center;
                margin: 0px;
                padding: 0px;
            }

        .content {
            width: 182px;
            height: 26px;
        }

        .MM ul {
            list-style-type: none;
            margin: 0px;
            padding: 0px;
            display: block;
        }

        .MM li {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            list-style-type: none;
            display: block;
            text-decoration: none;
            height: 26px;
            width: 182px;
            padding-left: 0px;
        }

        .MM {
            width: 182px;
            margin: 0px;
            padding: 0px;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            clip: rect(0px,0px,0px,0px);
        }

            .MM a:link {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                color: #333333;
                background-image: url(images/menu_bg1.gif);
                background-repeat: no-repeat;
                height: 26px;
                width: 182px;
                display: block;
                text-align: center;
                margin: 0px;
                padding: 0px;
                overflow: hidden;
                text-decoration: none;
            }

            .MM a:visited {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                color: #333333;
                background-image: url(images/menu_bg1.gif);
                background-repeat: no-repeat;
                display: block;
                text-align: center;
                margin: 0px;
                padding: 0px;
                height: 26px;
                width: 182px;
                text-decoration: none;
            }

            .MM a:active {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                color: #333333;
                background-image: url(images/menu_bg1.gif);
                background-repeat: no-repeat;
                height: 26px;
                width: 182px;
                display: block;
                text-align: center;
                margin: 0px;
                padding: 0px;
                overflow: hidden;
                text-decoration: none;
            }

            .MM a:hover {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                font-weight: bold;
                color: #006600;
                background-image: url(images/menu_bg2.gif);
                background-repeat: no-repeat;
                text-align: center;
                display: block;
                margin: 0px;
                padding: 0px;
                height: 26px;
                width: 182px;
                text-decoration: none;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" height="280" border="0" cellpadding="0" cellspacing="0" bgcolor="#EEF2FB">
            <tr>
                <td width="182" valign="top">
                    <div id="container">

                        <h1 class="type">
                            <a href="javascript:void(0)">用户角色</a>
                        </h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="User/UserList.aspx" target="main">用户管理</a></li>
                                <li><a href="ManageHTML/ADDAbount.aspx" target="main">内容添加</a></li>
                                <li><a href="ManageHTML/AbountManage.aspx" target="main">内容管理</a></li>
                            </ul>
                        </div>









                        <h1 class="type">
                            <a href="javascript:void(0)">关于我们</a>
                        </h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="ManageHTML/ADDCateAbout.aspx" target="main">类型管理</a></li>
                                <li><a href="ManageHTML/ADDAbount.aspx" target="main">内容添加</a></li>
                                <li><a href="ManageHTML/AbountManage.aspx" target="main">内容管理</a></li>
                            </ul>
                        </div>

                        <h1 class="type">
                            <a href="javascript:void(0)">政策法规</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="ManageHTML/ADDCateLaws.aspx" target="main">分类管理</a></li>
                                <li><a href="ManageHTML/ADDLaws.aspx" target="main">内容添加</a></li>
                                <li><a href="ManageHTML/LawsManage.aspx" target="main">内容管理</a></li>
                            </ul>
                        </div>

                        <h1 class="type">
                            <a href="javascript:void(0)">资讯管理</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="ManageHTML/NewCateManage.aspx" target="main">分类管理</a></li>
                                <li><a href="ManageHTML/ADDNews.aspx" target="main">内容添加</a></li>
                                <li><a href="ManageHTML/NewsManage.aspx" target="main">内容管理</a></li>
                            </ul>
                        </div>

                        <h1 class="type">
                            <a href="javascript:void(0)">下载管理</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="ManageHTML/ADDCateDownLoadManage.aspx" target="main">下载分类</a></li>
                                <li><a href="ManageHTML/ADDDownLoad.aspx" target="main">下载添加</a></li>
                                <li><a href="ManageHTML/DownLoadManage.aspx" target="main">下载管理</a></li>

                            </ul>
                        </div>

                        <h1 class="type">
                            <a href="javascript:void(0)">产品管理</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="ManageHTML/PrdeictCateManage.aspx" target="main">产品分类</a></li>
                                <li><a href="ManageHTML/ADDProduct.aspx" target="main">产品添加</a></li>
                                <li><a href="ManageHTML/ProductManage.aspx" target="main">产品管理</a></li>

                            </ul>
                        </div>


                        <h1 class="type">
                            <a href="javascript:void(0)">合作伙伴</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="ManageHTML/PartnerManager.aspx" target="main">管理</a></li>


                            </ul>
                        </div>


                        <h1 class="type">
                            <a href="javascript:void(0)">客户中心</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="images/menu_topline.gif" width="182" height="5" />
                                    </td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li><a href="ManageHTML/ADDCustomerCenterCate.aspx" target="main">分类管理</a></li>
                                <li><a href="ManageHTML/ADDCustomerCenter.aspx" target="main">客服添加</a></li>
                                <li><a href="ManageHTML/ManageCustomerCenter.aspx" target="main">客服管理</a></li>

                            </ul>
                        </div>

                        <script type="text/javascript">
                            var contents = document.getElementsByClassName('content');
                            var toggles = document.getElementsByClassName('type');

                            var myAccordion = new fx.Accordion(
                    toggles, contents, { opacity: true, duration: 400 }
                );
                            myAccordion.showThisHideOpen(contents[0]);
                        </script>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
