using Nevron.UI.WinForm.Controls;
using Nui.MallInfo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nui.MallInfo.Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            AutoMainXml.DeserializeXml("AutoMainXml.xml");

            int NSkinForm = Convert.ToInt32(AutoMainXml.StaticAutoXml.NSkinForm);

            NFrameAppearance appearance = NUIManager.GetPredefinedFrame((PredefinedFrame)NSkinForm);

            using (LoginForm frm = new LoginForm())
            {
                if (NSkinForm != 0)
                {
                    frm.UseGlassIfEnabled = CommonTriState.False;
                    frm.EnableSkinning = false;
                    frm.Palette.Copy(NUIManager.Palette);
                    frm.ShowCaptionImage = true;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.FrameAppearance = appearance;
                }

                Application.Run(frm);
            }
           
        }
    }
}
