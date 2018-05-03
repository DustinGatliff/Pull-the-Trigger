using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pull_the_Trigger
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.pictureBox1.Image = Properties.Resources.About;
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
