using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QyLost.UI.Demo
{
    public class UButton : System.Windows.Forms.Button
    {
        public UButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.ForeColor = System.Drawing.Color.White;
        }
    }
}
