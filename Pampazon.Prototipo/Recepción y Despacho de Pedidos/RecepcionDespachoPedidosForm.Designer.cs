namespace Pampazon.Prototipo
{
    partial class RecepcionDespachoPedidosForm
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
            ListViewItem item_lvPreparadas_0 = new ListViewItem(new string[] { "OE-000051", "OP-000181", "Cliente Demo A", "Cliente", "Destino demo A", "2", "PREPARADA" }, -1);
            ListViewItem item_lvPreparadas_1 = new ListViewItem(new string[] { "OE-000052", "TR-000026", "Cliente Demo A", "Traslado interno", "Destino demo B", "1", "PREPARADA" }, -1);
            ListViewItem item_lvEnDespacho_0 = new ListViewItem(new string[] { "OE-000051", "OP-000181", "Cliente Demo A", "Cliente", "Destino demo A", "2", "EN DESPACHO" }, -1);
            ListViewItem item_lvEnDespacho_1 = new ListViewItem(new string[] { "OE-000052", "TR-000026", "Cliente Demo A", "Traslado interno", "Destino demo B", "1", "EN DESPACHO" }, -1);
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            tabDespachoPedidos = new TabControl();
            tabRecepcion = new TabPage();
            grpBuscarEntrega = new GroupBox();
            lblBuscarEntrega = new Label();
            txtBuscarEntrega = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblListaPreparadas = new Label();
            lvPreparadas = new ListView();
            lvPreparadasCol0 = new ColumnHeader();
            lvPreparadasCol1 = new ColumnHeader();
            lvPreparadasCol2 = new ColumnHeader();
            lvPreparadasCol3 = new ColumnHeader();
            lvPreparadasCol4 = new ColumnHeader();
            lvPreparadasCol5 = new ColumnHeader();
            lvPreparadasCol6 = new ColumnHeader();
            grpControlRecepcion = new GroupBox();
            dgvControlRecepcion = new DataGridView();
            colSkuR = new DataGridViewTextBoxColumn();
            colProductoR = new DataGridViewTextBoxColumn();
            colCantOrden = new DataGridViewTextBoxColumn();
            colRecibida = new DataGridViewTextBoxColumn();
            colDifR = new DataGridViewTextBoxColumn();
            lblObsRecepcion = new Label();
            txtObsRecepcion = new TextBox();
            chkRecepcionCompleta = new CheckBox();
            btnConfirmarRecepcion = new Button();
            btnReportarIncidenteRecepcion = new Button();
            tabDespacho = new TabPage();
            lblListaEnDespacho = new Label();
            lvEnDespacho = new ListView();
            lvEnDespachoCol0 = new ColumnHeader();
            lvEnDespachoCol1 = new ColumnHeader();
            lvEnDespachoCol2 = new ColumnHeader();
            lvEnDespachoCol3 = new ColumnHeader();
            lvEnDespachoCol4 = new ColumnHeader();
            lvEnDespachoCol5 = new ColumnHeader();
            lvEnDespachoCol6 = new ColumnHeader();
            grpRetiro = new GroupBox();
            lblTransportista = new Label();
            txtTransportista = new TextBox();
            lblFlete = new Label();
            txtFlete = new TextBox();
            lblFechaRetiro = new Label();
            dtpRetiro = new DateTimePicker();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            btnEmitirDocumento = new Button();
            chkConformidad = new CheckBox();
            lblAvisoDespacho = new Label();
            btnCerrarDespacho = new Button();
            btnReportarIncidenteDespacho = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvControlRecepcion).BeginInit();
            pnlEncabezado.SuspendLayout();
            grpContexto.SuspendLayout();
            tabDespachoPedidos.SuspendLayout();
            tabRecepcion.SuspendLayout();
            grpBuscarEntrega.SuspendLayout();
            grpControlRecepcion.SuspendLayout();
            tabDespacho.SuspendLayout();
            grpRetiro.SuspendLayout();
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
            lblTitulo.Text = "Recepción y Despacho de Pedidos";
            lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            lblEmpresa.Text = "PAMPAZON  |  Operario de Despacho";
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
            lblRol.Text = "Rol: Operario de Despacho";
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
            // tabDespachoPedidos
            // 
            tabDespachoPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabDespachoPedidos.Controls.Add(tabRecepcion);
            tabDespachoPedidos.Controls.Add(tabDespacho);
            tabDespachoPedidos.SelectedIndex = 0;
            tabDespachoPedidos.Location = new Point(16, 170);
            tabDespachoPedidos.Name = "tabDespachoPedidos";
            tabDespachoPedidos.Size = new Size(1288, 684);
            tabDespachoPedidos.TabIndex = 9;
            // 
            // tabRecepcion
            // 
            tabRecepcion.Controls.Add(grpBuscarEntrega);
            tabRecepcion.Controls.Add(lblListaPreparadas);
            tabRecepcion.Controls.Add(lvPreparadas);
            tabRecepcion.Controls.Add(grpControlRecepcion);
            tabRecepcion.Controls.Add(lblObsRecepcion);
            tabRecepcion.Controls.Add(txtObsRecepcion);
            tabRecepcion.Controls.Add(chkRecepcionCompleta);
            tabRecepcion.Controls.Add(btnConfirmarRecepcion);
            tabRecepcion.Controls.Add(btnReportarIncidenteRecepcion);
            tabRecepcion.Text = "Recepción de preparados";
            tabRecepcion.UseVisualStyleBackColor = true;
            tabRecepcion.Location = new Point(4, 24);
            tabRecepcion.Name = "tabRecepcion";
            tabRecepcion.Size = new Size(1280, 656);
            tabRecepcion.TabIndex = 10;
            // 
            // grpBuscarEntrega
            // 
            grpBuscarEntrega.Controls.Add(lblBuscarEntrega);
            grpBuscarEntrega.Controls.Add(txtBuscarEntrega);
            grpBuscarEntrega.Controls.Add(btnBuscar);
            grpBuscarEntrega.Controls.Add(btnLimpiar);
            grpBuscarEntrega.TabStop = false;
            grpBuscarEntrega.Text = "Buscar orden de entrega";
            grpBuscarEntrega.Location = new Point(12, 10);
            grpBuscarEntrega.Name = "grpBuscarEntrega";
            grpBuscarEntrega.Size = new Size(1250, 80);
            grpBuscarEntrega.TabIndex = 11;
            // 
            // lblBuscarEntrega
            // 
            lblBuscarEntrega.Text = "N.º de orden de entrega";
            lblBuscarEntrega.Location = new Point(14, 22);
            lblBuscarEntrega.Name = "lblBuscarEntrega";
            lblBuscarEntrega.Size = new Size(200, 22);
            lblBuscarEntrega.TabIndex = 12;
            // 
            // txtBuscarEntrega
            // 
            txtBuscarEntrega.MaxLength = 30;
            txtBuscarEntrega.Location = new Point(14, 45);
            txtBuscarEntrega.Name = "txtBuscarEntrega";
            txtBuscarEntrega.Size = new Size(200, 23);
            txtBuscarEntrega.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(35, 80, 124);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Location = new Point(230, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(160, 34);
            btnBuscar.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Location = new Point(400, 38);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 34);
            btnLimpiar.TabIndex = 15;
            // 
            // lblListaPreparadas
            // 
            lblListaPreparadas.Text = "Órdenes de entrega de pedidos preparados";
            lblListaPreparadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListaPreparadas.Location = new Point(14, 102);
            lblListaPreparadas.Name = "lblListaPreparadas";
            lblListaPreparadas.Size = new Size(950, 24);
            lblListaPreparadas.TabIndex = 16;
            // 
            // lvPreparadas
            // 
            lvPreparadas.Columns.AddRange(new ColumnHeader[] { lvPreparadasCol0, lvPreparadasCol1, lvPreparadasCol2, lvPreparadasCol3, lvPreparadasCol4, lvPreparadasCol5, lvPreparadasCol6 });
            lvPreparadas.FullRowSelect = true;
            lvPreparadas.GridLines = true;
            lvPreparadas.Items.AddRange(new ListViewItem[] { item_lvPreparadas_0, item_lvPreparadas_1 });
            lvPreparadas.Location = new Point(14, 132);
            lvPreparadas.Name = "lvPreparadas";
            lvPreparadas.Size = new Size(1248, 130);
            lvPreparadas.TabIndex = 17;
            lvPreparadas.UseCompatibleStateImageBehavior = false;
            lvPreparadas.View = View.Details;
            // 
            // lvPreparadasCol0
            // 
            lvPreparadasCol0.Text = "N.º de orden de entrega";
            lvPreparadasCol0.Width = 160;
            // 
            // lvPreparadasCol1
            // 
            lvPreparadasCol1.Text = "Pedido";
            lvPreparadasCol1.Width = 110;
            // 
            // lvPreparadasCol2
            // 
            lvPreparadasCol2.Text = "Cliente";
            lvPreparadasCol2.Width = 220;
            // 
            // lvPreparadasCol3
            // 
            lvPreparadasCol3.Text = "Origen";
            lvPreparadasCol3.Width = 150;
            // 
            // lvPreparadasCol4
            // 
            lvPreparadasCol4.Text = "Destino";
            lvPreparadasCol4.Width = 250;
            // 
            // lvPreparadasCol5
            // 
            lvPreparadasCol5.Text = "Bultos";
            lvPreparadasCol5.Width = 90;
            // 
            // lvPreparadasCol6
            // 
            lvPreparadasCol6.Text = "Estado";
            lvPreparadasCol6.Width = 140;
            // 
            // grpControlRecepcion
            // 
            grpControlRecepcion.Controls.Add(dgvControlRecepcion);
            grpControlRecepcion.TabStop = false;
            grpControlRecepcion.Text = "Control de bultos recibidos";
            grpControlRecepcion.Location = new Point(12, 274);
            grpControlRecepcion.Name = "grpControlRecepcion";
            grpControlRecepcion.Size = new Size(1250, 200);
            grpControlRecepcion.TabIndex = 18;
            // 
            // dgvControlRecepcion
            // 
            dgvControlRecepcion.AllowUserToAddRows = false;
            dgvControlRecepcion.AllowUserToDeleteRows = false;
            dgvControlRecepcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvControlRecepcion.Columns.AddRange(new DataGridViewColumn[] { colSkuR, colProductoR, colCantOrden, colRecibida, colDifR });
            dgvControlRecepcion.RowHeadersVisible = false;
            dgvControlRecepcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlRecepcion.Location = new Point(12, 24);
            dgvControlRecepcion.Name = "dgvControlRecepcion";
            dgvControlRecepcion.Size = new Size(1224, 160);
            dgvControlRecepcion.TabIndex = 19;
            // 
            // colSkuR
            // 
            colSkuR.HeaderText = "SKU";
            colSkuR.Name = "colSkuR";
            colSkuR.Width = 110;
            colSkuR.ReadOnly = true;
            // 
            // colProductoR
            // 
            colProductoR.HeaderText = "Producto";
            colProductoR.Name = "colProductoR";
            colProductoR.Width = 300;
            colProductoR.ReadOnly = true;
            // 
            // colCantOrden
            // 
            colCantOrden.HeaderText = "Cantidad según la orden";
            colCantOrden.Name = "colCantOrden";
            colCantOrden.Width = 200;
            colCantOrden.ReadOnly = true;
            // 
            // colRecibida
            // 
            colRecibida.HeaderText = "Cantidad recibida";
            colRecibida.Name = "colRecibida";
            colRecibida.Width = 170;
            // 
            // colDifR
            // 
            colDifR.HeaderText = "Diferencia";
            colDifR.Name = "colDifR";
            colDifR.Width = 140;
            colDifR.ReadOnly = true;
            // 
            // lblObsRecepcion
            // 
            lblObsRecepcion.Text = "Observación de recepción (hasta 200 caracteres)";
            lblObsRecepcion.Location = new Point(14, 486);
            lblObsRecepcion.Name = "lblObsRecepcion";
            lblObsRecepcion.Size = new Size(400, 20);
            lblObsRecepcion.TabIndex = 20;
            // 
            // txtObsRecepcion
            // 
            txtObsRecepcion.Multiline = true;
            txtObsRecepcion.MaxLength = 200;
            txtObsRecepcion.Location = new Point(14, 508);
            txtObsRecepcion.Name = "txtObsRecepcion";
            txtObsRecepcion.Size = new Size(700, 60);
            txtObsRecepcion.TabIndex = 21;
            // 
            // chkRecepcionCompleta
            // 
            chkRecepcionCompleta.Text = "Los preparados se recibieron completos y conformes";
            chkRecepcionCompleta.UseVisualStyleBackColor = true;
            chkRecepcionCompleta.Location = new Point(740, 510);
            chkRecepcionCompleta.Name = "chkRecepcionCompleta";
            chkRecepcionCompleta.Size = new Size(500, 24);
            chkRecepcionCompleta.TabIndex = 22;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.BackColor = Color.FromArgb(35, 80, 124);
            btnConfirmarRecepcion.FlatStyle = FlatStyle.Flat;
            btnConfirmarRecepcion.ForeColor = Color.White;
            btnConfirmarRecepcion.Text = "Confirmar recepción";
            btnConfirmarRecepcion.UseVisualStyleBackColor = false;
            btnConfirmarRecepcion.Location = new Point(14, 580);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(417, 34);
            btnConfirmarRecepcion.TabIndex = 23;
            // 
            // btnReportarIncidenteRecepcion
            // 
            btnReportarIncidenteRecepcion.Text = "Reportar incidente";
            btnReportarIncidenteRecepcion.UseVisualStyleBackColor = true;
            btnReportarIncidenteRecepcion.Location = new Point(440, 580);
            btnReportarIncidenteRecepcion.Name = "btnReportarIncidenteRecepcion";
            btnReportarIncidenteRecepcion.Size = new Size(300, 34);
            btnReportarIncidenteRecepcion.TabIndex = 24;
            // 
            // tabDespacho
            // 
            tabDespacho.Controls.Add(lblListaEnDespacho);
            tabDespacho.Controls.Add(lvEnDespacho);
            tabDespacho.Controls.Add(grpRetiro);
            tabDespacho.Controls.Add(btnCerrarDespacho);
            tabDespacho.Controls.Add(btnReportarIncidenteDespacho);
            tabDespacho.Text = "Retiro y cierre del despacho";
            tabDespacho.UseVisualStyleBackColor = true;
            tabDespacho.Location = new Point(4, 24);
            tabDespacho.Name = "tabDespacho";
            tabDespacho.Size = new Size(1280, 656);
            tabDespacho.TabIndex = 25;
            // 
            // lblListaEnDespacho
            // 
            lblListaEnDespacho.Text = "Órdenes de entrega disponibles para el retiro";
            lblListaEnDespacho.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListaEnDespacho.Location = new Point(14, 12);
            lblListaEnDespacho.Name = "lblListaEnDespacho";
            lblListaEnDespacho.Size = new Size(950, 24);
            lblListaEnDespacho.TabIndex = 26;
            // 
            // lvEnDespacho
            // 
            lvEnDespacho.Columns.AddRange(new ColumnHeader[] { lvEnDespachoCol0, lvEnDespachoCol1, lvEnDespachoCol2, lvEnDespachoCol3, lvEnDespachoCol4, lvEnDespachoCol5, lvEnDespachoCol6 });
            lvEnDespacho.FullRowSelect = true;
            lvEnDespacho.GridLines = true;
            lvEnDespacho.Items.AddRange(new ListViewItem[] { item_lvEnDespacho_0, item_lvEnDespacho_1 });
            lvEnDespacho.Location = new Point(14, 40);
            lvEnDespacho.Name = "lvEnDespacho";
            lvEnDespacho.Size = new Size(1248, 150);
            lvEnDespacho.TabIndex = 27;
            lvEnDespacho.UseCompatibleStateImageBehavior = false;
            lvEnDespacho.View = View.Details;
            // 
            // lvEnDespachoCol0
            // 
            lvEnDespachoCol0.Text = "N.º de orden de entrega";
            lvEnDespachoCol0.Width = 160;
            // 
            // lvEnDespachoCol1
            // 
            lvEnDespachoCol1.Text = "Pedido";
            lvEnDespachoCol1.Width = 110;
            // 
            // lvEnDespachoCol2
            // 
            lvEnDespachoCol2.Text = "Cliente";
            lvEnDespachoCol2.Width = 220;
            // 
            // lvEnDespachoCol3
            // 
            lvEnDespachoCol3.Text = "Origen";
            lvEnDespachoCol3.Width = 150;
            // 
            // lvEnDespachoCol4
            // 
            lvEnDespachoCol4.Text = "Destino";
            lvEnDespachoCol4.Width = 250;
            // 
            // lvEnDespachoCol5
            // 
            lvEnDespachoCol5.Text = "Bultos";
            lvEnDespachoCol5.Width = 90;
            // 
            // lvEnDespachoCol6
            // 
            lvEnDespachoCol6.Text = "Estado";
            lvEnDespachoCol6.Width = 140;
            // 
            // grpRetiro
            // 
            grpRetiro.Controls.Add(lblTransportista);
            grpRetiro.Controls.Add(txtTransportista);
            grpRetiro.Controls.Add(lblFlete);
            grpRetiro.Controls.Add(txtFlete);
            grpRetiro.Controls.Add(lblFechaRetiro);
            grpRetiro.Controls.Add(dtpRetiro);
            grpRetiro.Controls.Add(lblDocumento);
            grpRetiro.Controls.Add(txtDocumento);
            grpRetiro.Controls.Add(btnEmitirDocumento);
            grpRetiro.Controls.Add(chkConformidad);
            grpRetiro.Controls.Add(lblAvisoDespacho);
            grpRetiro.TabStop = false;
            grpRetiro.Text = "Retiro y cierre del despacho";
            grpRetiro.Location = new Point(12, 204);
            grpRetiro.Name = "grpRetiro";
            grpRetiro.Size = new Size(1250, 330);
            grpRetiro.TabIndex = 28;
            // 
            // lblTransportista
            // 
            lblTransportista.Text = "Identificación del transportista";
            lblTransportista.Location = new Point(14, 30);
            lblTransportista.Name = "lblTransportista";
            lblTransportista.Size = new Size(300, 20);
            lblTransportista.TabIndex = 29;
            // 
            // txtTransportista
            // 
            txtTransportista.MaxLength = 60;
            txtTransportista.Location = new Point(14, 52);
            txtTransportista.Name = "txtTransportista";
            txtTransportista.Size = new Size(320, 23);
            txtTransportista.TabIndex = 30;
            // 
            // lblFlete
            // 
            lblFlete.Text = "Referencia del flete (traslados)";
            lblFlete.Location = new Point(360, 30);
            lblFlete.Name = "lblFlete";
            lblFlete.Size = new Size(260, 20);
            lblFlete.TabIndex = 31;
            // 
            // txtFlete
            // 
            txtFlete.MaxLength = 20;
            txtFlete.Location = new Point(360, 52);
            txtFlete.Name = "txtFlete";
            txtFlete.Size = new Size(240, 23);
            txtFlete.TabIndex = 32;
            // 
            // lblFechaRetiro
            // 
            lblFechaRetiro.Text = "Fecha de retiro";
            lblFechaRetiro.Location = new Point(630, 30);
            lblFechaRetiro.Name = "lblFechaRetiro";
            lblFechaRetiro.Size = new Size(200, 20);
            lblFechaRetiro.TabIndex = 33;
            // 
            // dtpRetiro
            // 
            dtpRetiro.Format = DateTimePickerFormat.Short;
            dtpRetiro.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            dtpRetiro.Location = new Point(630, 52);
            dtpRetiro.Name = "dtpRetiro";
            dtpRetiro.Size = new Size(170, 23);
            dtpRetiro.TabIndex = 34;
            // 
            // lblDocumento
            // 
            lblDocumento.Text = "Documento de salida";
            lblDocumento.Location = new Point(14, 100);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(200, 20);
            lblDocumento.TabIndex = 35;
            // 
            // txtDocumento
            // 
            txtDocumento.ReadOnly = true;
            txtDocumento.Location = new Point(14, 122);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(240, 23);
            txtDocumento.TabIndex = 36;
            // 
            // btnEmitirDocumento
            // 
            btnEmitirDocumento.BackColor = Color.FromArgb(35, 80, 124);
            btnEmitirDocumento.FlatStyle = FlatStyle.Flat;
            btnEmitirDocumento.ForeColor = Color.White;
            btnEmitirDocumento.Text = "Emitir remito / guía de traslado";
            btnEmitirDocumento.UseVisualStyleBackColor = false;
            btnEmitirDocumento.Location = new Point(270, 116);
            btnEmitirDocumento.Name = "btnEmitirDocumento";
            btnEmitirDocumento.Size = new Size(300, 34);
            btnEmitirDocumento.TabIndex = 37;
            // 
            // chkConformidad
            // 
            chkConformidad.Text = "El transportista presta conformidad de retiro";
            chkConformidad.UseVisualStyleBackColor = true;
            chkConformidad.Location = new Point(14, 176);
            chkConformidad.Name = "chkConformidad";
            chkConformidad.Size = new Size(600, 24);
            chkConformidad.TabIndex = 38;
            // 
            // lblAvisoDespacho
            // 
            lblAvisoDespacho.Text = "Emitir o imprimir el documento no descuenta stock. El egreso se registra una sola vez al cerrar el despacho.";
            lblAvisoDespacho.Location = new Point(14, 214);
            lblAvisoDespacho.Name = "lblAvisoDespacho";
            lblAvisoDespacho.Size = new Size(1200, 24);
            lblAvisoDespacho.TabIndex = 39;
            // 
            // btnCerrarDespacho
            // 
            btnCerrarDespacho.BackColor = Color.FromArgb(35, 80, 124);
            btnCerrarDespacho.FlatStyle = FlatStyle.Flat;
            btnCerrarDespacho.ForeColor = Color.White;
            btnCerrarDespacho.Text = "Cerrar despacho";
            btnCerrarDespacho.UseVisualStyleBackColor = false;
            btnCerrarDespacho.Location = new Point(16, 550);
            btnCerrarDespacho.Name = "btnCerrarDespacho";
            btnCerrarDespacho.Size = new Size(417, 34);
            btnCerrarDespacho.TabIndex = 40;
            // 
            // btnReportarIncidenteDespacho
            // 
            btnReportarIncidenteDespacho.Text = "Reportar incidente";
            btnReportarIncidenteDespacho.UseVisualStyleBackColor = true;
            btnReportarIncidenteDespacho.Location = new Point(449, 550);
            btnReportarIncidenteDespacho.Name = "btnReportarIncidenteDespacho";
            btnReportarIncidenteDespacho.Size = new Size(300, 34);
            btnReportarIncidenteDespacho.TabIndex = 41;
            // 
            // RecepcionDespachoPedidosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1334, 901);
            Controls.Add(pnlEncabezado);
            Controls.Add(grpContexto);
            Controls.Add(tabDespachoPedidos);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1350, 940);
            Name = "RecepcionDespachoPedidosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Recepción y Despacho de Pedidos";
            grpRetiro.ResumeLayout(false);
            tabDespacho.ResumeLayout(false);
            grpControlRecepcion.ResumeLayout(false);
            grpBuscarEntrega.ResumeLayout(false);
            tabRecepcion.ResumeLayout(false);
            tabDespachoPedidos.ResumeLayout(false);
            grpContexto.ResumeLayout(false);
            pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvControlRecepcion).EndInit();
            ResumeLayout(false);
            dgvControlRecepcion.Rows.Add("SKU-001", "Remera de algodón", "80", "", "");
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
        private System.Windows.Forms.TabControl tabDespachoPedidos;
        private System.Windows.Forms.TabPage tabRecepcion;
        private System.Windows.Forms.GroupBox grpBuscarEntrega;
        private System.Windows.Forms.Label lblBuscarEntrega;
        private System.Windows.Forms.TextBox txtBuscarEntrega;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblListaPreparadas;
        private System.Windows.Forms.ListView lvPreparadas;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol0;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol1;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol2;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol3;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol4;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol5;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol6;
        private System.Windows.Forms.GroupBox grpControlRecepcion;
        private System.Windows.Forms.DataGridView dgvControlRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkuR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifR;
        private System.Windows.Forms.Label lblObsRecepcion;
        private System.Windows.Forms.TextBox txtObsRecepcion;
        private System.Windows.Forms.CheckBox chkRecepcionCompleta;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.Button btnReportarIncidenteRecepcion;
        private System.Windows.Forms.TabPage tabDespacho;
        private System.Windows.Forms.Label lblListaEnDespacho;
        private System.Windows.Forms.ListView lvEnDespacho;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol0;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol1;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol2;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol3;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol4;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol5;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol6;
        private System.Windows.Forms.GroupBox grpRetiro;
        private System.Windows.Forms.Label lblTransportista;
        private System.Windows.Forms.TextBox txtTransportista;
        private System.Windows.Forms.Label lblFlete;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtpRetiro;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnEmitirDocumento;
        private System.Windows.Forms.CheckBox chkConformidad;
        private System.Windows.Forms.Label lblAvisoDespacho;
        private System.Windows.Forms.Button btnCerrarDespacho;
        private System.Windows.Forms.Button btnReportarIncidenteDespacho;
    }
}
