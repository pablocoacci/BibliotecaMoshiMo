namespace Biblioteca
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTipoEstanteAddMod = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoEstante = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarEstante = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarEstante = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoLibro = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarLibro = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarLibro = new DevExpress.XtraBars.BarButtonItem();
            this.btnVerCapitulo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLibroFavorito = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuscarLibro = new DevExpress.XtraBars.BarButtonItem();
            this.btnVerLibrosFavoritos = new DevExpress.XtraBars.BarButtonItem();
            this.btnVerRepositorioDocs = new DevExpress.XtraBars.BarButtonItem();
            this.btnVerLogError = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grcEstanteria = new DevExpress.XtraGrid.GridControl();
            this.bsListaEstantes = new System.Windows.Forms.BindingSource(this.components);
            this.grvEstanteria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo_Estante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colTipo_Estante_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grcLibros = new DevExpress.XtraGrid.GridControl();
            this.bsListaLibros = new System.Windows.Forms.BindingSource(this.components);
            this.grvLibros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Capitulos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPublico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsFavorito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFavorito = new System.Windows.Forms.CheckBox();
            this.bsLibroSelect = new System.Windows.Forms.BindingSource(this.components);
            this.lnkLibro = new System.Windows.Forms.LinkLabel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.chkPublico = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcEstanteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaEstantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEstanteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibros)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibroSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnTipoEstanteAddMod,
            this.btnNuevoEstante,
            this.btnModificarEstante,
            this.btnUsuarios,
            this.btnEliminarEstante,
            this.btnNuevoLibro,
            this.btnEditarLibro,
            this.btnEliminarLibro,
            this.btnVerCapitulo,
            this.btnLibroFavorito,
            this.btnBuscarLibro,
            this.btnVerLibrosFavoritos,
            this.btnVerRepositorioDocs,
            this.btnVerLogError});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1132, 141);
            // 
            // btnTipoEstanteAddMod
            // 
            this.btnTipoEstanteAddMod.Caption = "Tipo Estante ABM";
            this.btnTipoEstanteAddMod.Id = 1;
            this.btnTipoEstanteAddMod.ImageOptions.DisabledImage = ((System.Drawing.Image)(resources.GetObject("btnTipoEstanteAddMod.ImageOptions.DisabledImage")));
            this.btnTipoEstanteAddMod.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoEstanteAddMod.ImageOptions.Image")));
            this.btnTipoEstanteAddMod.Name = "btnTipoEstanteAddMod";
            this.btnTipoEstanteAddMod.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTipoEstanteAddMod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTipoEstanteAddMod_ItemClick);
            // 
            // btnNuevoEstante
            // 
            this.btnNuevoEstante.Caption = "Nuevo Estante";
            this.btnNuevoEstante.Id = 2;
            this.btnNuevoEstante.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEstante.ImageOptions.Image")));
            this.btnNuevoEstante.Name = "btnNuevoEstante";
            this.btnNuevoEstante.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNuevoEstante.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEstante_ItemClick);
            // 
            // btnModificarEstante
            // 
            this.btnModificarEstante.Caption = "Editar Estante";
            this.btnModificarEstante.Id = 3;
            this.btnModificarEstante.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarEstante.ImageOptions.Image")));
            this.btnModificarEstante.Name = "btnModificarEstante";
            this.btnModificarEstante.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnModificarEstante.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificarEstante_ItemClick);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Caption = "Usuario";
            this.btnUsuarios.Id = 4;
            this.btnUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.ImageOptions.Image")));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsuarios_ItemClick);
            // 
            // btnEliminarEstante
            // 
            this.btnEliminarEstante.Caption = "Eliminar Estante";
            this.btnEliminarEstante.Id = 5;
            this.btnEliminarEstante.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEstante.ImageOptions.Image")));
            this.btnEliminarEstante.Name = "btnEliminarEstante";
            this.btnEliminarEstante.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnEliminarEstante.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarEstante_ItemClick);
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.Caption = "Nuevo Libro";
            this.btnNuevoLibro.Id = 6;
            this.btnNuevoLibro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoLibro.ImageOptions.Image")));
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNuevoLibro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoLibro_ItemClick);
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.Caption = "Editar Libro";
            this.btnEditarLibro.Id = 7;
            this.btnEditarLibro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarLibro.ImageOptions.Image")));
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnEditarLibro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarLibro_ItemClick);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Caption = "Eliminar Libro";
            this.btnEliminarLibro.Id = 8;
            this.btnEliminarLibro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarLibro.ImageOptions.Image")));
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnEliminarLibro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarLibro_ItemClick);
            // 
            // btnVerCapitulo
            // 
            this.btnVerCapitulo.Caption = "Capitulos";
            this.btnVerCapitulo.Id = 9;
            this.btnVerCapitulo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVerCapitulo.ImageOptions.Image")));
            this.btnVerCapitulo.Name = "btnVerCapitulo";
            this.btnVerCapitulo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnVerCapitulo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVerCapitulo_ItemClick);
            // 
            // btnLibroFavorito
            // 
            this.btnLibroFavorito.Caption = "Favorito";
            this.btnLibroFavorito.Id = 11;
            this.btnLibroFavorito.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLibroFavorito.ImageOptions.Image")));
            this.btnLibroFavorito.Name = "btnLibroFavorito";
            this.btnLibroFavorito.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLibroFavorito.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLibroFavorito_ItemClick);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Caption = "Buscar Libro";
            this.btnBuscarLibro.Id = 12;
            this.btnBuscarLibro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLibro.ImageOptions.Image")));
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnBuscarLibro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscarLibro_ItemClick);
            // 
            // btnVerLibrosFavoritos
            // 
            this.btnVerLibrosFavoritos.Caption = "Ver Favoritos";
            this.btnVerLibrosFavoritos.Id = 13;
            this.btnVerLibrosFavoritos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVerLibrosFavoritos.ImageOptions.Image")));
            this.btnVerLibrosFavoritos.Name = "btnVerLibrosFavoritos";
            this.btnVerLibrosFavoritos.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnVerLibrosFavoritos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVerLibrosFavoritos_ItemClick);
            // 
            // btnVerRepositorioDocs
            // 
            this.btnVerRepositorioDocs.Caption = "Ver Repositorio";
            this.btnVerRepositorioDocs.Id = 14;
            this.btnVerRepositorioDocs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVerRepositorioDocs.ImageOptions.Image")));
            this.btnVerRepositorioDocs.Name = "btnVerRepositorioDocs";
            this.btnVerRepositorioDocs.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnVerRepositorioDocs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVerRepositorioDocs_ItemClick);
            // 
            // btnVerLogError
            // 
            this.btnVerLogError.Caption = "Ver LogError";
            this.btnVerLogError.Id = 15;
            this.btnVerLogError.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVerLogError.ImageOptions.Image")));
            this.btnVerLogError.Name = "btnVerLogError";
            this.btnVerLogError.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnVerLogError.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVerLogError_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Libro";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNuevoLibro);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnEditarLibro);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnEliminarLibro);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Inicio";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVerCapitulo);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLibroFavorito);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Operaciones";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBuscarLibro);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnVerLibrosFavoritos);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Ver";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Estanteria";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNuevoEstante);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnModificarEstante);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminarEstante);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Inicio";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTipoEstanteAddMod);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tipos Estantes";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Configuracion";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUsuarios);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVerRepositorioDocs);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVerLogError);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Inicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.grcEstanteria);
            this.groupBox1.Location = new System.Drawing.Point(13, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estantes";
            // 
            // grcEstanteria
            // 
            this.grcEstanteria.DataSource = this.bsListaEstantes;
            this.grcEstanteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcEstanteria.Location = new System.Drawing.Point(3, 16);
            this.grcEstanteria.MainView = this.grvEstanteria;
            this.grcEstanteria.MenuManager = this.ribbonControl1;
            this.grcEstanteria.Name = "grcEstanteria";
            this.grcEstanteria.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1});
            this.grcEstanteria.Size = new System.Drawing.Size(419, 330);
            this.grcEstanteria.TabIndex = 0;
            this.grcEstanteria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEstanteria});
            // 
            // bsListaEstantes
            // 
            this.bsListaEstantes.DataSource = typeof(DominioClases.Clases.Estanteria);
            // 
            // grvEstanteria
            // 
            this.grvEstanteria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitulo_Estante,
            this.colDescripcion,
            this.colTipo_Estante_Desc});
            this.grvEstanteria.GridControl = this.grcEstanteria;
            this.grvEstanteria.Name = "grvEstanteria";
            this.grvEstanteria.OptionsDetail.EnableMasterViewMode = false;
            this.grvEstanteria.OptionsView.ShowAutoFilterRow = true;
            this.grvEstanteria.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvEstanteria_FocusedRowChanged);
            this.grvEstanteria.DoubleClick += new System.EventHandler(this.grvEstanteria_DoubleClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 40;
            // 
            // colTitulo_Estante
            // 
            this.colTitulo_Estante.Caption = "Titulo";
            this.colTitulo_Estante.FieldName = "Titulo_Estante";
            this.colTitulo_Estante.Name = "colTitulo_Estante";
            this.colTitulo_Estante.OptionsColumn.AllowEdit = false;
            this.colTitulo_Estante.OptionsColumn.ReadOnly = true;
            this.colTitulo_Estante.Visible = true;
            this.colTitulo_Estante.VisibleIndex = 0;
            this.colTitulo_Estante.Width = 116;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descr.";
            this.colDescripcion.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 45;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colTipo_Estante_Desc
            // 
            this.colTipo_Estante_Desc.Caption = "Tipo";
            this.colTipo_Estante_Desc.FieldName = "Tipo_Estante_Desc";
            this.colTipo_Estante_Desc.Name = "colTipo_Estante_Desc";
            this.colTipo_Estante_Desc.OptionsColumn.AllowEdit = false;
            this.colTipo_Estante_Desc.OptionsColumn.ReadOnly = true;
            this.colTipo_Estante_Desc.Visible = true;
            this.colTipo_Estante_Desc.VisibleIndex = 1;
            this.colTipo_Estante_Desc.Width = 70;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grcLibros);
            this.groupBox2.Location = new System.Drawing.Point(444, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 349);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libros";
            // 
            // grcLibros
            // 
            this.grcLibros.DataSource = this.bsListaLibros;
            this.grcLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLibros.Location = new System.Drawing.Point(3, 16);
            this.grcLibros.MainView = this.grvLibros;
            this.grcLibros.MenuManager = this.ribbonControl1;
            this.grcLibros.Name = "grcLibros";
            this.grcLibros.Size = new System.Drawing.Size(425, 330);
            this.grcLibros.TabIndex = 0;
            this.grcLibros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLibros});
            // 
            // bsListaLibros
            // 
            this.bsListaLibros.DataSource = typeof(DominioClases.Clases.Libro);
            // 
            // grvLibros
            // 
            this.grvLibros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colFecha_Add,
            this.colId_Usuario,
            this.colTitulo,
            this.colDescripcion1,
            this.colTotal_Capitulos,
            this.colLink,
            this.colIsPublico,
            this.colIsFavorito});
            this.grvLibros.GridControl = this.grcLibros;
            this.grvLibros.Name = "grvLibros";
            this.grvLibros.OptionsView.ShowAutoFilterRow = true;
            this.grvLibros.OptionsView.ShowGroupPanel = false;
            this.grvLibros.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvLibros_FocusedRowChanged);
            this.grvLibros.DoubleClick += new System.EventHandler(this.grvLibros_DoubleClick);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.OptionsColumn.AllowEdit = false;
            this.colId1.OptionsColumn.ReadOnly = true;
            this.colId1.Width = 34;
            // 
            // colFecha_Add
            // 
            this.colFecha_Add.Caption = "Fecha";
            this.colFecha_Add.FieldName = "Fecha_Add";
            this.colFecha_Add.Name = "colFecha_Add";
            this.colFecha_Add.OptionsColumn.AllowEdit = false;
            this.colFecha_Add.OptionsColumn.ReadOnly = true;
            this.colFecha_Add.Visible = true;
            this.colFecha_Add.VisibleIndex = 0;
            this.colFecha_Add.Width = 66;
            // 
            // colId_Usuario
            // 
            this.colId_Usuario.Caption = "Nº Usuario";
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
            this.colTitulo.VisibleIndex = 1;
            this.colTitulo.Width = 168;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descrip.";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.OptionsColumn.AllowEdit = false;
            this.colDescripcion1.OptionsColumn.ReadOnly = true;
            // 
            // colTotal_Capitulos
            // 
            this.colTotal_Capitulos.Caption = "Capitulos";
            this.colTotal_Capitulos.FieldName = "Total_Capitulos";
            this.colTotal_Capitulos.Name = "colTotal_Capitulos";
            this.colTotal_Capitulos.OptionsColumn.AllowEdit = false;
            this.colTotal_Capitulos.OptionsColumn.ReadOnly = true;
            this.colTotal_Capitulos.Visible = true;
            this.colTotal_Capitulos.VisibleIndex = 2;
            this.colTotal_Capitulos.Width = 57;
            // 
            // colLink
            // 
            this.colLink.FieldName = "Link";
            this.colLink.Name = "colLink";
            this.colLink.OptionsColumn.AllowEdit = false;
            this.colLink.OptionsColumn.ReadOnly = true;
            // 
            // colIsPublico
            // 
            this.colIsPublico.Caption = "Publico";
            this.colIsPublico.FieldName = "IsPublico";
            this.colIsPublico.Name = "colIsPublico";
            this.colIsPublico.OptionsColumn.AllowEdit = false;
            this.colIsPublico.OptionsColumn.ReadOnly = true;
            this.colIsPublico.Visible = true;
            this.colIsPublico.VisibleIndex = 3;
            this.colIsPublico.Width = 59;
            // 
            // colIsFavorito
            // 
            this.colIsFavorito.Caption = "Favorito";
            this.colIsFavorito.FieldName = "IsFavorito";
            this.colIsFavorito.Name = "colIsFavorito";
            this.colIsFavorito.Visible = true;
            this.colIsFavorito.VisibleIndex = 4;
            this.colIsFavorito.Width = 57;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFavorito);
            this.groupBox3.Controls.Add(this.lnkLibro);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTitulo);
            this.groupBox3.Controls.Add(this.chkPublico);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(881, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 364);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Libro";
            // 
            // chkFavorito
            // 
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsLibroSelect, "IsFavorito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFavorito.Enabled = false;
            this.chkFavorito.Location = new System.Drawing.Point(169, 122);
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.Size = new System.Drawing.Size(64, 17);
            this.chkFavorito.TabIndex = 29;
            this.chkFavorito.Text = "Favorito";
            this.chkFavorito.UseVisualStyleBackColor = true;
            // 
            // bsLibroSelect
            // 
            this.bsLibroSelect.DataSource = typeof(DominioClases.Clases.Libro);
            // 
            // lnkLibro
            // 
            this.lnkLibro.AutoSize = true;
            this.lnkLibro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibroSelect, "Link", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lnkLibro.Location = new System.Drawing.Point(45, 99);
            this.lnkLibro.Name = "lnkLibro";
            this.lnkLibro.Size = new System.Drawing.Size(55, 13);
            this.lnkLibro.TabIndex = 28;
            this.lnkLibro.TabStop = true;
            this.lnkLibro.Text = "linkLabel1";
            this.lnkLibro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLibro_LinkClicked);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibroSelect, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(48, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 20);
            this.txtId.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Id:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsLibroSelect, "Fecha_Add", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(48, 44);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(185, 20);
            this.dtpFecha.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibroSelect, "Titulo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(48, 70);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(185, 20);
            this.txtTitulo.TabIndex = 21;
            // 
            // chkPublico
            // 
            this.chkPublico.AutoSize = true;
            this.chkPublico.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsLibroSelect, "IsPublico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkPublico.Enabled = false;
            this.chkPublico.Location = new System.Drawing.Point(48, 122);
            this.chkPublico.Name = "chkPublico";
            this.chkPublico.Size = new System.Drawing.Size(76, 17);
            this.chkPublico.TabIndex = 20;
            this.chkPublico.Text = "Es Publico";
            this.chkPublico.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Link:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Desc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsLibroSelect, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescripcion.Location = new System.Drawing.Point(48, 145);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(185, 201);
            this.txtDescripcion.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca MoshiMo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcEstanteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaEstantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEstanteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibroSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTipoEstanteAddMod;
        private DevExpress.XtraBars.BarButtonItem btnNuevoEstante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl grcLibros;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLibros;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraBars.BarButtonItem btnModificarEstante;
        private System.Windows.Forms.BindingSource bsListaLibros;
        private System.Windows.Forms.BindingSource bsLibroSelect;
        private DevExpress.XtraGrid.GridControl grcEstanteria;
        private System.Windows.Forms.BindingSource bsListaEstantes;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEstanteria;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo_Estante;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_Estante_Desc;
        private DevExpress.XtraBars.BarButtonItem btnUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnEliminarEstante;
        private DevExpress.XtraBars.BarButtonItem btnNuevoLibro;
        private DevExpress.XtraBars.BarButtonItem btnEditarLibro;
        private DevExpress.XtraBars.BarButtonItem btnEliminarLibro;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Capitulos;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPublico;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.CheckBox chkPublico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private DevExpress.XtraBars.BarButtonItem btnVerCapitulo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private System.Windows.Forms.LinkLabel lnkLibro;
        private DevExpress.XtraBars.BarButtonItem btnLibroFavorito;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFavorito;
        private System.Windows.Forms.CheckBox chkFavorito;
        private DevExpress.XtraBars.BarButtonItem btnBuscarLibro;
        private DevExpress.XtraBars.BarButtonItem btnVerLibrosFavoritos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnVerRepositorioDocs;
        private DevExpress.XtraBars.BarButtonItem btnVerLogError;
    }
}

