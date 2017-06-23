using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nevron.UI.WinForm.Controls;
using Fx678Member.Framework.Log;
using System.Data;
using System.Windows.Forms;

namespace Nui.MallInfo.Utility
{


    /// <summary>
    /// MainForm主窗体扩展类
    /// </summary>
    public class AutoMain
    {
        /// <summary>
        /// 主题设置
        /// </summary>
        /// <param name="SkinsName"></param>
        public static void GetNSkinResource(string SkinsName)
        {
            try
            {

                //2,7  PredefinedFrame.Office2007Blue  Vista, Orange, MacOS
                NSkinManager.Instance.Enabled = true;
                NSkinResource res = new NSkinResource(SkinResourceType.GlobalAssembly, SkinsName);
                res.AssemblyName = "Nevron.UI.WinForm.Skins";
                NSkin skin = new NSkin();

                if (SkinsName == string.Empty)
                {
                    NSkinManager.Instance.Skin = null;
                }
                else
                {
                    if (skin.Load(res))
                    {
                        NSkinManager.Instance.Skin = skin;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("主题设置", ex);
            }

        }

        /// <summary>
        /// Form主题设置事件
        /// </summary>
        public static void GetFormCommand(string Sender, NCommand nCmd2_1, NCommand nCmd2_2,
            NCommand nCmd2_3, NCommand nCmd2_4, NCommand nCmd2_5, NCommand nCmd2_6, NCommand nCmd2_7, NCommand nCmd2_8)
        {
            switch (Sender)
            {
                case "默认":
                    nCmd2_1.Checked = true;
                    nCmd2_2.Checked = false;
                    nCmd2_3.Checked = false;
                    nCmd2_4.Checked = false;
                    nCmd2_5.Checked = false;
                    nCmd2_6.Checked = false;
                    nCmd2_7.Checked = false;
                    nCmd2_8.Checked = false;
                    AutoMainXml.SetValue("NSkinForm", "0");
                    AutoMainXml.SetValue("NSkinFormName", "默认");
                    break;
                case "Simple":
                    nCmd2_1.Checked = false;
                    nCmd2_2.Checked = true;
                    nCmd2_3.Checked = false;
                    nCmd2_4.Checked = false;
                    nCmd2_5.Checked = false;
                    nCmd2_6.Checked = false;
                    nCmd2_7.Checked = false;
                    nCmd2_8.Checked = false;
                    AutoMainXml.SetValue("NSkinForm", "1");
                    AutoMainXml.SetValue("NSkinFormName", "Simple");
                    break;
                case "VistaSlate":
                    nCmd2_1.Checked = false;
                    nCmd2_2.Checked = false;
                    nCmd2_3.Checked = true;
                    nCmd2_4.Checked = false;
                    nCmd2_5.Checked = false;
                    nCmd2_6.Checked = false;
                    nCmd2_7.Checked = false;
                    nCmd2_8.Checked = false;
                    AutoMainXml.SetValue("NSkinForm", "2");
                    AutoMainXml.SetValue("NSkinFormName", "VistaSlate");
                    break;
                case "VistaRoyal":
                    nCmd2_1.Checked = false;
                    nCmd2_2.Checked = false;
                    nCmd2_3.Checked = false;
                    nCmd2_4.Checked = true;
                    nCmd2_5.Checked = false;
                    nCmd2_6.Checked = false;
                    nCmd2_7.Checked = false;
                    nCmd2_8.Checked = false;
                    AutoMainXml.SetValue("NSkinForm", "3");
                    AutoMainXml.SetValue("NSkinFormName", "VistaRoyal");
                    break;
                case "OpusAlpha":
                    nCmd2_1.Checked = false;
                    nCmd2_2.Checked = false;
                    nCmd2_3.Checked = false;
                    nCmd2_4.Checked = false;
                    nCmd2_5.Checked = true;
                    nCmd2_6.Checked = false;
                    nCmd2_7.Checked = false;
                    nCmd2_8.Checked = false;
                    AutoMainXml.SetValue("NSkinForm", "4");
                    AutoMainXml.SetValue("NSkinFormName", "OpusAlpha");
                    break;
                case "Inspirat":
                    nCmd2_1.Checked = false;
                    nCmd2_2.Checked = false;
                    nCmd2_3.Checked = false;
                    nCmd2_4.Checked = false;
                    nCmd2_5.Checked = false;
                    nCmd2_6.Checked = true;
                    nCmd2_7.Checked = false;
                    nCmd2_8.Checked = false;
                    AutoMainXml.SetValue("NSkinForm", "5");
                    AutoMainXml.SetValue("NSkinFormName", "Inspirat");
                    break;
                case "Office2007Blue":
                    nCmd2_1.Checked = false;
                    nCmd2_2.Checked = false;
                    nCmd2_3.Checked = false;
                    nCmd2_4.Checked = false;
                    nCmd2_5.Checked = false;
                    nCmd2_6.Checked = false;
                    nCmd2_7.Checked = true;
                    nCmd2_8.Checked = false;
                    AutoMainXml.SetValue("NSkinForm", "6");
                    AutoMainXml.SetValue("NSkinFormName", "Office2007Blue");
                    break;
                case "Office2007Aqua":
                    nCmd2_1.Checked = false;
                    nCmd2_2.Checked = false;
                    nCmd2_3.Checked = false;
                    nCmd2_4.Checked = false;
                    nCmd2_5.Checked = false;
                    nCmd2_6.Checked = false;
                    nCmd2_7.Checked = false;
                    nCmd2_8.Checked = true;
                    AutoMainXml.SetValue("NSkinForm", "7");
                    AutoMainXml.SetValue("NSkinFormName", "Office2007Aqua");
                    break;
            }
        }

        /// <summary>
        /// 页面主题设置事件
        /// </summary>
        public static void GetMenuCommand(string Sender, NCommand nCmd1, NCommand nCmd2,
            NCommand nCmd3, NCommand nCmd4, NCommand nCmd5, NCommand nCmd6)
        {
            switch (Sender)
            {
                case "默认":
                    nCmd1.Checked = true;
                    nCmd2.Checked = false;
                    nCmd3.Checked = false;
                    nCmd4.Checked = false;
                    nCmd5.Checked = false;
                    nCmd6.Checked = false;
                    AutoMain.GetNSkinResource(string.Empty);
                    AutoMainXml.SetValue("NSkinResource", "");
                    AutoMainXml.SetValue("NSkinName", "默认");
                    break;
                case "Vista":
                    nCmd2.Checked = true;
                    nCmd1.Checked = false;
                    nCmd3.Checked = false;
                    nCmd4.Checked = false;
                    nCmd5.Checked = false;
                    nCmd6.Checked = false;
                    AutoMain.GetNSkinResource("Vista");
                    AutoMainXml.SetValue("NSkinResource", "Vista");
                    AutoMainXml.SetValue("NSkinName", "Vista");
                    break;
                case "Office 2007 Black":
                    nCmd3.Checked = true;
                    nCmd1.Checked = false;
                    nCmd2.Checked = false;
                    nCmd4.Checked = false;
                    nCmd5.Checked = false;
                    nCmd6.Checked = false;
                    AutoMain.GetNSkinResource("2");
                    AutoMainXml.SetValue("NSkinResource", "2");
                    AutoMainXml.SetValue("NSkinName", "Office 2007 Black");
                    break;
                case "Office 2007 Blue":
                    nCmd4.Checked = true;
                    nCmd1.Checked = false;
                    nCmd2.Checked = false;
                    nCmd3.Checked = false;
                    nCmd5.Checked = false;
                    nCmd6.Checked = false;
                    AutoMain.GetNSkinResource("Office2007Blue");
                    AutoMainXml.SetValue("NSkinResource", "Office2007Blue");
                    AutoMainXml.SetValue("NSkinName", "Office 2007 Blue");
                    break;
                case "Orange":
                    nCmd5.Checked = true;
                    nCmd1.Checked = false;
                    nCmd2.Checked = false;
                    nCmd3.Checked = false;
                    nCmd4.Checked = false;
                    nCmd6.Checked = false;
                    AutoMain.GetNSkinResource("Orange");
                    AutoMainXml.SetValue("NSkinResource", "Orange");
                    AutoMainXml.SetValue("NSkinName", "Orange");
                    break;
                case "Mac OS":
                    nCmd6.Checked = true;
                    nCmd1.Checked = false;
                    nCmd2.Checked = false;
                    nCmd3.Checked = false;
                    nCmd4.Checked = false;
                    nCmd5.Checked = false;
                    AutoMain.GetNSkinResource("MacOS");
                    AutoMainXml.SetValue("NSkinResource", "MacOS");
                    AutoMainXml.SetValue("NSkinName", "Mac OS");
                    break;
            }
        }

    }
}
