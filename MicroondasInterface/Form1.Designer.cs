using System.Windows.Forms;

namespace MicroondasInterface
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
            this.bntIniciorapidoAcrecentartempo = new System.Windows.Forms.Button();
            this.bntIniciarRetomar = new System.Windows.Forms.Button();
            this.bntPauseCancelar = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntIntrucoesCarneDeBoi = new System.Windows.Forms.Button();
            this.bntIntrucoesFrango = new System.Windows.Forms.Button();
            this.bntIntrucoesFeijao = new System.Windows.Forms.Button();
            this.bntIntrucoesPipoca = new System.Windows.Forms.Button();
            this.bntIntrucoesProgramaCadastrado5 = new System.Windows.Forms.Button();
            this.bntIntrucoesProgramaCadastrado4 = new System.Windows.Forms.Button();
            this.bntIntrucoesProgramaCadastrado3 = new System.Windows.Forms.Button();
            this.bntIntrucoesProgramaCadastrado2 = new System.Windows.Forms.Button();
            this.bntIntrucoesProgramaCadastrado1 = new System.Windows.Forms.Button();
            this.btnInstrucoesLeite = new System.Windows.Forms.Button();
            this.btnCadastrarPrograma4 = new System.Windows.Forms.Button();
            this.btnCadastrarPrograma5 = new System.Windows.Forms.Button();
            this.btnCadastrarPrograma3 = new System.Windows.Forms.Button();
            this.btnCadastrarPrograma2 = new System.Windows.Forms.Button();
            this.btnCadastrarPrograma1 = new System.Windows.Forms.Button();
            this.lblInformacoesCarneDeBoi = new System.Windows.Forms.Label();
            this.lblInformacoesFrango = new System.Windows.Forms.Label();
            this.lblInformacoesFeijao = new System.Windows.Forms.Label();
            this.lblInformacoesPipoca = new System.Windows.Forms.Label();
            this.lblInformacoesLeite = new System.Windows.Forms.Label();
            this.bntCarneDeBoi = new System.Windows.Forms.Button();
            this.bntFrango = new System.Windows.Forms.Button();
            this.bntFeijao = new System.Windows.Forms.Button();
            this.bntPipoca = new System.Windows.Forms.Button();
            this.bntLeite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntIniciorapidoAcrecentartempo
            // 
            this.bntIniciorapidoAcrecentartempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntIniciorapidoAcrecentartempo.Location = new System.Drawing.Point(380, 204);
            this.bntIniciorapidoAcrecentartempo.Name = "bntIniciorapidoAcrecentartempo";
            this.bntIniciorapidoAcrecentartempo.Size = new System.Drawing.Size(85, 73);
            this.bntIniciorapidoAcrecentartempo.TabIndex = 0;
            this.bntIniciorapidoAcrecentartempo.Text = "Inicio Rápido\r\n+30seg.\r\n";
            this.bntIniciorapidoAcrecentartempo.UseVisualStyleBackColor = true;
            this.bntIniciorapidoAcrecentartempo.Click += new System.EventHandler(this.bntIniciorapidoAcrecentartempo_Click);
            // 
            // bntIniciarRetomar
            // 
            this.bntIniciarRetomar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntIniciarRetomar.BackColor = System.Drawing.Color.LightGreen;
            this.bntIniciarRetomar.Location = new System.Drawing.Point(471, 204);
            this.bntIniciarRetomar.Name = "bntIniciarRetomar";
            this.bntIniciarRetomar.Size = new System.Drawing.Size(99, 32);
            this.bntIniciarRetomar.TabIndex = 0;
            this.bntIniciarRetomar.Text = "Iniciar/Retomar";
            this.bntIniciarRetomar.UseVisualStyleBackColor = false;
            this.bntIniciarRetomar.Click += new System.EventHandler(this.bntIniciarRetomar_Click);
            // 
            // bntPauseCancelar
            // 
            this.bntPauseCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPauseCancelar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bntPauseCancelar.Location = new System.Drawing.Point(471, 245);
            this.bntPauseCancelar.Name = "bntPauseCancelar";
            this.bntPauseCancelar.Size = new System.Drawing.Size(99, 32);
            this.bntPauseCancelar.TabIndex = 0;
            this.bntPauseCancelar.Text = "Pausar/Cancelar";
            this.bntPauseCancelar.UseVisualStyleBackColor = false;
            this.bntPauseCancelar.Click += new System.EventHandler(this.bntPauseCancelar_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTempo.Location = new System.Drawing.Point(434, 122);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(82, 20);
            this.txtTempo.TabIndex = 1;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPotencia.Location = new System.Drawing.Point(434, 148);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(82, 20);
            this.txtPotencia.TabIndex = 1;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tempo";
            // 
            // lab2
            // 
            this.lab2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(377, 155);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(52, 13);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Potência ";
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(522, 129);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(28, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "0:00";
            // 
            // lblPotencia
            // 
            this.lblPotencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(522, 151);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(19, 13);
            this.lblPotencia.TabIndex = 2;
            this.lblPotencia.Text = "10";
            // 
            // lblProgresso
            // 
            this.lblProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(431, 177);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(19, 13);
            this.lblProgresso.TabIndex = 3;
            this.lblProgresso.Text = "    ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.bntIntrucoesCarneDeBoi);
            this.panel1.Controls.Add(this.bntIntrucoesFrango);
            this.panel1.Controls.Add(this.bntIntrucoesFeijao);
            this.panel1.Controls.Add(this.bntIntrucoesPipoca);
            this.panel1.Controls.Add(this.bntIntrucoesProgramaCadastrado5);
            this.panel1.Controls.Add(this.bntIntrucoesProgramaCadastrado4);
            this.panel1.Controls.Add(this.bntIntrucoesProgramaCadastrado3);
            this.panel1.Controls.Add(this.bntIntrucoesProgramaCadastrado2);
            this.panel1.Controls.Add(this.bntIntrucoesProgramaCadastrado1);
            this.panel1.Controls.Add(this.btnInstrucoesLeite);
            this.panel1.Controls.Add(this.btnCadastrarPrograma4);
            this.panel1.Controls.Add(this.btnCadastrarPrograma5);
            this.panel1.Controls.Add(this.btnCadastrarPrograma3);
            this.panel1.Controls.Add(this.btnCadastrarPrograma2);
            this.panel1.Controls.Add(this.btnCadastrarPrograma1);
            this.panel1.Controls.Add(this.lblInformacoesCarneDeBoi);
            this.panel1.Controls.Add(this.lblInformacoesFrango);
            this.panel1.Controls.Add(this.lblInformacoesFeijao);
            this.panel1.Controls.Add(this.lblInformacoesPipoca);
            this.panel1.Controls.Add(this.lblInformacoesLeite);
            this.panel1.Controls.Add(this.bntCarneDeBoi);
            this.panel1.Controls.Add(this.bntFrango);
            this.panel1.Controls.Add(this.bntFeijao);
            this.panel1.Controls.Add(this.bntPipoca);
            this.panel1.Controls.Add(this.bntLeite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 337);
            this.panel1.TabIndex = 4;
            // 
            // bntIntrucoesCarneDeBoi
            // 
            this.bntIntrucoesCarneDeBoi.Location = new System.Drawing.Point(88, 311);
            this.bntIntrucoesCarneDeBoi.Name = "bntIntrucoesCarneDeBoi";
            this.bntIntrucoesCarneDeBoi.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesCarneDeBoi.TabIndex = 6;
            this.bntIntrucoesCarneDeBoi.Text = "Instruções";
            this.bntIntrucoesCarneDeBoi.UseVisualStyleBackColor = true;
            this.bntIntrucoesCarneDeBoi.Click += new System.EventHandler(this.bntIntrucoesCarneDeBoi_Click);
            // 
            // bntIntrucoesFrango
            // 
            this.bntIntrucoesFrango.Location = new System.Drawing.Point(88, 245);
            this.bntIntrucoesFrango.Name = "bntIntrucoesFrango";
            this.bntIntrucoesFrango.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesFrango.TabIndex = 6;
            this.bntIntrucoesFrango.Text = "Instruções";
            this.bntIntrucoesFrango.UseVisualStyleBackColor = true;
            this.bntIntrucoesFrango.Click += new System.EventHandler(this.bntIntrucoesFrango_Click);
            // 
            // bntIntrucoesFeijao
            // 
            this.bntIntrucoesFeijao.Location = new System.Drawing.Point(88, 177);
            this.bntIntrucoesFeijao.Name = "bntIntrucoesFeijao";
            this.bntIntrucoesFeijao.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesFeijao.TabIndex = 6;
            this.bntIntrucoesFeijao.Text = "Instruções";
            this.bntIntrucoesFeijao.UseVisualStyleBackColor = true;
            this.bntIntrucoesFeijao.Click += new System.EventHandler(this.bntIntrucoesFeijao_Click);
            // 
            // bntIntrucoesPipoca
            // 
            this.bntIntrucoesPipoca.Location = new System.Drawing.Point(88, 111);
            this.bntIntrucoesPipoca.Name = "bntIntrucoesPipoca";
            this.bntIntrucoesPipoca.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesPipoca.TabIndex = 6;
            this.bntIntrucoesPipoca.Text = "Instruções";
            this.bntIntrucoesPipoca.UseVisualStyleBackColor = true;
            this.bntIntrucoesPipoca.Click += new System.EventHandler(this.bntIntrucoesPipoca_Click);
            // 
            // bntIntrucoesProgramaCadastrado5
            // 
            this.bntIntrucoesProgramaCadastrado5.Location = new System.Drawing.Point(269, 311);
            this.bntIntrucoesProgramaCadastrado5.Name = "bntIntrucoesProgramaCadastrado5";
            this.bntIntrucoesProgramaCadastrado5.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesProgramaCadastrado5.TabIndex = 6;
            this.bntIntrucoesProgramaCadastrado5.Text = "Instruções";
            this.bntIntrucoesProgramaCadastrado5.UseVisualStyleBackColor = true;
            this.bntIntrucoesProgramaCadastrado5.Click += new System.EventHandler(this.btnInstrucoesLeite_Click);
            // 
            // bntIntrucoesProgramaCadastrado4
            // 
            this.bntIntrucoesProgramaCadastrado4.Location = new System.Drawing.Point(269, 245);
            this.bntIntrucoesProgramaCadastrado4.Name = "bntIntrucoesProgramaCadastrado4";
            this.bntIntrucoesProgramaCadastrado4.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesProgramaCadastrado4.TabIndex = 6;
            this.bntIntrucoesProgramaCadastrado4.Text = "Instruções";
            this.bntIntrucoesProgramaCadastrado4.UseVisualStyleBackColor = true;
            this.bntIntrucoesProgramaCadastrado4.Click += new System.EventHandler(this.btnInstrucoesLeite_Click);
            // 
            // bntIntrucoesProgramaCadastrado3
            // 
            this.bntIntrucoesProgramaCadastrado3.Location = new System.Drawing.Point(269, 177);
            this.bntIntrucoesProgramaCadastrado3.Name = "bntIntrucoesProgramaCadastrado3";
            this.bntIntrucoesProgramaCadastrado3.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesProgramaCadastrado3.TabIndex = 6;
            this.bntIntrucoesProgramaCadastrado3.Text = "Instruções";
            this.bntIntrucoesProgramaCadastrado3.UseVisualStyleBackColor = true;
            this.bntIntrucoesProgramaCadastrado3.Click += new System.EventHandler(this.btnInstrucoesLeite_Click);
            // 
            // bntIntrucoesProgramaCadastrado2
            // 
            this.bntIntrucoesProgramaCadastrado2.Location = new System.Drawing.Point(269, 109);
            this.bntIntrucoesProgramaCadastrado2.Name = "bntIntrucoesProgramaCadastrado2";
            this.bntIntrucoesProgramaCadastrado2.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesProgramaCadastrado2.TabIndex = 6;
            this.bntIntrucoesProgramaCadastrado2.Text = "Instruções";
            this.bntIntrucoesProgramaCadastrado2.UseVisualStyleBackColor = true;
            this.bntIntrucoesProgramaCadastrado2.Click += new System.EventHandler(this.btnInstrucoesLeite_Click);
            // 
            // bntIntrucoesProgramaCadastrado1
            // 
            this.bntIntrucoesProgramaCadastrado1.Location = new System.Drawing.Point(269, 41);
            this.bntIntrucoesProgramaCadastrado1.Name = "bntIntrucoesProgramaCadastrado1";
            this.bntIntrucoesProgramaCadastrado1.Size = new System.Drawing.Size(75, 23);
            this.bntIntrucoesProgramaCadastrado1.TabIndex = 6;
            this.bntIntrucoesProgramaCadastrado1.Text = "Instruções";
            this.bntIntrucoesProgramaCadastrado1.UseVisualStyleBackColor = true;
            this.bntIntrucoesProgramaCadastrado1.Click += new System.EventHandler(this.btnInstrucoesLeite_Click);
            // 
            // btnInstrucoesLeite
            // 
            this.btnInstrucoesLeite.Location = new System.Drawing.Point(88, 41);
            this.btnInstrucoesLeite.Name = "btnInstrucoesLeite";
            this.btnInstrucoesLeite.Size = new System.Drawing.Size(75, 23);
            this.btnInstrucoesLeite.TabIndex = 6;
            this.btnInstrucoesLeite.Text = "Instruções";
            this.btnInstrucoesLeite.UseVisualStyleBackColor = true;
            this.btnInstrucoesLeite.Click += new System.EventHandler(this.btnInstrucoesLeite_Click);
            // 
            // btnCadastrarPrograma4
            // 
            this.btnCadastrarPrograma4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPrograma4.Location = new System.Drawing.Point(181, 204);
            this.btnCadastrarPrograma4.Name = "btnCadastrarPrograma4";
            this.btnCadastrarPrograma4.Size = new System.Drawing.Size(82, 62);
            this.btnCadastrarPrograma4.TabIndex = 1;
            this.btnCadastrarPrograma4.Text = "Cadastrar Alimento";
            this.btnCadastrarPrograma4.UseVisualStyleBackColor = true;
            this.btnCadastrarPrograma4.Click += new System.EventHandler(this.btnCadastrarPrograma4_Click);
            // 
            // btnCadastrarPrograma5
            // 
            this.btnCadastrarPrograma5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPrograma5.Location = new System.Drawing.Point(181, 270);
            this.btnCadastrarPrograma5.Name = "btnCadastrarPrograma5";
            this.btnCadastrarPrograma5.Size = new System.Drawing.Size(82, 62);
            this.btnCadastrarPrograma5.TabIndex = 1;
            this.btnCadastrarPrograma5.Text = "Cadastrar Alimento";
            this.btnCadastrarPrograma5.UseVisualStyleBackColor = true;
            this.btnCadastrarPrograma5.Click += new System.EventHandler(this.btnCadastrarPrograma5_Click);
            // 
            // btnCadastrarPrograma3
            // 
            this.btnCadastrarPrograma3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPrograma3.Location = new System.Drawing.Point(181, 138);
            this.btnCadastrarPrograma3.Name = "btnCadastrarPrograma3";
            this.btnCadastrarPrograma3.Size = new System.Drawing.Size(82, 62);
            this.btnCadastrarPrograma3.TabIndex = 1;
            this.btnCadastrarPrograma3.Text = "Cadastrar Alimento";
            this.btnCadastrarPrograma3.UseVisualStyleBackColor = true;
            this.btnCadastrarPrograma3.Click += new System.EventHandler(this.btnCadastrarPrograma3_Click);
            // 
            // btnCadastrarPrograma2
            // 
            this.btnCadastrarPrograma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPrograma2.Location = new System.Drawing.Point(181, 70);
            this.btnCadastrarPrograma2.Name = "btnCadastrarPrograma2";
            this.btnCadastrarPrograma2.Size = new System.Drawing.Size(82, 62);
            this.btnCadastrarPrograma2.TabIndex = 1;
            this.btnCadastrarPrograma2.Text = "Cadastrar Alimento";
            this.btnCadastrarPrograma2.UseVisualStyleBackColor = true;
            this.btnCadastrarPrograma2.Click += new System.EventHandler(this.btnCadastrarPrograma2_Click);
            // 
            // btnCadastrarPrograma1
            // 
            this.btnCadastrarPrograma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPrograma1.Location = new System.Drawing.Point(181, 3);
            this.btnCadastrarPrograma1.Name = "btnCadastrarPrograma1";
            this.btnCadastrarPrograma1.Size = new System.Drawing.Size(82, 61);
            this.btnCadastrarPrograma1.TabIndex = 0;
            this.btnCadastrarPrograma1.Text = "Cadastrar Alimento";
            this.btnCadastrarPrograma1.UseVisualStyleBackColor = true;
            this.btnCadastrarPrograma1.Click += new System.EventHandler(this.btnCadastrarPrograma1_Click);
            // 
            // lblInformacoesCarneDeBoi
            // 
            this.lblInformacoesCarneDeBoi.AutoSize = true;
            this.lblInformacoesCarneDeBoi.Location = new System.Drawing.Point(88, 282);
            this.lblInformacoesCarneDeBoi.Name = "lblInformacoesCarneDeBoi";
            this.lblInformacoesCarneDeBoi.Size = new System.Drawing.Size(93, 26);
            this.lblInformacoesCarneDeBoi.TabIndex = 5;
            this.lblInformacoesCarneDeBoi.Text = "tempo: 14 minutos\r\npotência 4\r\n";
            // 
            // lblInformacoesFrango
            // 
            this.lblInformacoesFrango.AutoSize = true;
            this.lblInformacoesFrango.Location = new System.Drawing.Point(88, 214);
            this.lblInformacoesFrango.Name = "lblInformacoesFrango";
            this.lblInformacoesFrango.Size = new System.Drawing.Size(87, 26);
            this.lblInformacoesFrango.TabIndex = 5;
            this.lblInformacoesFrango.Text = "tempo: 8 minutos\r\npotência: 7";
            // 
            // lblInformacoesFeijao
            // 
            this.lblInformacoesFeijao.AutoSize = true;
            this.lblInformacoesFeijao.Location = new System.Drawing.Point(85, 148);
            this.lblInformacoesFeijao.Name = "lblInformacoesFeijao";
            this.lblInformacoesFeijao.Size = new System.Drawing.Size(87, 26);
            this.lblInformacoesFeijao.TabIndex = 5;
            this.lblInformacoesFeijao.Text = "tempo: 8 minutos\r\npotência 9";
            // 
            // lblInformacoesPipoca
            // 
            this.lblInformacoesPipoca.AutoSize = true;
            this.lblInformacoesPipoca.Location = new System.Drawing.Point(85, 82);
            this.lblInformacoesPipoca.Name = "lblInformacoesPipoca";
            this.lblInformacoesPipoca.Size = new System.Drawing.Size(90, 26);
            this.lblInformacoesPipoca.TabIndex = 5;
            this.lblInformacoesPipoca.Text = "tempo: 3 minutos \r\npotência: 7";
            // 
            // lblInformacoesLeite
            // 
            this.lblInformacoesLeite.AutoSize = true;
            this.lblInformacoesLeite.Location = new System.Drawing.Point(88, 9);
            this.lblInformacoesLeite.Name = "lblInformacoesLeite";
            this.lblInformacoesLeite.Size = new System.Drawing.Size(87, 26);
            this.lblInformacoesLeite.TabIndex = 5;
            this.lblInformacoesLeite.Text = "tempo: 5 minutos\r\npotência: 5";
            this.lblInformacoesLeite.UseWaitCursor = true;
            // 
            // bntCarneDeBoi
            // 
            this.bntCarneDeBoi.Location = new System.Drawing.Point(3, 273);
            this.bntCarneDeBoi.Name = "bntCarneDeBoi";
            this.bntCarneDeBoi.Size = new System.Drawing.Size(82, 62);
            this.bntCarneDeBoi.TabIndex = 5;
            this.bntCarneDeBoi.Text = "Carne de Boi";
            this.bntCarneDeBoi.UseVisualStyleBackColor = true;
            this.bntCarneDeBoi.Click += new System.EventHandler(this.bntCarneDeBoi_Click);
            // 
            // bntFrango
            // 
            this.bntFrango.Location = new System.Drawing.Point(3, 206);
            this.bntFrango.Name = "bntFrango";
            this.bntFrango.Size = new System.Drawing.Size(82, 62);
            this.bntFrango.TabIndex = 5;
            this.bntFrango.Text = "Frango";
            this.bntFrango.UseVisualStyleBackColor = true;
            this.bntFrango.Click += new System.EventHandler(this.bntFrango_Click);
            // 
            // bntFeijao
            // 
            this.bntFeijao.Location = new System.Drawing.Point(3, 138);
            this.bntFeijao.Name = "bntFeijao";
            this.bntFeijao.Size = new System.Drawing.Size(82, 62);
            this.bntFeijao.TabIndex = 5;
            this.bntFeijao.Text = "Feijão";
            this.bntFeijao.UseVisualStyleBackColor = true;
            this.bntFeijao.Click += new System.EventHandler(this.bntFeijao_Click);
            // 
            // bntPipoca
            // 
            this.bntPipoca.Location = new System.Drawing.Point(3, 70);
            this.bntPipoca.Name = "bntPipoca";
            this.bntPipoca.Size = new System.Drawing.Size(82, 62);
            this.bntPipoca.TabIndex = 5;
            this.bntPipoca.Text = "Pipoca";
            this.bntPipoca.UseVisualStyleBackColor = true;
            this.bntPipoca.Click += new System.EventHandler(this.bntPipoca_Click);
            // 
            // bntLeite
            // 
            this.bntLeite.Location = new System.Drawing.Point(3, 2);
            this.bntLeite.Name = "bntLeite";
            this.bntLeite.Size = new System.Drawing.Size(82, 62);
            this.bntLeite.TabIndex = 5;
            this.bntLeite.Text = "Leite";
            this.bntLeite.UseVisualStyleBackColor = true;
            this.bntLeite.Click += new System.EventHandler(this.bntLeite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.bntPauseCancelar);
            this.Controls.Add(this.bntIniciarRetomar);
            this.Controls.Add(this.bntIniciorapidoAcrecentartempo);
            this.Name = "Form1";
            this.Text = "Micro-ondas Digital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntIniciorapidoAcrecentartempo;
        private System.Windows.Forms.Button bntIniciarRetomar;
        private System.Windows.Forms.Button bntPauseCancelar;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblProgresso;
        private Panel panel1;
        private Button bntCarneDeBoi;
        private Button bntFrango;
        private Button bntFeijao;
        private Button bntPipoca;
        private Button bntLeite;
        private Label lblInformacoesCarneDeBoi;
        private Label lblInformacoesFrango;
        private Label lblInformacoesFeijao;
        private Label lblInformacoesPipoca;
        private Label lblInformacoesLeite;
        private Button btnCadastrarPrograma1;
        private Button btnCadastrarPrograma2;
        private Button btnCadastrarPrograma4;
        private Button btnCadastrarPrograma5;
        private Button btnCadastrarPrograma3;
        private Button btnInstrucoesLeite;
        private Button bntIntrucoesCarneDeBoi;
        private Button bntIntrucoesFrango;
        private Button bntIntrucoesFeijao;
        private Button bntIntrucoesPipoca;
        private Button bntIntrucoesProgramaCadastrado5;
        private Button bntIntrucoesProgramaCadastrado4;
        private Button bntIntrucoesProgramaCadastrado3;
        private Button bntIntrucoesProgramaCadastrado2;
        private Button bntIntrucoesProgramaCadastrado1;
    }
}

