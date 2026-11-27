namespace frmUrbanPark
{
    partial class FrmRegistrarSaida
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
            panel1 = new Panel();
            btnRegistrarSaida = new Button();
            btnCancelar = new Button();
            lblCorModelo = new Label();
            lblCliente = new Label();
            dtInfoHrEntrada = new DateTimePicker();
            txtCorModelo = new TextBox();
            txtNomeCliente = new TextBox();
            lblDataSaida = new Label();
            grpMovimentacao = new GroupBox();
            grpCalculo = new GroupBox();
            lblValorPagar = new Label();
            txtValorAPagar = new TextBox();
            txtInfoTarifa = new TextBox();
            txtInfoTempoPermanencia = new TextBox();
            lblTarifaVigente = new Label();
            lblTempoPermanencia = new Label();
            dtInfoDtEntrada = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblDataHoraEntrada = new Label();
            lblHoraSaida = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            btnBuscarPorPlaca = new Button();
            grpDadosVeiculo = new GroupBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            lblVaga = new Label();
            lblPlaca = new Label();
            grpBuscarVeiculo = new GroupBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpCalculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpBuscarVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnRegistrarSaida);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 12;
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.BackColor = Color.FromArgb(223, 247, 231);
            btnRegistrarSaida.FlatStyle = FlatStyle.Popup;
            btnRegistrarSaida.Image = Properties.Resources.icoConfirmado;
            btnRegistrarSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarSaida.Location = new Point(486, 15);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(148, 32);
            btnRegistrarSaida.TabIndex = 4;
            btnRegistrarSaida.Text = "Registrar Saida";
            btnRegistrarSaida.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(254, 224, 221);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.IcoCancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(674, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = SystemColors.Desktop;
            lblCorModelo.Location = new Point(10, 92);
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
            lblCliente.Location = new Point(10, 26);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 17);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CustomFormat = "HH:mm";
            dtInfoHrEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Short;
            dtInfoHrEntrada.Location = new Point(115, 58);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(90, 20);
            dtInfoHrEntrada.TabIndex = 3;
            // 
            // txtCorModelo
            // 
            txtCorModelo.BackColor = SystemColors.ScrollBar;
            txtCorModelo.Location = new Point(112, 88);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(200, 25);
            txtCorModelo.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.ScrollBar;
            txtNomeCliente.Location = new Point(112, 23);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(200, 25);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataSaida.ForeColor = SystemColors.Desktop;
            lblDataSaida.Location = new Point(5, 57);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(94, 17);
            lblDataSaida.TabIndex = 0;
            lblDataSaida.Text = "Data de Saída:";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(grpCalculo);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(dateTimePicker1);
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Controls.Add(lblDataHoraEntrada);
            grpMovimentacao.Controls.Add(lblHoraSaida);
            grpMovimentacao.Controls.Add(lblDataSaida);
            grpMovimentacao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = SystemColors.HotTrack;
            grpMovimentacao.Location = new Point(353, 169);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(424, 212);
            grpMovimentacao.TabIndex = 9;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(lblValorPagar);
            grpCalculo.Controls.Add(txtValorAPagar);
            grpCalculo.Controls.Add(txtInfoTarifa);
            grpCalculo.Controls.Add(txtInfoTempoPermanencia);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Controls.Add(lblTempoPermanencia);
            grpCalculo.ForeColor = SystemColors.HotTrack;
            grpCalculo.Location = new Point(0, 89);
            grpCalculo.Margin = new Padding(3, 2, 3, 2);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Padding = new Padding(3, 2, 3, 2);
            grpCalculo.Size = new Size(424, 123);
            grpCalculo.TabIndex = 5;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Cálculo do Estacionamento";
            // 
            // lblValorPagar
            // 
            lblValorPagar.AutoSize = true;
            lblValorPagar.BackColor = Color.Green;
            lblValorPagar.ForeColor = Color.White;
            lblValorPagar.Location = new Point(10, 89);
            lblValorPagar.Name = "lblValorPagar";
            lblValorPagar.Size = new Size(92, 17);
            lblValorPagar.TabIndex = 3;
            lblValorPagar.Text = "Valor a Pagar:";
            // 
            // txtValorAPagar
            // 
            txtValorAPagar.BackColor = Color.Green;
            txtValorAPagar.Location = new Point(6, 83);
            txtValorAPagar.Margin = new Padding(3, 2, 3, 2);
            txtValorAPagar.Multiline = true;
            txtValorAPagar.Name = "txtValorAPagar";
            txtValorAPagar.Size = new Size(405, 30);
            txtValorAPagar.TabIndex = 2;
            txtValorAPagar.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInfoTarifa
            // 
            txtInfoTarifa.BackColor = SystemColors.ScrollBar;
            txtInfoTarifa.ForeColor = SystemColors.ScrollBar;
            txtInfoTarifa.Location = new Point(189, 54);
            txtInfoTarifa.Margin = new Padding(3, 2, 3, 2);
            txtInfoTarifa.Name = "txtInfoTarifa";
            txtInfoTarifa.ReadOnly = true;
            txtInfoTarifa.Size = new Size(184, 25);
            txtInfoTarifa.TabIndex = 1;
            // 
            // txtInfoTempoPermanencia
            // 
            txtInfoTempoPermanencia.BackColor = SystemColors.ScrollBar;
            txtInfoTempoPermanencia.ForeColor = SystemColors.ScrollBar;
            txtInfoTempoPermanencia.Location = new Point(189, 24);
            txtInfoTempoPermanencia.Margin = new Padding(3, 2, 3, 2);
            txtInfoTempoPermanencia.Name = "txtInfoTempoPermanencia";
            txtInfoTempoPermanencia.ReadOnly = true;
            txtInfoTempoPermanencia.Size = new Size(184, 25);
            txtInfoTempoPermanencia.TabIndex = 1;
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaVigente.ForeColor = SystemColors.Desktop;
            lblTarifaVigente.Location = new Point(6, 54);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(93, 17);
            lblTarifaVigente.TabIndex = 0;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // lblTempoPermanencia
            // 
            lblTempoPermanencia.AutoSize = true;
            lblTempoPermanencia.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempoPermanencia.ForeColor = SystemColors.Desktop;
            lblTempoPermanencia.Location = new Point(5, 23);
            lblTempoPermanencia.Name = "lblTempoPermanencia";
            lblTempoPermanencia.Size = new Size(153, 17);
            lblTempoPermanencia.TabIndex = 0;
            lblTempoPermanencia.Text = "Tempo de Permanência:";
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
            dtInfoDtEntrada.Font = new Font("Microsoft Sans Serif", 8.25F);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoDtEntrada.Location = new Point(173, 28);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(169, 20);
            dtInfoDtEntrada.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(321, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(90, 20);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblDataHoraEntrada
            // 
            lblDataHoraEntrada.AutoSize = true;
            lblDataHoraEntrada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataHoraEntrada.ForeColor = SystemColors.Desktop;
            lblDataHoraEntrada.Location = new Point(5, 26);
            lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            lblDataHoraEntrada.Size = new Size(152, 17);
            lblDataHoraEntrada.TabIndex = 0;
            lblDataHoraEntrada.Text = "Data / Hora de Entrada:";
            // 
            // lblHoraSaida
            // 
            lblHoraSaida.AutoSize = true;
            lblHoraSaida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraSaida.ForeColor = SystemColors.Desktop;
            lblHoraSaida.Location = new Point(209, 57);
            lblHoraSaida.Name = "lblHoraSaida";
            lblHoraSaida.Size = new Size(96, 17);
            lblHoraSaida.TabIndex = 0;
            lblHoraSaida.Text = "Hora de Saída:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(153, 23);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(133, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = SystemColors.Desktop;
            lblPlacaVeiculo.Location = new Point(26, 26);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(108, 17);
            lblPlacaVeiculo.TabIndex = 1;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.BackColor = Color.White;
            btnBuscarPorPlaca.Font = new Font("Segoe UI", 9.75F);
            btnBuscarPorPlaca.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarPorPlaca.Image = Properties.Resources.IcoPesquisaAzul;
            btnBuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.Location = new Point(364, 21);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(158, 31);
            btnBuscarPorPlaca.TabIndex = 0;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarPorPlaca.UseVisualStyleBackColor = false;
            btnBuscarPorPlaca.Click += btnBuscarPorPlaca_Click;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(textBox2);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(textBox4);
            grpDadosVeiculo.Controls.Add(textBox1);
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = SystemColors.HotTrack;
            grpDadosVeiculo.Location = new Point(20, 169);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(327, 212);
            grpDadosVeiculo.TabIndex = 10;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(112, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(506, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 25);
            textBox4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(112, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 1;
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaga.ForeColor = SystemColors.Desktop;
            lblVaga.Location = new Point(10, 124);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(40, 17);
            lblVaga.TabIndex = 0;
            lblVaga.Text = "Vaga:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaca.ForeColor = SystemColors.Desktop;
            lblPlaca.Location = new Point(10, 59);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(42, 17);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa:";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(maskedTextBox1);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grpBuscarVeiculo.Location = new Point(20, 103);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(756, 60);
            grpBuscarVeiculo.TabIndex = 8;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.BannerSaida4;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FrmRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Name = "FrmRegistrarSaida";
            Text = "FormRegistrarSaida";
            panel1.ResumeLayout(false);
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrarSaida;
        private Button btnCancelar;
        private Label lblCorModelo;
        private Label lblCliente;
        private DateTimePicker dtInfoHrEntrada;
        private TextBox txtCorModelo;
        private TextBox txtNomeCliente;
        private Label lblDataSaida;
        private GroupBox grpMovimentacao;
        private MaskedTextBox maskedTextBox1;
        private Label lblPlacaVeiculo;
        private Button btnBuscarPorPlaca;
        private GroupBox grpDadosVeiculo;
        private GroupBox grpBuscarVeiculo;
        private Label lblPlaca;
        private TextBox textBox1;
        private DateTimePicker dtInfoDtEntrada;
        private Label lblDataHoraEntrada;
        private TextBox textBox2;
        private Label lblVaga;
        private DateTimePicker dateTimePicker1;
        private Label lblHoraSaida;
        private GroupBox grpCalculo;
        private Label lblTempoPermanencia;
        private Label lblTarifaVigente;
        private TextBox textBox4;
        private TextBox txtInfoTempoPermanencia;
        private TextBox txtInfoTarifa;
        private Label lblValorPagar;
        private TextBox txtValorAPagar;
        private PictureBox pictureBox1;
    }
}