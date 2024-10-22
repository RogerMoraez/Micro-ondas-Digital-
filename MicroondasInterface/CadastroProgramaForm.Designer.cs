using System.Windows.Forms;

namespace MicroondasInterface
{
    partial class CadastroProgramaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtStringAquecimento = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.lblNomeNovoCadastro = new System.Windows.Forms.Label();
            this.lblAlimentoNovoCadastro = new System.Windows.Forms.Label();
            this.lblTempoNovoCadastro = new System.Windows.Forms.Label();
            this.lblPotenciaNovoCadastro = new System.Windows.Forms.Label();
            this.lblInstrucoesNovoCadastro = new System.Windows.Forms.Label();
            this.txtInstrucoes = new System.Windows.Forms.TextBox();
            this.lblStringAquecimentoNovoCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(90, 62);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(100, 20);
            this.txtAlimento.TabIndex = 0;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(90, 114);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(100, 20);
            this.txtPotencia.TabIndex = 0;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
            // 
            // txtStringAquecimento
            // 
            this.txtStringAquecimento.Location = new System.Drawing.Point(90, 140);
            this.txtStringAquecimento.Name = "txtStringAquecimento";
            this.txtStringAquecimento.Size = new System.Drawing.Size(100, 20);
            this.txtStringAquecimento.TabIndex = 0;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(90, 88);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 0;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(90, 192);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(100, 29);
            this.bntSalvar.TabIndex = 1;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // lblNomeNovoCadastro
            // 
            this.lblNomeNovoCadastro.AutoSize = true;
            this.lblNomeNovoCadastro.Location = new System.Drawing.Point(49, 43);
            this.lblNomeNovoCadastro.Name = "lblNomeNovoCadastro";
            this.lblNomeNovoCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeNovoCadastro.TabIndex = 2;
            this.lblNomeNovoCadastro.Text = "Nome:";
            // 
            // lblAlimentoNovoCadastro
            // 
            this.lblAlimentoNovoCadastro.AutoSize = true;
            this.lblAlimentoNovoCadastro.Location = new System.Drawing.Point(40, 69);
            this.lblAlimentoNovoCadastro.Name = "lblAlimentoNovoCadastro";
            this.lblAlimentoNovoCadastro.Size = new System.Drawing.Size(47, 13);
            this.lblAlimentoNovoCadastro.TabIndex = 2;
            this.lblAlimentoNovoCadastro.Text = "Alimento";
            // 
            // lblTempoNovoCadastro
            // 
            this.lblTempoNovoCadastro.AutoSize = true;
            this.lblTempoNovoCadastro.Location = new System.Drawing.Point(44, 95);
            this.lblTempoNovoCadastro.Name = "lblTempoNovoCadastro";
            this.lblTempoNovoCadastro.Size = new System.Drawing.Size(43, 13);
            this.lblTempoNovoCadastro.TabIndex = 2;
            this.lblTempoNovoCadastro.Text = "Tempo:";
            // 
            // lblPotenciaNovoCadastro
            // 
            this.lblPotenciaNovoCadastro.AutoSize = true;
            this.lblPotenciaNovoCadastro.Location = new System.Drawing.Point(35, 121);
            this.lblPotenciaNovoCadastro.Name = "lblPotenciaNovoCadastro";
            this.lblPotenciaNovoCadastro.Size = new System.Drawing.Size(52, 13);
            this.lblPotenciaNovoCadastro.TabIndex = 2;
            this.lblPotenciaNovoCadastro.Text = "Potência ";
            // 
            // lblInstrucoesNovoCadastro
            // 
            this.lblInstrucoesNovoCadastro.AutoSize = true;
            this.lblInstrucoesNovoCadastro.Location = new System.Drawing.Point(28, 173);
            this.lblInstrucoesNovoCadastro.Name = "lblInstrucoesNovoCadastro";
            this.lblInstrucoesNovoCadastro.Size = new System.Drawing.Size(59, 26);
            this.lblInstrucoesNovoCadastro.TabIndex = 2;
            this.lblInstrucoesNovoCadastro.Text = "Instruções:\r\n(opcional)\r\n";
            // 
            // txtInstrucoes
            // 
            this.txtInstrucoes.Location = new System.Drawing.Point(90, 166);
            this.txtInstrucoes.Name = "txtInstrucoes";
            this.txtInstrucoes.Size = new System.Drawing.Size(100, 20);
            this.txtInstrucoes.TabIndex = 0;
            // 
            // lblStringAquecimentoNovoCadastro
            // 
            this.lblStringAquecimentoNovoCadastro.AutoSize = true;
            this.lblStringAquecimentoNovoCadastro.Location = new System.Drawing.Point(37, 147);
            this.lblStringAquecimentoNovoCadastro.Name = "lblStringAquecimentoNovoCadastro";
            this.lblStringAquecimentoNovoCadastro.Size = new System.Drawing.Size(50, 13);
            this.lblStringAquecimentoNovoCadastro.TabIndex = 2;
            this.lblStringAquecimentoNovoCadastro.Text = "Caracter:";
            // 
            // CadastroProgramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 270);
            this.Controls.Add(this.lblStringAquecimentoNovoCadastro);
            this.Controls.Add(this.lblInstrucoesNovoCadastro);
            this.Controls.Add(this.lblPotenciaNovoCadastro);
            this.Controls.Add(this.lblTempoNovoCadastro);
            this.Controls.Add(this.lblAlimentoNovoCadastro);
            this.Controls.Add(this.lblNomeNovoCadastro);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtInstrucoes);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtStringAquecimento);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.txtNome);
            this.Name = "CadastroProgramaForm";
            this.Text = "Cadastrar Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtStringAquecimento;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Label lblNomeNovoCadastro;
        private System.Windows.Forms.Label lblAlimentoNovoCadastro;
        private System.Windows.Forms.Label lblTempoNovoCadastro;
        private System.Windows.Forms.Label lblPotenciaNovoCadastro;
        private System.Windows.Forms.Label lblInstrucoesNovoCadastro;
        private System.Windows.Forms.TextBox txtInstrucoes;
        private System.Windows.Forms.Label lblStringAquecimentoNovoCadastro;
    }
}