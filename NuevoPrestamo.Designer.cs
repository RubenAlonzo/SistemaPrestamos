namespace SistemaPrestamos
{
    partial class NuevoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPrestamo));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInteres = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(12, 268);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(199, 47);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label13
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lbPrincipal.Enabled = false;
            this.lbPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrincipal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPrincipal.Location = new System.Drawing.Point(10, 115);
            this.lbPrincipal.Name = "label13";
            this.lbPrincipal.Size = new System.Drawing.Size(156, 19);
            this.lbPrincipal.TabIndex = 70;
            this.lbPrincipal.Text = "Datos del prestamo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(217, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 69;
            this.label11.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(217, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 68;
            this.label10.Text = "Modalidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(219, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Monto";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Location = new System.Drawing.Point(12, 242);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaInicio.TabIndex = 65;
            // 
            // cbModalidad
            // 
            this.cbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidad.Enabled = false;
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Items.AddRange(new object[] {
            "Quincenal",
            "Mensual"});
            this.cbModalidad.Location = new System.Drawing.Point(12, 214);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(199, 21);
            this.cbModalidad.TabIndex = 64;
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(14, 137);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(199, 20);
            this.txtMonto.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nombre del cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Items.AddRange(new object[] {
            "Nombre"});
            this.cbCliente.Location = new System.Drawing.Point(12, 46);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 73;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarID.FlatAppearance.BorderSize = 0;
            this.btnBuscarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarID.Location = new System.Drawing.Point(12, 77);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 74;
            this.btnBuscarID.Text = "Buscar...";
            this.btnBuscarID.UseVisualStyleBackColor = false;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // txtCuotas
            // 
            this.txtCuotas.Enabled = false;
            this.txtCuotas.Location = new System.Drawing.Point(12, 179);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(75, 20);
            this.txtCuotas.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Cuotas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(160, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 78;
            this.label3.Text = "Interes";
            // 
            // cbInteres
            // 
            this.cbInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInteres.Enabled = false;
            this.cbInteres.FormattingEnabled = true;
            this.cbInteres.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%",
            "25%"});
            this.cbInteres.Location = new System.Drawing.Point(136, 178);
            this.cbInteres.Name = "cbInteres";
            this.cbInteres.Size = new System.Drawing.Size(75, 21);
            this.cbInteres.TabIndex = 79;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::SistemaPrestamos.Properties.Resources.bgP;
            this.ClientSize = new System.Drawing.Size(319, 354);
            this.Controls.Add(this.cbInteres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbPrincipal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbModalidad);
            this.Controls.Add(this.txtMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevoPrestamo_FormClosed);
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbPrincipal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInteres;
    }
}