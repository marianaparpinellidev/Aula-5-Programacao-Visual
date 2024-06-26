﻿using System;
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
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparLista();
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

            OperacaoMatematica();

        }

        private void adicao_Click(object sender, EventArgs e)
        {
            IncluirNumero();
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
            IncluirNumero();
            operacao = "/";
            visor.Text = null;

        }


        private void LimparLista()
        {
            numeros.Clear();
        }

        private void Somar()
        {
            var soma = numeros.Sum();
            LimparLista();

            visor.Text = soma.ToString();
        }

        private void IncluirNumero()
        {
            numeros.Add(double.Parse(visor.Text));
        }

        private void Subtrair()
        {
            var numero1 = numeros[0];
            var numero2 = numeros[1];

            var subtracao =  numero1 - numero2;

            visor.Text = subtracao.ToString();
        }

        private void Dividir()
        {
            var numero1 = numeros[0];
            var numero2 = numeros[1];

            var divisao = numero1 / numero2;

            visor.Text = divisao.ToString();
        }

        private void OperacaoMatematica()
        {
            switch(operacao)
            {
                case "+": 
                    Somar(); break;
                case "-": 
                    Subtrair(); break;
                case "/":
                    Dividir(); break;
                case "*":
                    Somar(); break;

            }
        }
    }
}
