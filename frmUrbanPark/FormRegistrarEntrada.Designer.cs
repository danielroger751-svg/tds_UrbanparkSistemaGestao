namespace frmUrbanPark
{
    partial class FrmRegistrarEntrada
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
            grpBuscarVeiculo = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            btnBuscarPorPlaca = new Button();
            grpMovimentacao = new GroupBox();
            dtInfoDtEntrada = new DateTimePicker();
            dtInfoHrEntrada = new DateTimePicker();
            lblDataEntrada = new Label();
            lblVagaSelecionada = new Label();
            lblHoraEntrada = new Label();
            txtVagaSelecionada = new TextBox();
            grpDadosVeiculo = new GroupBox();
            txtCorModelo = new TextBox();
            txtNomeCliente = new TextBox();
            lblCorModelo = new Label();
            lblCliente = new Label();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            BannerEntrada = new PictureBox();
            grpBuscarVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerEntrada).BeginInit();
            SuspendLayout();
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(maskedTextBox1);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grpBuscarVeiculo.Location = new Point(20, 103);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(756, 100);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(157, 38);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(133, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = SystemColors.Desktop;
            lblPlacaVeiculo.Location = new Point(26, 41);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(108, 17);
            lblPlacaVeiculo.TabIndex = 1;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Segoe UI", 9.75F);
            btnBuscarPorPlaca.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarPorPlaca.Image = Properties.Resources.IcoPesquisaAzul;
            btnBuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.Location = new Point(365, 38);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(158, 30);
            btnBuscarPorPlaca.TabIndex = 0;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = SystemColors.HotTrack;
            grpMovimentacao.Location = new Point(428, 225);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(348, 152);
            grpMovimentacao.TabIndex = 2;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(150, 70);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(167, 20);
            dtInfoDtEntrada.TabIndex = 4;
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CustomFormat = "HH:mm";
            dtInfoHrEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoHrEntrada.Location = new Point(150, 103);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(114, 20);
            dtInfoHrEntrada.TabIndex = 3;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = SystemColors.Desktop;
            lblDataEntrada.Location = new Point(15, 72);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(109, 17);
            lblDataEntrada.TabIndex = 0;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVagaSelecionada.ForeColor = SystemColors.Desktop;
            lblVagaSelecionada.Location = new Point(15, 38);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(115, 17);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = SystemColors.Desktop;
            lblHoraEntrada.Location = new Point(15, 104);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(111, 17);
            lblHoraEntrada.TabIndex = 0;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.BackColor = SystemColors.ScrollBar;
            txtVagaSelecionada.Location = new Point(150, 35);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(167, 25);
            txtVagaSelecionada.TabIndex = 1;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = SystemColors.HotTrack;
            grpDadosVeiculo.Location = new Point(20, 225);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(375, 152);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtCorModelo
            // 
            txtCorModelo.BackColor = SystemColors.ScrollBar;
            txtCorModelo.Location = new Point(133, 78);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(200, 25);
            txtCorModelo.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.ScrollBar;
            txtNomeCliente.Location = new Point(133, 35);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(200, 25);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = SystemColors.Desktop;
            lblCorModelo.Location = new Point(15, 78);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(91, 17);
            lblCorModelo.TabIndex = 0;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.Desktop;
            lblCliente.Location = new Point(15, 38);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 17);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(223, 247, 231);
            btnRegistrarEntrada.Image = Properties.Resources.icoConfirmado;
            btnRegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntrada.Location = new Point(526, 15);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(148, 23);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(254, 224, 221);
            btnCancelar.Image = Properties.Resources.IcoCancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(680, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrarEntrada);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 7;
            // 
            // BannerEntrada
            // 
            BannerEntrada.Dock = DockStyle.Top;
            BannerEntrada.Image = Properties.Resources.RegistrarEntrada3;
            BannerEntrada.Location = new Point(0, 0);
            BannerEntrada.Name = "BannerEntrada";
            BannerEntrada.Size = new Size(800, 86);
            BannerEntrada.SizeMode = PictureBoxSizeMode.StretchImage;
            BannerEntrada.TabIndex = 6;
            BannerEntrada.TabStop = false;
            // 
            // FrmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BannerEntrada);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpBuscarVeiculo);
            Name = "FrmRegistrarEntrada";
            Text = "Registrar Entrada";
            Load += FrmRegistrarEntrada_Load;
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BannerEntrada).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpBuscarVeiculo;
        private GroupBox grpMovimentacao;
        private GroupBox grpDadosVeiculo;
        private Button btnBuscarPorPlaca;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private Label lblPlacaVeiculo;
        private MaskedTextBox maskedTextBox1;
        private Label lblCliente;
        private TextBox txtNomeCliente;
        private TextBox txtCorModelo;
        private Label lblCorModelo;
        private Label lblDataEntrada;
        private Label lblVagaSelecionada;
        private TextBox txtVagaSelecionada;
        private DateTimePicker dtInfoDtEntrada;
        private DateTimePicker dtInfoHrEntrada;
        private Label lblHoraEntrada;
        private Panel panel1;
        private PictureBox BannerEntrada;
    }
}