namespace prySp2AguirreEjercicoResolver
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            dtpFecha = new DateTimePicker();
            txtCodigo = new TextBox();
            cboTipoBoleto = new ComboBox();
            gbDistancia = new GroupBox();
            rbLarga = new RadioButton();
            rbCorta = new RadioButton();
            lblCodigo = new Label();
            lblTipoBoleta = new Label();
            btnRegistrar = new Button();
            lblFecha = new Label();
            gbDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(64, 10);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(105, 23);
            dtpFecha.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(64, 45);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(113, 23);
            txtCodigo.TabIndex = 1;
            // 
            // cboTipoBoleto
            // 
            cboTipoBoleto.FormattingEnabled = true;
            cboTipoBoleto.Location = new Point(101, 81);
            cboTipoBoleto.Name = "cboTipoBoleto";
            cboTipoBoleto.Size = new Size(125, 23);
            cboTipoBoleto.TabIndex = 2;
            // 
            // gbDistancia
            // 
            gbDistancia.BackColor = Color.AliceBlue;
            gbDistancia.Controls.Add(rbLarga);
            gbDistancia.Controls.Add(rbCorta);
            gbDistancia.ForeColor = SystemColors.ControlText;
            gbDistancia.Location = new Point(12, 121);
            gbDistancia.Name = "gbDistancia";
            gbDistancia.Size = new Size(191, 103);
            gbDistancia.TabIndex = 3;
            gbDistancia.TabStop = false;
            gbDistancia.Text = "Distancia";
            // 
            // rbLarga
            // 
            rbLarga.AutoSize = true;
            rbLarga.Location = new Point(14, 53);
            rbLarga.Name = "rbLarga";
            rbLarga.Size = new Size(54, 19);
            rbLarga.TabIndex = 1;
            rbLarga.TabStop = true;
            rbLarga.Text = "Larga";
            rbLarga.UseVisualStyleBackColor = true;
            // 
            // rbCorta
            // 
            rbCorta.AutoSize = true;
            rbCorta.Location = new Point(14, 28);
            rbCorta.Name = "rbCorta";
            rbCorta.Size = new Size(54, 19);
            rbCorta.TabIndex = 0;
            rbCorta.TabStop = true;
            rbCorta.Text = "Corta";
            rbCorta.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Codigo";
            // 
            // lblTipoBoleta
            // 
            lblTipoBoleta.AutoSize = true;
            lblTipoBoleta.Location = new Point(12, 84);
            lblTipoBoleta.Name = "lblTipoBoleta";
            lblTipoBoleta.Size = new Size(83, 15);
            lblTipoBoleta.TabIndex = 6;
            lblTipoBoleta.Text = "Tipo de Boleta";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(185, 246);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(68, 35);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.White;
            lblFecha.Location = new Point(12, 16);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(265, 299);
            Controls.Add(btnRegistrar);
            Controls.Add(lblTipoBoleta);
            Controls.Add(lblCodigo);
            Controls.Add(lblFecha);
            Controls.Add(gbDistancia);
            Controls.Add(cboTipoBoleto);
            Controls.Add(txtCodigo);
            Controls.Add(dtpFecha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta Boleteria";
            Load += frmPrincipal_Load;
            gbDistancia.ResumeLayout(false);
            gbDistancia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private TextBox txtCodigo;
        private ComboBox cboTipoBoleto;
        private GroupBox gbDistancia;
        private RadioButton rbLarga;
        private RadioButton rbCorta;
        private Label lblCodigo;
        private Label lblTipoBoleta;
        private Button btnRegistrar;
        private Label lblFecha;
    }
}
