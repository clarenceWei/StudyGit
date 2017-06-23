using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
using Nevron.UI.WinForm.Controls;
using System.Diagnostics;

namespace Nui.MallInfo.Winform
{
    public partial class General : UserControl
    {
      
 
        public General()
        {
            InitializeComponent();
            
        }

        private void General_Load(object sender, EventArgs e)
        {
           
            label1.Location = new Point((this.Width-label1.Width)/2,(this.Height-label1.Height)/2);
        }

        
        private void General_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point((this.Width - label1.Width) / 2, (this.Height - label1.Height) / 2);
        }

       
    }
}
