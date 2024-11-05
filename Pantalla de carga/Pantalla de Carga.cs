using Qmanager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qmanager
{
    public partial class QManager : Form
    {

        public QManager()
        {
            InitializeComponent();
            this.Opacity = 0; // Inicialmente invisible
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width += 3;
            if (flowLayoutPanel1.Width >= 500)
            {
                timer1.Stop();
                this.Hide();
                Login Login = new Login();
                Login.Show();
            }
        }

        private void FadeInOut_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <= 100)
            {
                this.Opacity += 0.02;
            }
            if (flowLayoutPanel1.Width > 400)
            {
                this.Opacity -= 0.03;
            }
        }
    }
}


