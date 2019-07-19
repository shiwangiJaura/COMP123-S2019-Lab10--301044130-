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
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }

        private void EndForm_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {

        }
    }
}
