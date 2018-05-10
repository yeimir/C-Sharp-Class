using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_Toque_y_Fama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Random r; 
            r = new Random();
            int aleat2 = r.Next(00, 99);
            txtnumadivi.Text = aleat2.ToString();
        }
        private void bntadivina_Click(object sender, EventArgs e)
        {
            int num;
            int dig1;
            int dig2;
            int xnum;
            int xdig1;
            int xdig2;

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
                    dig1 = num / 10;
                    dig2 = num % 10;
                    xdig1 = xnum / 10;
                    xdig2 = xnum % 10;
                    if ((dig1 == xdig1) || (dig2 == xdig2))
                    {
                        txtfamas.Text = "1";
                    }
                    else
                    {
                        txtfamas.Text = "Ninguno";
                    }
                    if ((dig1 == xdig2) || (dig2 == xdig1))
                    {
                        txttoques.Text = "1";
                    }
                    else
                    {
                        txttoques.Text = "Ninguno";
                    }
                    if ((dig1 == xdig2) & (dig2 == xdig1))
                    {
                        txttoques.Text = "2";
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