namespace Pampazon.Prototipo
{
    partial class EmpaquetadoPreparacionEntregasForm
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
            ListViewItem item_lvPedidosEnPreparacion_0 = new ListViewItem(new string[] { "OP-000181", "Cliente Demo A", "Fulfillment", "Destino demo A", "Completas", "EN PREPARACIÓN" }, -1);
            ListViewItem item_lvPedidosEnPreparacion_1 = new ListViewItem(new string[] { "OP-000183", "Cliente Demo B", "Palé cerrado", "Destino demo B", "Completas", "EN PREPARACIÓN" }, -1);
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            grpPedidos = new GroupBox();
            lvPedidosEnPreparacion = new ListView();
            lvPedidosEnPreparacionCol0 = new ColumnHeader();
            lvPedidosEnPreparacionCol1 = new ColumnHeader();
            lvPedidosEnPreparacionCol2 = new ColumnHeader();
            lvPedidosEnPreparacionCol3 = new ColumnHeader();
            lvPedidosEnPreparacionCol4 = new ColumnHeader();
            lvPedidosEnPreparacionCol5 = new ColumnHeader();
            grpDatosPedido = new GroupBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblDestino = new Label();
            txtDestino = new TextBox();
            grpControl = new GroupBox();
            dgvControl = new DataGridView();
            colSku = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colSolicitada = new DataGridViewTextBoxColumn();
            colEntregada = new DataGridViewTextBoxColumn();
            colControlada = new DataGridViewTextBoxColumn();
            colDiferencia = new DataGridViewTextBoxColumn();
            grpFulfillment = new GroupBox();
            lblIdBulto = new Label();
            txtIdBulto = new TextBox();
            lblSkuBulto = new Label();
            cboSkuBulto = new ComboBox();
            lblCantBulto = new Label();
            txtCantBulto = new TextBox();
            btnAgregarBulto = new Button();
            dgvBultos = new DataGridView();
            colBulto = new DataGridViewTextBoxColumn();
            colSkuBulto = new DataGridViewTextBoxColumn();
            colProductoBulto = new DataGridViewTextBoxColumn();
            colCantBulto = new DataGridViewTextBoxColumn();
            grpPale = new GroupBox();
            lblIdPale = new Label();
            txtIdPale = new TextBox();
            chkPaleConforme = new CheckBox();
            grpCierre = new GroupBox();
            chkListo = new CheckBox();
            lblOrdenEntrega = new Label();
            txtOrdenEntrega = new TextBox();
            btnConfirmarPreparacion = new Button();
            btnReimprimir = new Button();
            btnReportarIncidente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBultos).BeginInit();
            pnlEncabezado.SuspendLayout();
            grpContexto.SuspendLayout();
            grpPedidos.SuspendLayout();
            grpDatosPedido.SuspendLayout();
            grpControl.SuspendLayout();
            grpFulfillment.SuspendLayout();
            grpPale.SuspendLayout();
            grpCierre.SuspendLayout();
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
            lblTitulo.Text = "Empaquetado y Preparación de Entregas";
            lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            lblEmpresa.Text = "PAMPAZON  |  Operario de Preparación";
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
            lblRol.Text = "Rol: Operario de Preparación";
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
            // grpPedidos
            // 
            grpPedidos.Controls.Add(lvPedidosEnPreparacion);
            grpPedidos.TabStop = false;
            grpPedidos.Text = "Pedidos en preparación";
            grpPedidos.Location = new Point(16, 170);
            grpPedidos.Name = "grpPedidos";
            grpPedidos.Size = new Size(1288, 170);
            grpPedidos.TabIndex = 9;
            // 
            // lvPedidosEnPreparacion
            // 
            lvPedidosEnPreparacion.Columns.AddRange(new ColumnHeader[] { lvPedidosEnPreparacionCol0, lvPedidosEnPreparacionCol1, lvPedidosEnPreparacionCol2, lvPedidosEnPreparacionCol3, lvPedidosEnPreparacionCol4, lvPedidosEnPreparacionCol5 });
            lvPedidosEnPreparacion.FullRowSelect = true;
            lvPedidosEnPreparacion.GridLines = true;
            lvPedidosEnPreparacion.Items.AddRange(new ListViewItem[] { item_lvPedidosEnPreparacion_0, item_lvPedidosEnPreparacion_1 });
            lvPedidosEnPreparacion.Location = new Point(12, 26);
            lvPedidosEnPreparacion.Name = "lvPedidosEnPreparacion";
            lvPedidosEnPreparacion.Size = new Size(1262, 132);
            lvPedidosEnPreparacion.TabIndex = 10;
            lvPedidosEnPreparacion.UseCompatibleStateImageBehavior = false;
            lvPedidosEnPreparacion.View = View.Details;
            // 
            // lvPedidosEnPreparacionCol0
            // 
            lvPedidosEnPreparacionCol0.Text = "N.º de pedido";
            lvPedidosEnPreparacionCol0.Width = 120;
            // 
            // lvPedidosEnPreparacionCol1
            // 
            lvPedidosEnPreparacionCol1.Text = "Cliente";
            lvPedidosEnPreparacionCol1.Width = 220;
            // 
            // lvPedidosEnPreparacionCol2
            // 
            lvPedidosEnPreparacionCol2.Text = "Modalidad";
            lvPedidosEnPreparacionCol2.Width = 150;
            // 
            // lvPedidosEnPreparacionCol3
            // 
            lvPedidosEnPreparacionCol3.Text = "Destino";
            lvPedidosEnPreparacionCol3.Width = 300;
            // 
            // lvPedidosEnPreparacionCol4
            // 
            lvPedidosEnPreparacionCol4.Text = "Selecciones";
            lvPedidosEnPreparacionCol4.Width = 120;
            // 
            // lvPedidosEnPreparacionCol5
            // 
            lvPedidosEnPreparacionCol5.Text = "Estado";
            lvPedidosEnPreparacionCol5.Width = 170;
            // 
            // grpDatosPedido
            // 
            grpDatosPedido.Controls.Add(lblCliente);
            grpDatosPedido.Controls.Add(txtCliente);
            grpDatosPedido.Controls.Add(lblModalidad);
            grpDatosPedido.Controls.Add(txtModalidad);
            grpDatosPedido.Controls.Add(lblDestino);
            grpDatosPedido.Controls.Add(txtDestino);
            grpDatosPedido.TabStop = false;
            grpDatosPedido.Text = "Datos del pedido";
            grpDatosPedido.Location = new Point(16, 350);
            grpDatosPedido.Name = "grpDatosPedido";
            grpDatosPedido.Size = new Size(1288, 66);
            grpDatosPedido.TabIndex = 11;
            // 
            // lblCliente
            // 
            lblCliente.Text = "Cliente";
            lblCliente.Location = new Point(14, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(60, 20);
            lblCliente.TabIndex = 12;
            // 
            // txtCliente
            // 
            txtCliente.ReadOnly = true;
            txtCliente.Location = new Point(76, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(250, 23);
            txtCliente.TabIndex = 13;
            // 
            // lblModalidad
            // 
            lblModalidad.Text = "Modalidad";
            lblModalidad.Location = new Point(350, 28);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(80, 20);
            lblModalidad.TabIndex = 14;
            // 
            // txtModalidad
            // 
            txtModalidad.ReadOnly = true;
            txtModalidad.Location = new Point(434, 24);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Size = new Size(170, 23);
            txtModalidad.TabIndex = 15;
            // 
            // lblDestino
            // 
            lblDestino.Text = "Destino";
            lblDestino.Location = new Point(630, 28);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(60, 20);
            lblDestino.TabIndex = 16;
            // 
            // txtDestino
            // 
            txtDestino.ReadOnly = true;
            txtDestino.Location = new Point(694, 24);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(300, 23);
            txtDestino.TabIndex = 17;
            // 
            // grpControl
            // 
            grpControl.Controls.Add(dgvControl);
            grpControl.TabStop = false;
            grpControl.Text = "Control de productos recibidos de Almacén";
            grpControl.Location = new Point(16, 426);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(1288, 170);
            grpControl.TabIndex = 18;
            // 
            // dgvControl
            // 
            dgvControl.AllowUserToAddRows = false;
            dgvControl.AllowUserToDeleteRows = false;
            dgvControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvControl.Columns.AddRange(new DataGridViewColumn[] { colSku, colProducto, colSolicitada, colEntregada, colControlada, colDiferencia });
            dgvControl.RowHeadersVisible = false;
            dgvControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControl.Location = new Point(12, 24);
            dgvControl.Name = "dgvControl";
            dgvControl.Size = new Size(1262, 134);
            dgvControl.TabIndex = 19;
            // 
            // colSku
            // 
            colSku.HeaderText = "SKU";
            colSku.Name = "colSku";
            colSku.Width = 100;
            colSku.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.Width = 260;
            colProducto.ReadOnly = true;
            // 
            // colSolicitada
            // 
            colSolicitada.HeaderText = "Cantidad solicitada";
            colSolicitada.Name = "colSolicitada";
            colSolicitada.Width = 150;
            colSolicitada.ReadOnly = true;
            // 
            // colEntregada
            // 
            colEntregada.HeaderText = "Entregada por Almacén";
            colEntregada.Name = "colEntregada";
            colEntregada.Width = 170;
            colEntregada.ReadOnly = true;
            // 
            // colControlada
            // 
            colControlada.HeaderText = "Cantidad controlada";
            colControlada.Name = "colControlada";
            colControlada.Width = 150;
            // 
            // colDiferencia
            // 
            colDiferencia.HeaderText = "Diferencia";
            colDiferencia.Name = "colDiferencia";
            colDiferencia.Width = 120;
            colDiferencia.ReadOnly = true;
            // 
            // grpFulfillment
            // 
            grpFulfillment.Controls.Add(lblIdBulto);
            grpFulfillment.Controls.Add(txtIdBulto);
            grpFulfillment.Controls.Add(lblSkuBulto);
            grpFulfillment.Controls.Add(cboSkuBulto);
            grpFulfillment.Controls.Add(lblCantBulto);
            grpFulfillment.Controls.Add(txtCantBulto);
            grpFulfillment.Controls.Add(btnAgregarBulto);
            grpFulfillment.Controls.Add(dgvBultos);
            grpFulfillment.TabStop = false;
            grpFulfillment.Text = "Bultos (modalidad fulfillment)";
            grpFulfillment.Location = new Point(16, 606);
            grpFulfillment.Name = "grpFulfillment";
            grpFulfillment.Size = new Size(820, 250);
            grpFulfillment.TabIndex = 20;
            // 
            // lblIdBulto
            // 
            lblIdBulto.Text = "Identificación del bulto";
            lblIdBulto.Location = new Point(14, 26);
            lblIdBulto.Name = "lblIdBulto";
            lblIdBulto.Size = new Size(200, 20);
            lblIdBulto.TabIndex = 21;
            // 
            // txtIdBulto
            // 
            txtIdBulto.MaxLength = 20;
            txtIdBulto.Location = new Point(14, 48);
            txtIdBulto.Name = "txtIdBulto";
            txtIdBulto.Size = new Size(200, 23);
            txtIdBulto.TabIndex = 22;
            // 
            // lblSkuBulto
            // 
            lblSkuBulto.Text = "SKU";
            lblSkuBulto.Location = new Point(14, 80);
            lblSkuBulto.Name = "lblSkuBulto";
            lblSkuBulto.Size = new Size(200, 20);
            lblSkuBulto.TabIndex = 23;
            // 
            // cboSkuBulto
            // 
            cboSkuBulto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSkuBulto.Items.AddRange(new object[] { "SKU-001", "SKU-002" });
            cboSkuBulto.SelectedIndex = 0;
            cboSkuBulto.Location = new Point(14, 102);
            cboSkuBulto.Name = "cboSkuBulto";
            cboSkuBulto.Size = new Size(200, 23);
            cboSkuBulto.TabIndex = 24;
            // 
            // lblCantBulto
            // 
            lblCantBulto.Text = "Cantidad empacada";
            lblCantBulto.Location = new Point(14, 134);
            lblCantBulto.Name = "lblCantBulto";
            lblCantBulto.Size = new Size(200, 20);
            lblCantBulto.TabIndex = 25;
            // 
            // txtCantBulto
            // 
            txtCantBulto.Location = new Point(14, 156);
            txtCantBulto.Name = "txtCantBulto";
            txtCantBulto.Size = new Size(100, 23);
            txtCantBulto.TabIndex = 26;
            // 
            // btnAgregarBulto
            // 
            btnAgregarBulto.BackColor = Color.FromArgb(35, 80, 124);
            btnAgregarBulto.FlatStyle = FlatStyle.Flat;
            btnAgregarBulto.ForeColor = Color.White;
            btnAgregarBulto.Text = "Agregar al bulto";
            btnAgregarBulto.UseVisualStyleBackColor = false;
            btnAgregarBulto.Location = new Point(14, 196);
            btnAgregarBulto.Name = "btnAgregarBulto";
            btnAgregarBulto.Size = new Size(200, 34);
            btnAgregarBulto.TabIndex = 27;
            // 
            // dgvBultos
            // 
            dgvBultos.AllowUserToAddRows = false;
            dgvBultos.AllowUserToDeleteRows = false;
            dgvBultos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBultos.Columns.AddRange(new DataGridViewColumn[] { colBulto, colSkuBulto, colProductoBulto, colCantBulto });
            dgvBultos.RowHeadersVisible = false;
            dgvBultos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBultos.Location = new Point(230, 26);
            dgvBultos.Name = "dgvBultos";
            dgvBultos.Size = new Size(576, 204);
            dgvBultos.TabIndex = 28;
            // 
            // colBulto
            // 
            colBulto.HeaderText = "Bulto";
            colBulto.Name = "colBulto";
            colBulto.Width = 140;
            colBulto.ReadOnly = true;
            // 
            // colSkuBulto
            // 
            colSkuBulto.HeaderText = "SKU";
            colSkuBulto.Name = "colSkuBulto";
            colSkuBulto.Width = 120;
            colSkuBulto.ReadOnly = true;
            // 
            // colProductoBulto
            // 
            colProductoBulto.HeaderText = "Producto";
            colProductoBulto.Name = "colProductoBulto";
            colProductoBulto.Width = 200;
            colProductoBulto.ReadOnly = true;
            // 
            // colCantBulto
            // 
            colCantBulto.HeaderText = "Cantidad";
            colCantBulto.Name = "colCantBulto";
            colCantBulto.Width = 100;
            colCantBulto.ReadOnly = true;
            // 
            // grpPale
            // 
            grpPale.Controls.Add(lblIdPale);
            grpPale.Controls.Add(txtIdPale);
            grpPale.Controls.Add(chkPaleConforme);
            grpPale.TabStop = false;
            grpPale.Text = "Revisión de palé (modalidad palé cerrado)";
            grpPale.Location = new Point(846, 606);
            grpPale.Name = "grpPale";
            grpPale.Size = new Size(458, 100);
            grpPale.TabIndex = 29;
            // 
            // lblIdPale
            // 
            lblIdPale.Text = "Identificación del palé";
            lblIdPale.Location = new Point(14, 24);
            lblIdPale.Name = "lblIdPale";
            lblIdPale.Size = new Size(200, 20);
            lblIdPale.TabIndex = 30;
            // 
            // txtIdPale
            // 
            txtIdPale.MaxLength = 20;
            txtIdPale.Location = new Point(14, 44);
            txtIdPale.Name = "txtIdPale";
            txtIdPale.Size = new Size(260, 23);
            txtIdPale.TabIndex = 31;
            // 
            // chkPaleConforme
            // 
            chkPaleConforme.Text = "Revisión conforme (embalaje del palé)";
            chkPaleConforme.UseVisualStyleBackColor = true;
            chkPaleConforme.Location = new Point(14, 72);
            chkPaleConforme.Name = "chkPaleConforme";
            chkPaleConforme.Size = new Size(420, 22);
            chkPaleConforme.TabIndex = 32;
            // 
            // grpCierre
            // 
            grpCierre.Controls.Add(chkListo);
            grpCierre.Controls.Add(lblOrdenEntrega);
            grpCierre.Controls.Add(txtOrdenEntrega);
            grpCierre.Controls.Add(btnConfirmarPreparacion);
            grpCierre.Controls.Add(btnReimprimir);
            grpCierre.Controls.Add(btnReportarIncidente);
            grpCierre.TabStop = false;
            grpCierre.Text = "Cierre de la preparación";
            grpCierre.Location = new Point(846, 716);
            grpCierre.Name = "grpCierre";
            grpCierre.Size = new Size(458, 140);
            grpCierre.TabIndex = 33;
            // 
            // chkListo
            // 
            chkListo.Text = "Pedido completo y listo para Despacho";
            chkListo.UseVisualStyleBackColor = true;
            chkListo.Location = new Point(14, 22);
            chkListo.Name = "chkListo";
            chkListo.Size = new Size(420, 24);
            chkListo.TabIndex = 34;
            // 
            // lblOrdenEntrega
            // 
            lblOrdenEntrega.Text = "Orden de entrega";
            lblOrdenEntrega.Location = new Point(14, 60);
            lblOrdenEntrega.Name = "lblOrdenEntrega";
            lblOrdenEntrega.Size = new Size(120, 20);
            lblOrdenEntrega.TabIndex = 35;
            // 
            // txtOrdenEntrega
            // 
            txtOrdenEntrega.ReadOnly = true;
            txtOrdenEntrega.Location = new Point(140, 56);
            txtOrdenEntrega.Name = "txtOrdenEntrega";
            txtOrdenEntrega.Size = new Size(200, 23);
            txtOrdenEntrega.TabIndex = 36;
            // 
            // btnConfirmarPreparacion
            // 
            btnConfirmarPreparacion.BackColor = Color.FromArgb(35, 80, 124);
            btnConfirmarPreparacion.FlatStyle = FlatStyle.Flat;
            btnConfirmarPreparacion.ForeColor = Color.White;
            btnConfirmarPreparacion.Text = "Confirmar preparación";
            btnConfirmarPreparacion.UseVisualStyleBackColor = false;
            btnConfirmarPreparacion.Location = new Point(14, 96);
            btnConfirmarPreparacion.Name = "btnConfirmarPreparacion";
            btnConfirmarPreparacion.Size = new Size(200, 34);
            btnConfirmarPreparacion.TabIndex = 37;
            // 
            // btnReimprimir
            // 
            btnReimprimir.Text = "Reimprimir";
            btnReimprimir.UseVisualStyleBackColor = true;
            btnReimprimir.Location = new Point(222, 96);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(110, 34);
            btnReimprimir.TabIndex = 38;
            // 
            // btnReportarIncidente
            // 
            btnReportarIncidente.Text = "Incidente";
            btnReportarIncidente.UseVisualStyleBackColor = true;
            btnReportarIncidente.Location = new Point(340, 96);
            btnReportarIncidente.Name = "btnReportarIncidente";
            btnReportarIncidente.Size = new Size(104, 34);
            btnReportarIncidente.TabIndex = 39;
            // 
            // EmpaquetadoPreparacionEntregasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1334, 901);
            Controls.Add(pnlEncabezado);
            Controls.Add(grpContexto);
            Controls.Add(grpPedidos);
            Controls.Add(grpDatosPedido);
            Controls.Add(grpControl);
            Controls.Add(grpFulfillment);
            Controls.Add(grpPale);
            Controls.Add(grpCierre);
            Font = new Font("Segoe UI", 9F);
            AutoScroll = true;
            AutoScrollMinSize = new Size(1334, 901);
            MinimumSize = new Size(640, 480);
            WindowState = FormWindowState.Maximized;
            Name = "EmpaquetadoPreparacionEntregasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Empaquetado y Preparación de Entregas";
            grpCierre.ResumeLayout(false);
            grpPale.ResumeLayout(false);
            grpFulfillment.ResumeLayout(false);
            grpControl.ResumeLayout(false);
            grpDatosPedido.ResumeLayout(false);
            grpPedidos.ResumeLayout(false);
            grpContexto.ResumeLayout(false);
            pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBultos).EndInit();
            ResumeLayout(false);
            dgvControl.Rows.Add("SKU-001", "Remera de algodón", "80", "80", "", "");
            dgvBultos.Rows.Add("B-001", "SKU-001", "Remera de algodón", "50");
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
        private System.Windows.Forms.GroupBox grpPedidos;
        private System.Windows.Forms.ListView lvPedidosEnPreparacion;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol0;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol1;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol2;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol3;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol4;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol5;
        private System.Windows.Forms.GroupBox grpDatosPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.DataGridView dgvControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntregada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colControlada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiferencia;
        private System.Windows.Forms.GroupBox grpFulfillment;
        private System.Windows.Forms.Label lblIdBulto;
        private System.Windows.Forms.TextBox txtIdBulto;
        private System.Windows.Forms.Label lblSkuBulto;
        private System.Windows.Forms.ComboBox cboSkuBulto;
        private System.Windows.Forms.Label lblCantBulto;
        private System.Windows.Forms.TextBox txtCantBulto;
        private System.Windows.Forms.Button btnAgregarBulto;
        private System.Windows.Forms.DataGridView dgvBultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkuBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantBulto;
        private System.Windows.Forms.GroupBox grpPale;
        private System.Windows.Forms.Label lblIdPale;
        private System.Windows.Forms.TextBox txtIdPale;
        private System.Windows.Forms.CheckBox chkPaleConforme;
        private System.Windows.Forms.GroupBox grpCierre;
        private System.Windows.Forms.CheckBox chkListo;
        private System.Windows.Forms.Label lblOrdenEntrega;
        private System.Windows.Forms.TextBox txtOrdenEntrega;
        private System.Windows.Forms.Button btnConfirmarPreparacion;
        private System.Windows.Forms.Button btnReimprimir;
        private System.Windows.Forms.Button btnReportarIncidente;
    }
}
