using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10__301044130_
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Parent = this;
            mainform.Show();
            this.Hide();
        }
    }
}
