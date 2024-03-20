namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.visor = new System.Windows.Forms.TextBox();
            this.porcentagem = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.multiplacacao = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.subtracacao = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor.Location = new System.Drawing.Point(41, 12);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(265, 53);
            this.visor.TabIndex = 0;
            this.visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.visor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // porcentagem
            // 
            this.porcentagem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.porcentagem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentagem.Location = new System.Drawing.Point(41, 71);
            this.porcentagem.Name = "porcentagem";
            this.porcentagem.Size = new System.Drawing.Size(60, 60);
            this.porcentagem.TabIndex = 1;
            this.porcentagem.Text = "%";
            this.porcentagem.UseVisualStyleBackColor = false;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelar.Location = new System.Drawing.Point(107, 71);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(60, 60);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "CE";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.limpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.limpar.Location = new System.Drawing.Point(173, 72);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(60, 60);
            this.limpar.TabIndex = 3;
            this.limpar.Text = "C";
            this.limpar.UseVisualStyleBackColor = false;
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.apagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.apagar.Location = new System.Drawing.Point(239, 72);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(60, 60);
            this.apagar.TabIndex = 4;
            this.apagar.Text = "<-";
            this.apagar.UseVisualStyleBackColor = false;
            // 
            // sete
            // 
            this.sete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sete.Location = new System.Drawing.Point(41, 137);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(60, 60);
            this.sete.TabIndex = 5;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = false;
            // 
            // oito
            // 
            this.oito.BackColor = System.Drawing.SystemColors.ControlLight;
            this.oito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.oito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oito.Location = new System.Drawing.Point(107, 137);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(60, 60);
            this.oito.TabIndex = 6;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = false;
            // 
            // nove
            // 
            this.nove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nove.Location = new System.Drawing.Point(173, 138);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(60, 60);
            this.nove.TabIndex = 7;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = false;
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.divisao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(239, 138);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(60, 60);
            this.divisao.TabIndex = 8;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            // 
            // quatro
            // 
            this.quatro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quatro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quatro.Location = new System.Drawing.Point(41, 203);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(60, 60);
            this.quatro.TabIndex = 9;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = false;
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cinco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(107, 203);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(60, 60);
            this.cinco.TabIndex = 10;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(173, 203);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(60, 60);
            this.seis.TabIndex = 11;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            // 
            // multiplacacao
            // 
            this.multiplacacao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.multiplacacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.multiplacacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplacacao.Location = new System.Drawing.Point(239, 204);
            this.multiplacacao.Name = "multiplacacao";
            this.multiplacacao.Size = new System.Drawing.Size(60, 60);
            this.multiplacacao.TabIndex = 12;
            this.multiplacacao.Text = "x";
            this.multiplacacao.UseVisualStyleBackColor = false;
            this.multiplacacao.Click += new System.EventHandler(this.button4_Click);
            // 
            // um
            // 
            this.um.BackColor = System.Drawing.SystemColors.ControlLight;
            this.um.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.um.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.um.Location = new System.Drawing.Point(41, 269);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(60, 60);
            this.um.TabIndex = 13;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = false;
            // 
            // dois
            // 
            this.dois.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dois.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dois.Location = new System.Drawing.Point(107, 269);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(60, 60);
            this.dois.TabIndex = 14;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = false;
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tres.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(173, 269);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(60, 60);
            this.tres.TabIndex = 15;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            // 
            // subtracacao
            // 
            this.subtracacao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subtracacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subtracacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracacao.Location = new System.Drawing.Point(239, 270);
            this.subtracacao.Name = "subtracacao";
            this.subtracacao.Size = new System.Drawing.Size(60, 60);
            this.subtracacao.TabIndex = 16;
            this.subtracacao.Text = "-";
            this.subtracacao.UseVisualStyleBackColor = false;
            // 
            // ponto
            // 
            this.ponto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ponto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto.Location = new System.Drawing.Point(41, 335);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(60, 60);
            this.ponto.TabIndex = 17;
            this.ponto.Text = ".";
            this.ponto.UseVisualStyleBackColor = false;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(107, 335);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(60, 60);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.igual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(173, 335);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(60, 60);
            this.igual.TabIndex = 19;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            // 
            // adicao
            // 
            this.adicao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.adicao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicao.Location = new System.Drawing.Point(239, 336);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(60, 60);
            this.adicao.TabIndex = 20;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.subtracacao);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.um);
            this.Controls.Add(this.multiplacacao);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.porcentagem);
            this.Controls.Add(this.visor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.Button porcentagem;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button multiplacacao;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button subtracacao;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button adicao;
    }
}

