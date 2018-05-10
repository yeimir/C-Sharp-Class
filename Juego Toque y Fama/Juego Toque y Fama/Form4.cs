using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_Toque_y_Fama
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Random r;
            r = new Random();
            int aleat4 = r.Next(0000, 9999);
            txtnumadivi.Text = aleat4.ToString();
        }
        private void bntadivina_Click(object sender, EventArgs e)
        {
            int num;
            int dig1;
            int dig2;
            int dig3;
            int dig4;
            int xnum;
            int xdig1;
            int xdig2;
            int xdig3;
            int xdig4;

            try
            {
                num = int.Parse(txtnumadivi.Text);
                xnum = int.Parse(txtnum.Text);

                if (num == xnum)
                {
                    MessageBox.Show("Felicidades adivino el numero", "Gano!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    bntadivina.Enabled = false;
                    txtnum.ReadOnly = true;
                }
                else
                {
                    dig1 = num / 1000;
                    dig2 = num % 1000 / 100;
                    dig3 = num % 1000 % 100 / 10;
                    dig4 = num % 1000 % 100 % 10;
                    xdig1 = xnum / 1000;
                    xdig2 = xnum % 1000 / 100;
                    xdig3 = xnum % 1000 % 100 / 10;
                    xdig4 = xnum % 1000 % 100 % 10;

                    if ((dig1 == xdig1) || (dig2 == xdig2) || (dig3 == xdig3) || (dig4 == xdig4))
                    {
                        txtfamas.Text = "1";
                    }
                    else
                    {
                        txtfamas.Text = "Ninguno";
                    }
                    if ((dig1 == xdig1) & (dig2 == xdig2) || (dig1 == xdig1) & (dig3 == xdig3) || (dig1 == xdig1) & (dig4 == xdig4) || (dig2 == xdig2) & (dig3 == xdig3) || (dig2 == xdig2) & (dig4 == xdig4) || (dig3 == xdig3) & (dig4 == xdig4))
                    {
                        txtfamas.Text = "2";
                    }
                    if ((dig1 == xdig1) & (dig2 == xdig2) & (dig3 == xdig3) || (dig1 == xdig1) & (dig2 == xdig2) & (dig4 == xdig4) || (dig1 == xdig1) & (dig3 == xdig3) & (dig4 == xdig4) || (dig2 == xdig2) & (dig3 == xdig3) & (dig4 == xdig4))
                    {
                        txtfamas.Text = "3";
                    }
                    if ((dig1 == xdig2) || (dig1 == xdig3) || (dig1 == xdig4) || (dig2 == xdig1) || (dig2 == xdig3) || (dig2 == xdig4) || (dig3 == xdig1) || (dig2 == xdig4) || (dig3 == xdig1) || (dig3 == xdig2) || (dig3 == xdig4) || (dig4 == xdig1) || (dig4 == xdig2) || (dig4 == xdig3))
                    {
                        txttoques.Text = "1";
                    }
                    else
                    {
                        txttoques.Text = "Ninguno";
                    }
                    if ((dig1 == xdig2) & (dig1 == xdig3) || (dig1 == xdig2) & (dig1 == xdig4) || (dig1 == xdig3) & (dig1 == xdig4) || (dig1 == xdig2) & (dig2 == xdig1) || (dig1 == xdig2) & (dig2 == xdig3) || (dig1 == xdig2) & (dig2 == xdig4) || (dig1 == xdig3) & (dig2 == xdig1) || (dig1 == xdig3) & (dig2 == xdig3) || (dig1 == xdig3) & (dig2 == xdig4) || (dig1 == xdig4) & (dig2 == xdig1) || (dig1 == xdig4) & (dig2 == xdig3) || (dig1 == xdig4) & (dig2 == xdig4) || (dig1 == xdig2) & (dig3 == xdig1) || (dig1 == xdig2) & (dig3 == xdig3) || (dig1 == xdig2) & (dig3 == xdig4) || (dig1 == xdig3) & (dig3 == xdig1) || (dig1 == xdig3) & (dig3 == xdig3) || (dig1 == xdig3) & (dig3 == xdig4) || (dig1 == xdig4) & (dig3 == xdig1) || (dig1 == xdig4) & (dig3 == xdig3) || (dig1 == xdig4) & (dig3 == xdig4) || (dig1 == xdig2) & (dig4 == xdig1) || (dig1 == xdig2) & (dig4 == xdig2) || (dig1 == xdig2) & (dig4 == xdig3) || (dig1 == xdig3) & (dig4 == xdig1) || (dig1 == xdig3) & (dig4 == xdig2) || (dig1 == xdig3) & (dig4 == xdig3) || (dig1 == xdig4) & (dig4 == xdig1) || (dig1 == xdig4) & (dig4 == xdig2) || (dig1 == xdig4) & (dig4 == xdig3) || (dig2 == xdig1) & (dig2 == xdig3) || (dig2 == xdig1) & (dig2 == xdig4) || (dig2 == xdig3) & (dig2 == xdig4) || (dig2 == xdig1) & (dig3 == xdig1) || (dig2 == xdig1) & (dig3 == xdig2) || (dig2 == xdig1) & (dig3 == xdig4) || (dig2 == xdig3) & (dig3 == xdig1) || (dig2 == xdig3) & (dig3 == xdig2) || (dig2 == xdig3) & (dig3 == xdig4) || (dig2 == xdig4) & (dig3 == xdig1) || (dig2 == xdig4) & (dig3 == xdig2) || (dig2 == xdig4) & (dig3 == xdig4) || (dig2 == xdig1) & (dig4 == xdig1) || (dig2 == xdig1) & (dig4 == xdig2) || (dig2 == xdig1) & (dig4 == xdig3) || (dig2 == xdig3) & (dig4 == xdig1) || (dig2 == xdig3) & (dig4 == xdig2) || (dig2 == xdig3) & (dig4 == xdig3) || (dig2 == xdig4) & (dig4 == xdig1) || (dig2 == xdig4) & (dig4 == xdig2) || (dig2 == xdig4) & (dig4 == xdig3) || (dig3 == xdig1) & (dig3 == xdig2) || (dig3 == xdig1) & (dig3 == xdig4) || (dig3 == xdig1) & (dig4 == xdig1) || (dig3 == xdig1) & (dig4 == xdig2) || (dig3 == xdig1) & (dig4 == xdig3) || (dig3 == xdig2) & (dig4 == xdig1) || (dig3 == xdig2) & (dig4 == xdig2) || (dig3 == xdig2) & (dig4 == xdig3) || (dig3 == xdig4) & (dig4 == xdig1) || (dig3 == xdig4) & (dig4 == xdig2) || (dig3 == xdig4) & (dig4 == xdig3))
                    {
                        txttoques.Text = "2";
                    }
                    if ((dig1 == xdig2) & (dig1 == xdig3) & (dig1 == xdig4) || (dig1 == xdig2) & (dig1 == xdig3) & (dig2 == xdig1) || (dig1 == xdig2) & (dig1 == xdig3) & (dig2 == xdig3) || (dig1 == xdig2) & (dig1 == xdig3) & (dig2 == xdig4) || (dig1 == xdig2) & (dig2 == xdig1) & (dig1 == xdig4) || (dig1 == xdig2) & (dig2 == xdig3) & (dig1 == xdig4) || (dig1 == xdig2) & (dig2 == xdig4) & (dig1 == xdig4) || (dig2 == xdig1) & (dig1 == xdig3) & (dig1 == xdig4) || (dig2 == xdig3) & (dig1 == xdig3) & (dig1 == xdig4) || (dig2 == xdig4) & (dig1 == xdig3) & (dig1 == xdig4) || (dig1 == xdig2) & (dig1 == xdig3) & (dig4 == xdig1) || (dig1 == xdig2) & (dig1 == xdig3) & (dig4 == xdig2) || (dig1 == xdig2) & (dig1 == xdig3) & (dig4 == xdig3) || (dig1 == xdig2) & (dig4 == xdig1) & (dig1 == xdig4) || (dig1 == xdig2) & (dig4 == xdig2) & (dig1 == xdig4) || (dig1 == xdig2) & (dig4 == xdig3) & (dig1 == xdig4) || (dig4 == xdig1) & (dig1 == xdig3) & (dig1 == xdig4) || (dig4 == xdig2) & (dig1 == xdig3) & (dig1 == xdig4) || (dig4 == xdig3) & (dig1 == xdig3) & (dig1 == xdig4) || (dig2 == xdig1) & (dig2 == xdig3) & (dig2 == xdig4) || (dig2 == xdig1) & (dig2 == xdig3) & (dig3 == xdig1) || (dig2 == xdig1) & (dig2 == xdig3) & (dig3 == xdig2) || (dig2 == xdig1) & (dig2 == xdig3) & (dig3 == xdig4) || (dig2 == xdig1) & (dig3 == xdig1) & (dig2 == xdig4) || (dig2 == xdig1) & (dig3 == xdig2) & (dig2 == xdig4) || (dig2 == xdig1) & (dig3 == xdig4) & (dig2 == xdig4) || (dig3 == xdig1) & (dig2 == xdig3) & (dig2 == xdig4) || (dig3 == xdig2) & (dig2 == xdig3) & (dig2 == xdig4) || (dig3 == xdig4) & (dig2 == xdig3) & (dig2 == xdig4) || (dig2 == xdig1) & (dig2 == xdig3) & (dig4 == xdig1) || (dig2 == xdig1) & (dig2 == xdig3) & (dig4 == xdig2) || (dig2 == xdig1) & (dig2 == xdig3) & (dig4 == xdig3) || (dig2 == xdig1) & (dig4 == xdig1) & (dig2 == xdig4) || (dig2 == xdig1) & (dig4 == xdig2) & (dig2 == xdig4) || (dig2 == xdig1) & (dig4 == xdig3) & (dig2 == xdig4) || (dig4 == xdig1) & (dig2 == xdig3) & (dig2 == xdig4) || (dig4 == xdig2) & (dig2 == xdig3) & (dig2 == xdig4) || (dig4 == xdig3) & (dig2 == xdig3) & (dig2 == xdig4) || (dig3 == xdig1) & (dig3 == xdig2) & (dig3 == xdig4) || (dig3 == xdig1) & (dig3 == xdig2) & (dig4 == xdig1) || (dig3 == xdig1) & (dig3 == xdig2) & (dig4 == xdig2) || (dig3 == xdig1) & (dig3 == xdig2) & (dig4 == xdig3) || (dig3 == xdig1) & (dig4 == xdig1) & (dig3 == xdig4) || (dig3 == xdig1) & (dig4 == xdig2) & (dig3 == xdig4) || (dig3 == xdig1) & (dig4 == xdig3) & (dig3 == xdig4) || (dig4 == xdig1) & (dig3 == xdig2) & (dig3 == xdig4) || (dig4 == xdig2) & (dig3 == xdig2) & (dig3 == xdig4) || (dig4 == xdig3) & (dig3 == xdig2) & (dig3 == xdig4))
                    {
                        txttoques.Text = "3";
                    }
                    if ((dig1 == xdig2) & (dig1 == xdig3) & (dig1 == xdig4) & (dig1 == xdig2) & (dig1 == xdig3) & (dig2 == xdig1) & (dig1 == xdig2) & (dig1 == xdig3) & (dig2 == xdig3) & (dig1 == xdig2) & (dig1 == xdig3) & (dig2 == xdig4) & (dig1 == xdig2) & (dig2 == xdig1) & (dig1 == xdig4) & (dig1 == xdig2) & (dig2 == xdig3) & (dig1 == xdig4) & (dig1 == xdig2) & (dig2 == xdig4) & (dig1 == xdig4) & (dig2 == xdig1) & (dig1 == xdig3) & (dig1 == xdig4) & (dig2 == xdig3) & (dig1 == xdig3) & (dig1 == xdig4) & (dig2 == xdig4) & (dig1 == xdig3) & (dig1 == xdig4) & (dig1 == xdig2) & (dig1 == xdig3) & (dig4 == xdig1) & (dig1 == xdig2) & (dig1 == xdig3) & (dig4 == xdig2) & (dig1 == xdig2) & (dig1 == xdig3) & (dig4 == xdig3) & (dig1 == xdig2) & (dig4 == xdig1) & (dig1 == xdig4) & (dig1 == xdig2) & (dig4 == xdig2) & (dig1 == xdig4) & (dig1 == xdig2) & (dig4 == xdig3) & (dig1 == xdig4) & (dig4 == xdig1) & (dig1 == xdig3) & (dig1 == xdig4) & (dig4 == xdig2) & (dig1 == xdig3) & (dig1 == xdig4) & (dig4 == xdig3) & (dig1 == xdig3) & (dig1 == xdig4) & (dig2 == xdig1) & (dig2 == xdig3) & (dig2 == xdig4) & (dig2 == xdig1) & (dig2 == xdig3) & (dig3 == xdig1) & (dig2 == xdig1) & (dig2 == xdig3) & (dig3 == xdig2) & (dig2 == xdig1) & (dig2 == xdig3) & (dig3 == xdig4) & (dig2 == xdig1) & (dig3 == xdig1) & (dig2 == xdig4) & (dig2 == xdig1) & (dig3 == xdig2) & (dig2 == xdig4) & (dig2 == xdig1) & (dig3 == xdig4) & (dig2 == xdig4) & (dig3 == xdig1) & (dig2 == xdig3) & (dig2 == xdig4) & (dig3 == xdig2) & (dig2 == xdig3) & (dig2 == xdig4) & (dig3 == xdig4) & (dig2 == xdig3) & (dig2 == xdig4) & (dig2 == xdig1) & (dig2 == xdig3) & (dig4 == xdig1) & (dig2 == xdig1) & (dig2 == xdig3) & (dig4 == xdig2) & (dig2 == xdig1) & (dig2 == xdig3) & (dig4 == xdig3) & (dig2 == xdig1) & (dig4 == xdig1) & (dig2 == xdig4) & (dig2 == xdig1) & (dig4 == xdig2) & (dig2 == xdig4) & (dig2 == xdig1) & (dig4 == xdig3) & (dig2 == xdig4) & (dig4 == xdig1) & (dig2 == xdig3) & (dig2 == xdig4) & (dig4 == xdig2) & (dig2 == xdig3) & (dig2 == xdig4) & (dig4 == xdig3) & (dig2 == xdig3) & (dig2 == xdig4) & (dig3 == xdig1) & (dig3 == xdig2) & (dig3 == xdig4) & (dig3 == xdig1) & (dig3 == xdig2) & (dig4 == xdig1) & (dig3 == xdig1) & (dig3 == xdig2) & (dig4 == xdig2) & (dig3 == xdig1) & (dig3 == xdig2) & (dig4 == xdig3) & (dig3 == xdig1) & (dig4 == xdig1) & (dig3 == xdig4) & (dig3 == xdig1) & (dig4 == xdig2) & (dig3 == xdig4) & (dig3 == xdig1) & (dig4 == xdig3) & (dig3 == xdig4) & (dig4 == xdig1) & (dig3 == xdig2) & (dig3 == xdig4) & (dig4 == xdig2) & (dig3 == xdig2) & (dig3 == xdig4) & (dig4 == xdig3) & (dig3 == xdig2) & (dig3 == xdig4))
                    {
                        txttoques.Text = "4";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Posiblemente no digito los datos o ingreso un dato inadecuado", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



