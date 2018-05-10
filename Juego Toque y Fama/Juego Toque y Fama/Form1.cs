using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_Toque_y_Fama
{
    public partial class Form1 : Form
    {
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoJuegoF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r;
            r = new Random();
            int aleat2 = r.Next(00, 99);
            int aleat3 = r.Next(000, 999);
            int aleat4 = r.Next(0000, 9999);

            f2.txtnum.ReadOnly = false;
            f2.txtnum.Text = "";
            f2.txtfamas.Text = "";
            f2.txttoques.Text = "";
            f2.bntadivina.Enabled = true;
            f2.txtnumadivi.Text = aleat2.ToString();

            /**************************************************/

            f3.txtnum.ReadOnly = false;
            f3.txtnum.Text = "";
            f3.txtfamas.Text = "";
            f3.txttoques.Text = "";
            f3.bntadivina.Enabled = true;
            f3.txtnumadivi.Text = aleat3.ToString();

            /**************************************************/

            f4.txtnum.ReadOnly = false;
            f4.txtnum.Text = "";
            f4.txtfamas.Text = "";
            f4.txttoques.Text = "";
            f4.bntadivina.Enabled = true;
            f4.txtnumadivi.Text = aleat4.ToString();
        }

        private void principianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((flag2 == 1) || (flag3 == 1))
            {
                f3.Hide();
                f3.txtnum.ReadOnly = false;
                f3.txtnum.Text = "";
                f3.txtfamas.Text = "";
                f3.txttoques.Text = "";
                f3.bntadivina.Enabled = true;

                /**************************************************/

                f4.Hide();
                f4.txtnum.ReadOnly = false;
                f4.txtnum.Text = "";
                f4.txtfamas.Text = "";
                f4.txttoques.Text = "";
                f4.bntadivina.Enabled = true;

                flag2 = 0;               
                flag3 = 0;
            }
            flag1 = 1;
            f2.MdiParent = this;
            f2.Show();
        }

        private void intermedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((flag1 == 1) || (flag3 == 1))
            {
                f2.Hide();
                f2.txtnum.ReadOnly = false;
                f2.txtnum.Text = "";
                f2.txtfamas.Text = "";
                f2.txttoques.Text = "";
                f2.bntadivina.Enabled = true;

                /**************************************************/

                f4.Hide();
                f4.txtnum.ReadOnly = false;
                f4.txtnum.Text = "";
                f4.txtfamas.Text = "";
                f4.txttoques.Text = "";
                f4.bntadivina.Enabled = true;

                flag1 = 0;
                flag3 = 0;
            }
            flag2 = 1;
            f3.MdiParent = this;
            f3.Show();
        }

        private void expertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((flag1 == 1) || (flag2 == 1))
            {
                f2.Hide();
                f2.txtnum.ReadOnly = false;
                f2.txtnum.Text = "";
                f2.txtfamas.Text = "";
                f2.txttoques.Text = "";
                f2.bntadivina.Enabled = true;

                /**************************************************/

                f3.Hide();
                f3.txtnum.ReadOnly = false;
                f3.txtnum.Text = "";
                f3.txtfamas.Text = "";
                f3.txttoques.Text = "";
                f3.bntadivina.Enabled = true;

                flag1 = 0;
                flag2 = 0;
            }
            flag3 = 1;
            f4.MdiParent = this;
            f4.Show();

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contenidoF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void acercaDeToqueYFamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 acerca = new AboutBox1();
            acerca.Show();
        }
    }
}