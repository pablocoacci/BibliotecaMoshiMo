namespace Biblioteca.WinForms
{
    partial class frmBuscadorLibros
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verCapitulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCapitulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCapituloId = new DevExpress.XtraEditors.TextEdit();
            this.bsParamBusqueda = new System.Windows.Forms.BindingSource(this.components);
            this.txtCapituloTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLibroId = new DevExpress.XtraEditors.TextEdit();
            this.cboEstante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLibroTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grcLibrosBusqueda = new DevExpress.XtraGrid.GridControl();
            this.bsListaLibros = new System.Windows.Forms.BindingSource(this.components);
            this.grvLibrosBusqueda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Estanteria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colTotal_Capitulos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPublico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsFavorito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo_Estanteria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapituloId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsParamBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLibroId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcLibrosBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibrosBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCapitulosToolStripMenuItem,
            this.verCapitulosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verCapitulosToolStripMenuItem
            // 
            this.verCapitulosToolStripMenuItem.Name = "verCapitulosToolStripMenuItem";
            this.verCapitulosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.verCapitulosToolStripMenuItem.Text = "Ver Libro";
            this.verCapitulosToolStripMenuItem.Click += new System.EventHandler(this.verCapitulosToolStripMenuItem_Click);
            // 
            // verCapitulosToolStripMenuItem1
            // 
            this.verCapitulosToolStripMenuItem1.Name = "verCapitulosToolStripMenuItem1";
            this.verCapitulosToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.verCapitulosToolStripMenuItem1.Text = "Ver Capitulos";
            this.verCapitulosToolStripMenuItem1.Click += new System.EventHandler(this.verCapitulosToolStripMenuItem1_Click);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.btnLimpiar);
            this.panelBusqueda.Controls.Add(this.groupBox2);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.groupBox1);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 24);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(778, 87);
            this.panelBusqueda.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(691, 47);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCapituloId);
            this.groupBox2.Controls.Add(this.txtCapituloTitulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(332, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capitulo";
            // 
            // txtCapituloId
            // 
            this.txtCapituloId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsParamBusqueda, "Id_Capitulo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtCapituloId.Location = new System.Drawing.Point(48, 15);
            this.txtCapituloId.Name = "txtCapituloId";
            this.txtCapituloId.Properties.Mask.EditMask = "n0";
            this.txtCapituloId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCapituloId.Size = new System.Drawing.Size(167, 20);
            this.txtCapituloId.TabIndex = 9;
            // 
            // bsParamBusqueda
            // 
            this.bsParamBusqueda.DataSource = typeof(DominioClases.DAL.LibroDAL.ParamBusquedaLibro);
            // 
            // txtCapituloTitulo
            // 
            this.txtCapituloTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsParamBusqueda, "TituloCapitulo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCapituloTitulo.Location = new System.Drawing.Point(48, 41);
            this.txtCapituloTitulo.Name = "txtCapituloTitulo";
            this.txtCapituloTitulo.Size = new System.Drawing.Size(167, 20);
            this.txtCapituloTitulo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Id:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(691, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLibroId);
            this.groupBox1.Controls.Add(this.cboEstante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLibroTitulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Libro";
            // 
            // txtLibroId
            // 
            this.txtLibroId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsParamBusqueda, "Id_Libro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtLibroId.Location = new System.Drawing.Point(47, 16);
            this.txtLibroId.Name = "txtLibroId";
            this.txtLibroId.Properties.Mask.EditMask = "n0";
            this.txtLibroId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLibroId.Size = new System.Drawing.Size(100, 20);
            this.txtLibroId.TabIndex = 8;
            // 
            // cboEstante
            // 
            this.cboEstante.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsParamBusqueda, "Id_Estanteria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.cboEstante.DisplayMember = "Titulo_Estante";
            this.cboEstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstante.FormattingEnabled = true;
            this.cboEstante.Location = new System.Drawing.Point(205, 15);
            this.cboEstante.Name = "cboEstante";
            this.cboEstante.Size = new System.Drawing.Size(100, 21);
            this.cboEstante.TabIndex = 6;
            this.cboEstante.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estante:";
            // 
            // txtLibroTitulo
            // 
            this.txtLibroTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsParamBusqueda, "TituloLibro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLibroTitulo.Location = new System.Drawing.Point(47, 41);
            this.txtLibroTitulo.Name = "txtLibroTitulo";
            this.txtLibroTitulo.Size = new System.Drawing.Size(258, 20);
            this.txtLibroTitulo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // grcLibrosBusqueda
            // 
            this.grcLibrosBusqueda.DataSource = this.bsListaLibros;
            this.grcLibrosBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLibrosBusqueda.Location = new System.Drawing.Point(0, 111);
            this.grcLibrosBusqueda.MainView = this.grvLibrosBusqueda;
            this.grcLibrosBusqueda.Name = "grcLibrosBusqueda";
            this.grcLibrosBusqueda.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.grcLibrosBusqueda.Size = new System.Drawing.Size(778, 338);
            this.grcLibrosBusqueda.TabIndex = 2;
            this.grcLibrosBusqueda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLibrosBusqueda});
            // 
            // bsListaLibros
            // 
            this.bsListaLibros.DataSource = typeof(DominioClases.Clases.Libro);
            // 
            // grvLibrosBusqueda
            // 
            this.grvLibrosBusqueda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFecha_Add,
            this.colId_Estanteria,
            this.colId_Usuario,
            this.colTitulo,
            this.colDescripcion,
            this.colTotal_Capitulos,
            this.colIsPublico,
            this.colIsFavorito,
            this.colUsuario_Nombre,
            this.colTitulo_Estanteria,
            this.colLink});
            this.grvLibrosBusqueda.GridControl = this.grcLibrosBusqueda;
            this.grvLibrosBusqueda.Name = "grvLibrosBusqueda";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 45;
            // 
            // colFecha_Add
            // 
            this.colFecha_Add.FieldName = "Fecha_Add";
            this.colFecha_Add.Name = "colFecha_Add";
            this.colFecha_Add.OptionsColumn.AllowEdit = false;
            this.colFecha_Add.OptionsColumn.ReadOnly = true;
            this.colFecha_Add.Visible = true;
            this.colFecha_Add.VisibleIndex = 2;
            this.colFecha_Add.Width = 110;
            // 
            // colId_Estanteria
            // 
            this.colId_Estanteria.FieldName = "Id_Estanteria";
            this.colId_Estanteria.Name = "colId_Estanteria";
            this.colId_Estanteria.OptionsColumn.AllowEdit = false;
            this.colId_Estanteria.OptionsColumn.ReadOnly = true;
            // 
            // colId_Usuario
            // 
            this.colId_Usuario.FieldName = "Id_Usuario";
            this.colId_Usuario.Name = "colId_Usuario";
            this.colId_Usuario.OptionsColumn.AllowEdit = false;
            this.colId_Usuario.OptionsColumn.ReadOnly = true;
            // 
            // colTitulo
            // 
            this.colTitulo.FieldName = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.OptionsColumn.AllowEdit = false;
            this.colTitulo.OptionsColumn.ReadOnly = true;
            this.colTitulo.Visible = true;
            this.colTitulo.VisibleIndex = 3;
            this.colTitulo.Width = 495;
            // 
            // colDescripcion
            // 
            this.colDescripcion.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 4;
            this.colDescripcion.Width = 91;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colTotal_Capitulos
            // 
            this.colTotal_Capitulos.Caption = "Capitulos";
            this.colTotal_Capitulos.FieldName = "Total_Capitulos";
            this.colTotal_Capitulos.Name = "colTotal_Capitulos";
            this.colTotal_Capitulos.OptionsColumn.AllowEdit = false;
            this.colTotal_Capitulos.OptionsColumn.ReadOnly = true;
            this.colTotal_Capitulos.Visible = true;
            this.colTotal_Capitulos.VisibleIndex = 5;
            this.colTotal_Capitulos.Width = 74;
            // 
            // colIsPublico
            // 
            this.colIsPublico.Caption = "Publico";
            this.colIsPublico.FieldName = "IsPublico";
            this.colIsPublico.Name = "colIsPublico";
            this.colIsPublico.OptionsColumn.AllowEdit = false;
            this.colIsPublico.OptionsColumn.ReadOnly = true;
            this.colIsPublico.Visible = true;
            this.colIsPublico.VisibleIndex = 6;
            this.colIsPublico.Width = 69;
            // 
            // colIsFavorito
            // 
            this.colIsFavorito.Caption = "Favorito";
            this.colIsFavorito.FieldName = "IsFavorito";
            this.colIsFavorito.Name = "colIsFavorito";
            this.colIsFavorito.OptionsColumn.AllowEdit = false;
            this.colIsFavorito.OptionsColumn.ReadOnly = true;
            this.colIsFavorito.Visible = true;
            this.colIsFavorito.VisibleIndex = 7;
            this.colIsFavorito.Width = 74;
            // 
            // colUsuario_Nombre
            // 
            this.colUsuario_Nombre.Caption = "Usuario";
            this.colUsuario_Nombre.FieldName = "Usuario_Nombre";
            this.colUsuario_Nombre.Name = "colUsuario_Nombre";
            this.colUsuario_Nombre.OptionsColumn.AllowEdit = false;
            this.colUsuario_Nombre.OptionsColumn.ReadOnly = true;
            this.colUsuario_Nombre.Width = 135;
            // 
            // colTitulo_Estanteria
            // 
            this.colTitulo_Estanteria.Caption = "Estanteria";
            this.colTitulo_Estanteria.FieldName = "Titulo_Estanteria";
            this.colTitulo_Estanteria.Name = "colTitulo_Estanteria";
            this.colTitulo_Estanteria.OptionsColumn.AllowEdit = false;
            this.colTitulo_Estanteria.OptionsColumn.ReadOnly = true;
            this.colTitulo_Estanteria.Visible = true;
            this.colTitulo_Estanteria.VisibleIndex = 1;
            this.colTitulo_Estanteria.Width = 104;
            // 
            // colLink
            // 
            this.colLink.FieldName = "Link";
            this.colLink.Name = "colLink";
            this.colLink.OptionsColumn.AllowEdit = false;
            this.colLink.OptionsColumn.ReadOnly = true;
            // 
            // frmBuscadorLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 449);
            this.Controls.Add(this.grcLibrosBusqueda);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBuscadorLibros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Libros";
            this.Load += new System.EventHandler(this.frmBuscadorLibros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapituloId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsParamBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLibroId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcLibrosBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibrosBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verCapitulosToolStripMenuItem;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtLibroTitulo;
        private DevExpress.XtraGrid.GridControl grcLibrosBusqueda;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLibrosBusqueda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCapituloTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEstante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem verCapitulosToolStripMenuItem1;
        private System.Windows.Forms.BindingSource bsParamBusqueda;
        private System.Windows.Forms.BindingSource bsListaLibros;
        private DevExpress.XtraEditors.TextEdit txtCapituloId;
        private DevExpress.XtraEditors.TextEdit txtLibroId;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Estanteria;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Capitulos;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPublico;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFavorito;
        private System.Windows.Forms.Button btnLimpiar;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo_Estanteria;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}