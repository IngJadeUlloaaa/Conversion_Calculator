using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_cientifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            double L = double.Parse(Num1.Text);
            double M = double.Parse(Num2.Text);

            double DT = L / M;
            
            if (DT < 1 && DT > 0)
            {
                gbCalculo.Visible = true;
                EficienciaDelsistema.Visible = true;
            }    
            else
            {
                MessageBox.Show("Este Calculo esta saturando el programa");
            }
            double po = 1 - DT;
            double E = DT * 1;
            double L1 = DT / 1;
            double Pn = Math.Pow(DT, 2) * po;
            double Lq = Math.Pow(DT, 2) / (1 - DT);
            double Wq = DT / M * (1 - DT);
            double W = 1 / M * (1 - DT);

            txtE.Text = Convert.ToString(E);    
            txtPn.Text = Convert.ToString(Pn);
            txtWq.Text = Convert.ToString(Wq);
            txtW.Text = Convert.ToString(W);
            txtLq.Text = Convert.ToString(Lq);
            txtPo.Text = Convert.ToString(po);
            txtL.Text = Convert.ToString(L1);
            txtE.Text = Convert.ToString(E);

        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            gbCalculo.Visible = false;
            Num1.Clear();
            Num2.Clear();
            Num1.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbCalculo_Enter(object sender, EventArgs e)
        {

        }

        private void txtL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
