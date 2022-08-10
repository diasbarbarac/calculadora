using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblResultado_Click(object sender, EventArgs e)
        {
            LblResultado.Text= " ";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja mesmo sair do sistema ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Sair.Equals(DialogResult.No))
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;

            double resultado = 0;

            n1= Convert.ToDouble(TxtNum1.Text);
            n2=Convert.ToDouble(TxtNum2.Text);

            switch (CbotipoCalc.SelectedItem.ToString())
            {
                case "Divisão":
                    resultado= n1/n2;
                    break;

                case "Multiplicação":
                    resultado= n1*n2;
                    break;

                case "Adição":
                    resultado= n1+n2;
                    break;

                case "Subtração":
                    resultado= n1-n2;
                    break;
            }
            
            
            
            
            
            LblResultado.Text= Convert.ToString(resultado);
           
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNum1.Clear();
            TxtNum2.Clear();
            LblResultado.Text= "";
        }
    }
}