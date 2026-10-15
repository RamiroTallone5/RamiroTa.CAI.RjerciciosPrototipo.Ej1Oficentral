namespace Pampazon.Prototipo
{
    partial class SeleccionEntregaMercaderiaForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        #region Código generado para el diseñador
        private void InitializeComponent()
        {
            ListViewItem item_lvSelecciones_0 = new ListViewItem(new string[] { "OS-000071", "14/10/2026", "Segundo", "Fulfillment", "2", "2", "EMITIDA" }, -1);
            ListViewItem item_lvSelecciones_1 = new ListViewItem(new string[] { "OS-000072", "14/10/2026", "Segundo", "Palé cerrado", "1", "1", "EMITIDA" }, -1);
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            grpSelecciones = new GroupBox();
            lvSelecciones = new ListView();
            lvSeleccionesCol0 = new ColumnHeader();
            lvSeleccionesCol1 = new ColumnHeader();
            lvSeleccionesCol2 = new ColumnHeader();
            lvSeleccionesCol3 = new ColumnHeader();
            lvSeleccionesCol4 = new ColumnHeader();
            lvSeleccionesCol5 = new ColumnHeader();
            lvSeleccionesCol6 = new ColumnHeader();
            grpDetalleSeleccion = new GroupBox();
            lblOrdenSeleccion = new Label();
            txtOrdenSeleccion = new TextBox();
            lblModalidadSel = new Label();
            txtModalidadSel = new TextBox();
            lblCorteSel = new Label();
            txtCorteSel = new TextBox();
            lblEmitidaPor = new Label();
            txtEmitidaPor = new TextBox();
            dgvRenglones = new DataGridView();
            colCliente = new DataGridViewTextBoxColumn();
            colSku = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colUbicacion = new DataGridViewTextBoxColumn();
            colRequerida = new DataGridViewTextBoxColumn();
            colRetirada = new DataGridViewTextBoxColumn();
            colReparto = new DataGridViewTextBoxColumn();
            lblAyudaRetiro = new Label();
            grpConfirmacion = new GroupBox();
            lblObservacion = new Label();
            txtObservacion = new TextBox();
            chkEntregaPreparacion = new CheckBox();
            lblServicio = new Label();
            txtServicio = new TextBox();
            btnConfirmarEntrega = new Button();
            btnReportarIncidente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRenglones).BeginInit();
            pnlEncabezado.SuspendLayout();
            grpContexto.SuspendLayout();
            grpSelecciones.SuspendLayout();
            grpDetalleSeleccion.SuspendLayout();
            grpConfirmacion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblEmpresa);
            pnlEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlEncabezado.BackColor = Color.FromArgb(35, 80, 124);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1320, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Text = "Selección y Entrega de Mercadería";
            lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            lblEmpresa.Text = "PAMPAZON  |  Operario de Almacén";
            lblEmpresa.ForeColor = Color.White;
            lblEmpresa.Location = new Point(26, 48);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(1050, 22);
            lblEmpresa.TabIndex = 2;
            // 
            // grpContexto
            // 
            grpContexto.Controls.Add(lblDeposito);
            grpContexto.Controls.Add(cboDeposito);
            grpContexto.Controls.Add(lblRol);
            grpContexto.Controls.Add(lblFecha);
            grpContexto.Controls.Add(dtpFechaTrabajo);
            grpContexto.TabStop = false;
            grpContexto.Text = "Contexto de trabajo";
            grpContexto.Location = new Point(16, 84);
            grpContexto.Name = "grpContexto";
            grpContexto.Size = new Size(1288, 72);
            grpContexto.TabIndex = 3;
            // 
            // lblDeposito
            // 
            lblDeposito.Text = "Depósito";
            lblDeposito.Location = new Point(16, 30);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(68, 24);
            lblDeposito.TabIndex = 4;
            // 
            // cboDeposito
            // 
            cboDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDeposito.Enabled = false;
            cboDeposito.Items.AddRange(new object[] { "GBA" });
            cboDeposito.SelectedIndex = 0;
            cboDeposito.Location = new Point(90, 26);
            cboDeposito.Name = "cboDeposito";
            cboDeposito.Size = new Size(373, 23);
            cboDeposito.TabIndex = 5;
            // 
            // lblRol
            // 
            lblRol.Text = "Rol: Operario de Almacén";
            lblRol.Location = new Point(480, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(260, 24);
            lblRol.TabIndex = 6;
            // 
            // lblFecha
            // 
            lblFecha.Text = "Fecha";
            lblFecha.Location = new Point(780, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(72, 24);
            lblFecha.TabIndex = 7;
            // 
            // dtpFechaTrabajo
            // 
            dtpFechaTrabajo.Enabled = false;
            dtpFechaTrabajo.Format = DateTimePickerFormat.Short;
            dtpFechaTrabajo.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            dtpFechaTrabajo.Location = new Point(856, 26);
            dtpFechaTrabajo.Name = "dtpFechaTrabajo";
            dtpFechaTrabajo.Size = new Size(410, 23);
            dtpFechaTrabajo.TabIndex = 8;
            // 
            // grpSelecciones
            // 
            grpSelecciones.Controls.Add(lvSelecciones);
            grpSelecciones.TabStop = false;
            grpSelecciones.Text = "Órdenes de selección pendientes de cumplir";
            grpSelecciones.Location = new Point(16, 170);
            grpSelecciones.Name = "grpSelecciones";
            grpSelecciones.Size = new Size(1288, 200);
            grpSelecciones.TabIndex = 9;
            // 
            // lvSelecciones
            // 
            lvSelecciones.Columns.AddRange(new ColumnHeader[] { lvSeleccionesCol0, lvSeleccionesCol1, lvSeleccionesCol2, lvSeleccionesCol3, lvSeleccionesCol4, lvSeleccionesCol5, lvSeleccionesCol6 });
            lvSelecciones.FullRowSelect = true;
            lvSelecciones.GridLines = true;
            lvSelecciones.Items.AddRange(new ListViewItem[] { item_lvSelecciones_0, item_lvSelecciones_1 });
            lvSelecciones.Location = new Point(12, 26);
            lvSelecciones.Name = "lvSelecciones";
            lvSelecciones.Size = new Size(1262, 162);
            lvSelecciones.TabIndex = 10;
            lvSelecciones.UseCompatibleStateImageBehavior = false;
            lvSelecciones.View = View.Details;
            // 
            // lvSeleccionesCol0
            // 
            lvSeleccionesCol0.Text = "N.º de selección";
            lvSeleccionesCol0.Width = 130;
            // 
            // lvSeleccionesCol1
            // 
            lvSeleccionesCol1.Text = "Fecha de corte";
            lvSeleccionesCol1.Width = 120;
            // 
            // lvSeleccionesCol2
            // 
            lvSeleccionesCol2.Text = "Corte";
            lvSeleccionesCol2.Width = 90;
            // 
            // lvSeleccionesCol3
            // 
            lvSeleccionesCol3.Text = "Modalidad";
            lvSeleccionesCol3.Width = 140;
            // 
            // lvSeleccionesCol4
            // 
            lvSeleccionesCol4.Text = "Pedidos vinculados";
            lvSeleccionesCol4.Width = 140;
            // 
            // lvSeleccionesCol5
            // 
            lvSeleccionesCol5.Text = "Renglones";
            lvSeleccionesCol5.Width = 100;
            // 
            // lvSeleccionesCol6
            // 
            lvSeleccionesCol6.Text = "Estado";
            lvSeleccionesCol6.Width = 150;
            // 
            // grpDetalleSeleccion
            // 
            grpDetalleSeleccion.Controls.Add(lblOrdenSeleccion);
            grpDetalleSeleccion.Controls.Add(txtOrdenSeleccion);
            grpDetalleSeleccion.Controls.Add(lblModalidadSel);
            grpDetalleSeleccion.Controls.Add(txtModalidadSel);
            grpDetalleSeleccion.Controls.Add(lblCorteSel);
            grpDetalleSeleccion.Controls.Add(txtCorteSel);
            grpDetalleSeleccion.Controls.Add(lblEmitidaPor);
            grpDetalleSeleccion.Controls.Add(txtEmitidaPor);
            grpDetalleSeleccion.Controls.Add(dgvRenglones);
            grpDetalleSeleccion.Controls.Add(lblAyudaRetiro);
            grpDetalleSeleccion.TabStop = false;
            grpDetalleSeleccion.Text = "Detalle de la selección";
            grpDetalleSeleccion.Location = new Point(16, 382);
            grpDetalleSeleccion.Name = "grpDetalleSeleccion";
            grpDetalleSeleccion.Size = new Size(1288, 332);
            grpDetalleSeleccion.TabIndex = 11;
            // 
            // lblOrdenSeleccion
            // 
            lblOrdenSeleccion.Text = "Orden de selección";
            lblOrdenSeleccion.Location = new Point(14, 26);
            lblOrdenSeleccion.Name = "lblOrdenSeleccion";
            lblOrdenSeleccion.Size = new Size(140, 20);
            lblOrdenSeleccion.TabIndex = 12;
            // 
            // txtOrdenSeleccion
            // 
            txtOrdenSeleccion.ReadOnly = true;
            txtOrdenSeleccion.Location = new Point(14, 48);
            txtOrdenSeleccion.Name = "txtOrdenSeleccion";
            txtOrdenSeleccion.Size = new Size(150, 23);
            txtOrdenSeleccion.TabIndex = 13;
            // 
            // lblModalidadSel
            // 
            lblModalidadSel.Text = "Modalidad";
            lblModalidadSel.Location = new Point(184, 26);
            lblModalidadSel.Name = "lblModalidadSel";
            lblModalidadSel.Size = new Size(140, 20);
            lblModalidadSel.TabIndex = 14;
            // 
            // txtModalidadSel
            // 
            txtModalidadSel.ReadOnly = true;
            txtModalidadSel.Location = new Point(184, 48);
            txtModalidadSel.Name = "txtModalidadSel";
            txtModalidadSel.Size = new Size(160, 23);
            txtModalidadSel.TabIndex = 15;
            // 
            // lblCorteSel
            // 
            lblCorteSel.Text = "Corte";
            lblCorteSel.Location = new Point(364, 26);
            lblCorteSel.Name = "lblCorteSel";
            lblCorteSel.Size = new Size(140, 20);
            lblCorteSel.TabIndex = 16;
            // 
            // txtCorteSel
            // 
            txtCorteSel.ReadOnly = true;
            txtCorteSel.Location = new Point(364, 48);
            txtCorteSel.Name = "txtCorteSel";
            txtCorteSel.Size = new Size(120, 23);
            txtCorteSel.TabIndex = 17;
            // 
            // lblEmitidaPor
            // 
            lblEmitidaPor.Text = "Emitida por (Jefe de Preparación)";
            lblEmitidaPor.Location = new Point(504, 26);
            lblEmitidaPor.Name = "lblEmitidaPor";
            lblEmitidaPor.Size = new Size(200, 20);
            lblEmitidaPor.TabIndex = 18;
            // 
            // txtEmitidaPor
            // 
            txtEmitidaPor.ReadOnly = true;
            txtEmitidaPor.Location = new Point(504, 48);
            txtEmitidaPor.Name = "txtEmitidaPor";
            txtEmitidaPor.Size = new Size(260, 23);
            txtEmitidaPor.TabIndex = 19;
            // 
            // dgvRenglones
            // 
            dgvRenglones.AllowUserToAddRows = false;
            dgvRenglones.AllowUserToDeleteRows = false;
            dgvRenglones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRenglones.Columns.AddRange(new DataGridViewColumn[] { colCliente, colSku, colProducto, colUbicacion, colRequerida, colRetirada, colReparto });
            dgvRenglones.RowHeadersVisible = false;
            dgvRenglones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRenglones.Location = new Point(12, 86);
            dgvRenglones.Name = "dgvRenglones";
            dgvRenglones.Size = new Size(1262, 200);
            dgvRenglones.TabIndex = 20;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.Width = 190;
            colCliente.ReadOnly = true;
            // 
            // colSku
            // 
            colSku.HeaderText = "SKU";
            colSku.Name = "colSku";
            colSku.Width = 90;
            colSku.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.Width = 220;
            colProducto.ReadOnly = true;
            // 
            // colUbicacion
            // 
            colUbicacion.HeaderText = "Ubicación (X-Y-Z)";
            colUbicacion.Name = "colUbicacion";
            colUbicacion.Width = 130;
            colUbicacion.ReadOnly = true;
            // 
            // colRequerida
            // 
            colRequerida.HeaderText = "Cantidad requerida";
            colRequerida.Name = "colRequerida";
            colRequerida.Width = 130;
            colRequerida.ReadOnly = true;
            // 
            // colRetirada
            // 
            colRetirada.HeaderText = "Cantidad retirada";
            colRetirada.Name = "colRetirada";
            colRetirada.Width = 130;
            // 
            // colReparto
            // 
            colReparto.HeaderText = "Reparto entre órdenes de preparación";
            colReparto.Name = "colReparto";
            colReparto.Width = 330;
            colReparto.ReadOnly = true;
            // 
            // lblAyudaRetiro
            // 
            lblAyudaRetiro.Text = "Ingrese la cantidad retirada de cada renglón. Debe coincidir con la cantidad requerida.";
            lblAyudaRetiro.Location = new Point(14, 296);
            lblAyudaRetiro.Name = "lblAyudaRetiro";
            lblAyudaRetiro.Size = new Size(1240, 24);
            lblAyudaRetiro.TabIndex = 21;
            // 
            // grpConfirmacion
            // 
            grpConfirmacion.Controls.Add(lblObservacion);
            grpConfirmacion.Controls.Add(txtObservacion);
            grpConfirmacion.Controls.Add(chkEntregaPreparacion);
            grpConfirmacion.Controls.Add(lblServicio);
            grpConfirmacion.Controls.Add(txtServicio);
            grpConfirmacion.Controls.Add(btnConfirmarEntrega);
            grpConfirmacion.Controls.Add(btnReportarIncidente);
            grpConfirmacion.TabStop = false;
            grpConfirmacion.Text = "Confirmación de la entrega";
            grpConfirmacion.Location = new Point(16, 726);
            grpConfirmacion.Name = "grpConfirmacion";
            grpConfirmacion.Size = new Size(1288, 140);
            grpConfirmacion.TabIndex = 22;
            // 
            // lblObservacion
            // 
            lblObservacion.Text = "Observación de diferencia (hasta 200 caracteres)";
            lblObservacion.Location = new Point(14, 22);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(300, 20);
            lblObservacion.TabIndex = 23;
            // 
            // txtObservacion
            // 
            txtObservacion.Multiline = true;
            txtObservacion.MaxLength = 200;
            txtObservacion.Location = new Point(14, 44);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(560, 76);
            txtObservacion.TabIndex = 24;
            // 
            // chkEntregaPreparacion
            // 
            chkEntregaPreparacion.Text = "La mercadería fue entregada a la sección Preparación";
            chkEntregaPreparacion.UseVisualStyleBackColor = true;
            chkEntregaPreparacion.Location = new Point(600, 26);
            chkEntregaPreparacion.Name = "chkEntregaPreparacion";
            chkEntregaPreparacion.Size = new Size(390, 24);
            chkEntregaPreparacion.TabIndex = 25;
            // 
            // lblServicio
            // 
            lblServicio.Text = "Servicio a registrar";
            lblServicio.Location = new Point(600, 70);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(150, 20);
            lblServicio.TabIndex = 26;
            // 
            // txtServicio
            // 
            txtServicio.ReadOnly = true;
            txtServicio.Location = new Point(756, 66);
            txtServicio.Name = "txtServicio";
            txtServicio.Size = new Size(200, 23);
            txtServicio.TabIndex = 27;
            // 
            // btnConfirmarEntrega
            // 
            btnConfirmarEntrega.BackColor = Color.FromArgb(35, 80, 124);
            btnConfirmarEntrega.FlatStyle = FlatStyle.Flat;
            btnConfirmarEntrega.ForeColor = Color.White;
            btnConfirmarEntrega.Text = "Confirmar entrega";
            btnConfirmarEntrega.UseVisualStyleBackColor = false;
            btnConfirmarEntrega.Location = new Point(1010, 26);
            btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            btnConfirmarEntrega.Size = new Size(260, 34);
            btnConfirmarEntrega.TabIndex = 28;
            // 
            // btnReportarIncidente
            // 
            btnReportarIncidente.Text = "Reportar incidente";
            btnReportarIncidente.UseVisualStyleBackColor = true;
            btnReportarIncidente.Location = new Point(1010, 70);
            btnReportarIncidente.Name = "btnReportarIncidente";
            btnReportarIncidente.Size = new Size(260, 34);
            btnReportarIncidente.TabIndex = 29;
            // 
            // SeleccionEntregaMercaderiaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1334, 901);
            Controls.Add(pnlEncabezado);
            Controls.Add(grpContexto);
            Controls.Add(grpSelecciones);
            Controls.Add(grpDetalleSeleccion);
            Controls.Add(grpConfirmacion);
            Font = new Font("Segoe UI", 9F);
            AutoScroll = true;
            AutoScrollMinSize = new Size(1334, 901);
            MinimumSize = new Size(640, 480);
            WindowState = FormWindowState.Maximized;
            Name = "SeleccionEntregaMercaderiaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Selección y Entrega de Mercadería";
            grpConfirmacion.ResumeLayout(false);
            grpDetalleSeleccion.ResumeLayout(false);
            grpSelecciones.ResumeLayout(false);
            grpContexto.ResumeLayout(false);
            pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRenglones).EndInit();
            ResumeLayout(false);
            dgvRenglones.Rows.Add("Cliente Demo A", "SKU-001", "Remera de algodón", "12-43-2", "120", "", "OP-000181 (80); OP-000182 (40)");
            dgvRenglones.Rows.Add("Cliente Demo A", "SKU-002", "Pantalón deportivo", "12-44-1", "30", "", "OP-000181 (30)");
        }
        #endregion
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox grpContexto;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.ComboBox cboDeposito;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajo;
        private System.Windows.Forms.GroupBox grpSelecciones;
        private System.Windows.Forms.ListView lvSelecciones;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol0;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol1;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol2;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol3;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol4;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol5;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol6;
        private System.Windows.Forms.GroupBox grpDetalleSeleccion;
        private System.Windows.Forms.Label lblOrdenSeleccion;
        private System.Windows.Forms.TextBox txtOrdenSeleccion;
        private System.Windows.Forms.Label lblModalidadSel;
        private System.Windows.Forms.TextBox txtModalidadSel;
        private System.Windows.Forms.Label lblCorteSel;
        private System.Windows.Forms.TextBox txtCorteSel;
        private System.Windows.Forms.Label lblEmitidaPor;
        private System.Windows.Forms.TextBox txtEmitidaPor;
        private System.Windows.Forms.DataGridView dgvRenglones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequerida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReparto;
        private System.Windows.Forms.Label lblAyudaRetiro;
        private System.Windows.Forms.GroupBox grpConfirmacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.CheckBox chkEntregaPreparacion;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Button btnConfirmarEntrega;
        private System.Windows.Forms.Button btnReportarIncidente;
    }
}
