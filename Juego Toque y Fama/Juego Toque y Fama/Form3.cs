using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_Toque_y_Fama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random r;
            r = new Random();
            int aleat3 = r.Next(000, 999);
            txtnumadivi.Text = aleat3.ToString();
        }

        private void bntadivina_Click(object sender, EventArgs e)
        {
            int num;
            int dig1;
            int dig2;
            int dig3;
            int xnum;
            int xdig1;
            int xdig2;
            int xdig3;

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
                    dig1 = num / 100;
                    dig2 = num % 100 / 10;
                    dig3 = num % 100 % 10;
                    xdig1 = xnum / 100;
                    xdig2 = xnum % 100 / 10;
                    xdig3 = xnum % 100 % 10;

                    if ((dig1 == xdig1) || (dig2 == xdig2) || (dig3 == xdig3))
                    {
                        txtfamas.Text = "1";
                    }
                    else
                    {
                        txtfamas.Text = "Ninguno";
                    }
                    if ((dig1 == xdig1) & (dig2 == xdig2) || (dig1 == xdig1) & (dig3 == xdig3) || (dig2 == xdig2) & (dig3 == xdig3))
                    {
                        txtfamas.Text = "2";
                    }
                    if ((dig1 == xdig2) || (dig1 == xdig3) || (dig2 == xdig1) || (dig2 == xdig3) || (dig3 == xdig1) || (dig3 == xdig2))
                    {
                        txttoques.Text = "1";
                    }
                    else
                    {
                        txttoques.Text = "Ninguno";
                    }
                    if ((dig1 == xdig2) & (dig1 == xdig3) || (dig1 == xdig2) & (dig2 == xdig1) || (dig1 == xdig3) & (dig2 == xdig1) || (dig1 == xdig2) & (dig2 == xdig3) || (dig1 == xdig3) & (dig2 == xdig1) || (dig1 == xdig2) & (dig3 == xdig1) || (dig1 == xdig3) & (dig3 == xdig2) || (dig2 == xdig1) & (dig3 == xdig2) || (dig2 == xdig3) & (dig3 == xdig1))
                    {
                        txttoques.Text = "2";
                    }
                    if ((dig1 == xdig2) & (dig1 == xdig3) & (dig1 == xdig2) & (dig2 == xdig1) & (dig1 == xdig3) & (dig2 == xdig1) || (dig1 == xdig2) & (dig2 == xdig3) || (dig1 == xdig3) & (dig2 == xdig1) & (dig1 == xdig2) & (dig3 == xdig1) & (dig1 == xdig3) & (dig3 == xdig2) & (dig2 == xdig1) & (dig3 == xdig2) & (dig2 == xdig3) & (dig3 == xdig1))
                    {
                        txttoques.Text = "3";
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