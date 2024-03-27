using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public static  List<Double> numeros = new List<Double>();
        public string operacao;


        public Form1()
        {
            //numeros.RemoveAll();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            visor.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void um_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            visor.Text += ".";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (visor.Text != null)
            {
                numeros.Add(double.Parse(visor.Text));
            }

            visor.Text = somar().ToString();

            limparLista();

        }

        private void adicao_Click(object sender, EventArgs e)
        {
            numeros.Add(double.Parse(visor.Text));
            operacao = "+";
            visor.Text = null;
        }

        private void dois_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            visor.Text += "3";
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            visor.Text += "6";
        }

        private void sete_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }

        private void oito_Click(object sender, EventArgs e)
        {
            visor.Text += "8";
        }

        private void nove_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void divisao_Click(object sender, EventArgs e)
        {

        }


        private void limparLista()
        {
            numeros.Clear();
        }

        private Double somar()
        {
            var soma = numeros.Sum();
            return soma;
        }
    }
}
