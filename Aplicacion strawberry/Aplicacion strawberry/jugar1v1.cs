using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion_strawberry
{
    public partial class jugar1v1 : Form
    {
        public jugar1v1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel5.Visible = true;
        }

        private void ant1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel3.Visible = true;
        }

        private void desp1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
