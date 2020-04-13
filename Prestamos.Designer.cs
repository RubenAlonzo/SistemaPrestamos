namespace SistemaPrestamos
{
    partial class Prestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.cbInteres = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbMonto = new System.Windows.Forms.Label();
            this.lbCuota = new System.Windows.Forms.Label();
            this.lbInteres = new System.Windows.Forms.Label();
            this.lbModalidad = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRestante = new System.Windows.Forms.Label();
            this.lbSaldado = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrearPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre del cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(19, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 59;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(233, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar...";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv2.ColumnHeadersHeight = 25;
            this.dgv2.EnableHeadersVisualStyles = false;
            this.dgv2.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv2.Location = new System.Drawing.Point(15, 297);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(824, 138);
            this.dgv2.TabIndex = 62;
            this.dgv2.SelectionChanged += new System.EventHandler(this.dgv2_SelectionChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(15, 441);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 28);
            this.btnEditar.TabIndex = 63;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(114, 441);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 28);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Location = new System.Drawing.Point(746, 441);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(93, 28);
            this.btnClientes.TabIndex = 79;
            this.btnClientes.Text = "Clientes...";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(95, 24);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(80, 23);
            this.txtMonto.TabIndex = 80;
            // 
            // txtCuotas
            // 
            this.txtCuotas.Enabled = false;
            this.txtCuotas.Location = new System.Drawing.Point(295, 23);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(75, 23);
            this.txtCuotas.TabIndex = 81;
            // 
            // cbModalidad
            // 
            this.cbModalidad.BackColor = System.Drawing.SystemColors.Window;
            this.cbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidad.Enabled = false;
            this.cbModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Items.AddRange(new object[] {
            "Quincenal",
            "Mensual"});
            this.cbModalidad.Location = new System.Drawing.Point(95, 56);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(80, 24);
            this.cbModalidad.TabIndex = 82;
            // 
            // cbInteres
            // 
            this.cbInteres.BackColor = System.Drawing.SystemColors.Window;
            this.cbInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInteres.Enabled = false;
            this.cbInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInteres.FormattingEnabled = true;
            this.cbInteres.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%",
            "25%"});
            this.cbInteres.Location = new System.Drawing.Point(295, 60);
            this.cbInteres.Name = "cbInteres";
            this.cbInteres.Size = new System.Drawing.Size(75, 24);
            this.cbInteres.TabIndex = 83;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(13, 127);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(228, 23);
            this.dtpFecha.TabIndex = 84;
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.BackColor = System.Drawing.Color.Transparent;
            this.lbMonto.Enabled = false;
            this.lbMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMonto.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMonto.Location = new System.Drawing.Point(9, 24);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(45, 15);
            this.lbMonto.TabIndex = 85;
            this.lbMonto.Text = "Monto";
            // 
            // lbCuota
            // 
            this.lbCuota.AutoSize = true;
            this.lbCuota.BackColor = System.Drawing.Color.Transparent;
            this.lbCuota.Enabled = false;
            this.lbCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCuota.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCuota.Location = new System.Drawing.Point(238, 27);
            this.lbCuota.Name = "lbCuota";
            this.lbCuota.Size = new System.Drawing.Size(47, 15);
            this.lbCuota.TabIndex = 86;
            this.lbCuota.Text = "Cuotas";
            // 
            // lbInteres
            // 
            this.lbInteres.AutoSize = true;
            this.lbInteres.BackColor = System.Drawing.Color.Transparent;
            this.lbInteres.Enabled = false;
            this.lbInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbInteres.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInteres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInteres.Location = new System.Drawing.Point(238, 63);
            this.lbInteres.Name = "lbInteres";
            this.lbInteres.Size = new System.Drawing.Size(51, 15);
            this.lbInteres.TabIndex = 87;
            this.lbInteres.Text = "Interes";
            // 
            // lbModalidad
            // 
            this.lbModalidad.AutoSize = true;
            this.lbModalidad.BackColor = System.Drawing.Color.Transparent;
            this.lbModalidad.Enabled = false;
            this.lbModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbModalidad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModalidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbModalidad.Location = new System.Drawing.Point(9, 57);
            this.lbModalidad.Name = "lbModalidad";
            this.lbModalidad.Size = new System.Drawing.Size(71, 15);
            this.lbModalidad.TabIndex = 88;
            this.lbModalidad.Text = "Modalidad";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Enabled = false;
            this.lbFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFecha.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFecha.Location = new System.Drawing.Point(9, 108);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(41, 15);
            this.lbFecha.TabIndex = 89;
            this.lbFecha.Text = "Fecha";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(247, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 28);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(314, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 28);
            this.btnRefresh.TabIndex = 91;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbRestante);
            this.groupBox1.Controls.Add(this.lbSaldado);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnPago);
            this.groupBox1.Controls.Add(this.txtPago);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(474, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 200);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Pagos";
            // 
            // lbRestante
            // 
            this.lbRestante.AutoSize = true;
            this.lbRestante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbRestante.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestante.ForeColor = System.Drawing.Color.Crimson;
            this.lbRestante.Location = new System.Drawing.Point(198, 89);
            this.lbRestante.Name = "lbRestante";
            this.lbRestante.Size = new System.Drawing.Size(86, 18);
            this.lbRestante.TabIndex = 8;
            this.lbRestante.Text = "0.00 RD$";
            // 
            // lbSaldado
            // 
            this.lbSaldado.AutoSize = true;
            this.lbSaldado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbSaldado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSaldado.Location = new System.Drawing.Point(198, 58);
            this.lbSaldado.Name = "lbSaldado";
            this.lbSaldado.Size = new System.Drawing.Size(86, 18);
            this.lbSaldado.TabIndex = 7;
            this.lbSaldado.Text = "0.00 RD$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Navy;
            this.lbTotal.Location = new System.Drawing.Point(198, 28);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(86, 18);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "0.00 RD$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(47, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Monto restante:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(49, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Monto saldado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(62, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total a pagar:";
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPago.Location = new System.Drawing.Point(201, 146);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(93, 28);
            this.btnPago.TabIndex = 2;
            this.btnPago.Text = "Aceptar";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(94, 149);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 23);
            this.txtPago.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(50, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pago";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbModalidad);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.txtCuotas);
            this.groupBox2.Controls.Add(this.lbFecha);
            this.groupBox2.Controls.Add(this.cbInteres);
            this.groupBox2.Controls.Add(this.lbModalidad);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.lbInteres);
            this.groupBox2.Controls.Add(this.lbMonto);
            this.groupBox2.Controls.Add(this.lbCuota);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(19, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 173);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificaciones";
            // 
            // btnCrearPrestamo
            // 
            this.btnCrearPrestamo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCrearPrestamo.FlatAppearance.BorderSize = 0;
            this.btnCrearPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPrestamo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearPrestamo.Location = new System.Drawing.Point(607, 441);
            this.btnCrearPrestamo.Name = "btnCrearPrestamo";
            this.btnCrearPrestamo.Size = new System.Drawing.Size(133, 28);
            this.btnCrearPrestamo.TabIndex = 94;
            this.btnCrearPrestamo.Text = "Crear prestamo";
            this.btnCrearPrestamo.UseVisualStyleBackColor = false;
            this.btnCrearPrestamo.Click += new System.EventHandler(this.btnCrearPrestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(310, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 30);
            this.label1.TabIndex = 95;
            this.label1.Text = "Visor de prestamos";
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::SistemaPrestamos.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearPrestamo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.ComboBox cbInteres;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Label lbCuota;
        private System.Windows.Forms.Label lbInteres;
        private System.Windows.Forms.Label lbModalidad;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRestante;
        private System.Windows.Forms.Label lbSaldado;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnCrearPrestamo;
        private System.Windows.Forms.Label label1;
    }
}