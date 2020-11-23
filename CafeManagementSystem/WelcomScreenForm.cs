using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class WelcomScreenForm : Form
    {
        public WelcomScreenForm()
        {
            InitializeComponent();
        }
        private int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                BannerLabel.Location = new Point(20, 374);
                BannerLabel.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                BannerLabel.Location = new Point(180, 374);
                BannerLabel.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                BannerLabel.Location = new Point(330, 374);
                BannerLabel.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void WelcomScreenForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
