using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QyLost.UI.Demo
{
    public partial class FrmDashboard : FrmParent
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            this.dashboard.Real = this.trackBar.Value;
        }
        private void btnShowAnimation_Click(object sender, EventArgs e)
        {
            decimal real = this.dashboard.Real;
            //don't recommend
            Thread thread = new Thread(new ThreadStart(delegate
                {
                    for (int i = 0; i < 80; i++)
                    {
                        Thread.Sleep(3);
                        this.Invoke(new Action(delegate
                        {
                            this.dashboard.Real = this.dashboard.Expected * (i / 100M);
                        }));
                    }
                    for (int i = 80; i > 1; i--)
                    {
                        Thread.Sleep(3);
                        this.Invoke(new Action(delegate
                        {
                            this.dashboard.Real = this.dashboard.Expected * (i / 100M);
                        }));
                    }
                    this.Invoke(new Action(delegate
                    {
                        this.dashboard.Real = real;
                    }));
                }));
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
