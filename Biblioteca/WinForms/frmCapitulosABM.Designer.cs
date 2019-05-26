namespace Biblioteca.WinForms
{
    partial class frmCapitulosABM
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
            this.panelEditor = new System.Windows.Forms.Panel();
            this.richTexCapitulo = new DevExpress.XtraRichEdit.RichEditControl();
            this.grcCapitulos = new DevExpress.XtraGrid.GridControl();
            this.bsListaCapitulos = new System.Windows.Forms.BindingSource(this.components);
            this.grvCapitulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Libro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCapitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaCapitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCapitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditor
            // 
            this.panelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditor.Controls.Add(this.richTexCapitulo);
            this.panelEditor.Location = new System.Drawing.Point(268, 12);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(903, 564);
            this.panelEditor.TabIndex = 0;
            // 
            // richTexCapitulo
            // 
            this.richTexCapitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTexCapitulo.Location = new System.Drawing.Point(0, 0);
            this.richTexCapitulo.Name = "richTexCapitulo";
            this.richTexCapitulo.ReadOnly = true;
            this.richTexCapitulo.Size = new System.Drawing.Size(903, 564);
            this.richTexCapitulo.TabIndex = 0;
            // 
            // grcCapitulos
            // 
            this.grcCapitulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grcCapitulos.DataSource = this.bsListaCapitulos;
            this.grcCapitulos.Location = new System.Drawing.Point(13, 42);
            this.grcCapitulos.MainView = this.grvCapitulos;
            this.grcCapitulos.Name = "grcCapitulos";
            this.grcCapitulos.Size = new System.Drawing.Size(249, 534);
            this.grcCapitulos.TabIndex = 1;
            this.grcCapitulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCapitulos});
            // 
            // bsListaCapitulos
            // 
            this.bsListaCapitulos.DataSource = typeof(DominioClases.Clases.Capitulo);
            // 
            // grvCapitulos
            // 
            this.grvCapitulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFecha_Add,
            this.colId_Libro,
            this.colTitulo});
            this.grvCapitulos.GridControl = this.grcCapitulos;
            this.grvCapitulos.Name = "grvCapitulos";
            this.grvCapitulos.OptionsView.ShowGroupPanel = false;
            this.grvCapitulos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvCapitulos_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 46;
            // 
            // colFecha_Add
            // 
            this.colFecha_Add.Caption = "Fecha";
            this.colFecha_Add.FieldName = "Fecha_Add";
            this.colFecha_Add.Name = "colFecha_Add";
            this.colFecha_Add.OptionsColumn.AllowEdit = false;
            this.colFecha_Add.OptionsColumn.ReadOnly = true;
            this.colFecha_Add.Visible = true;
            this.colFecha_Add.VisibleIndex = 1;
            this.colFecha_Add.Width = 72;
            // 
            // colId_Libro
            // 
            this.colId_Libro.FieldName = "Id_Libro";
            this.colId_Libro.Name = "colId_Libro";
            this.colId_Libro.OptionsColumn.AllowEdit = false;
            this.colId_Libro.OptionsColumn.ReadOnly = true;
            // 
            // colTitulo
            // 
            this.colTitulo.FieldName = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.OptionsColumn.AllowEdit = false;
            this.colTitulo.OptionsColumn.ReadOnly = true;
            this.colTitulo.Visible = true;
            this.colTitulo.VisibleIndex = 2;
            this.colTitulo.Width = 113;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(186, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(100, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCapitulosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 588);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grcCapitulos);
            this.Controls.Add(this.panelEditor);
            this.Name = "frmCapitulosABM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCapitulosABM";
            this.Load += new System.EventHandler(this.frmCapitulosABM_Load);
            this.panelEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcCapitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaCapitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCapitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditor;
        private DevExpress.XtraGrid.GridControl grcCapitulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCapitulos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.BindingSource bsListaCapitulos;
        private DevExpress.XtraRichEdit.RichEditControl richTexCapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Libro;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo;
    }
}