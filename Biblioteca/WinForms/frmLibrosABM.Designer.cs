namespace Biblioteca.WinForms
{
    partial class frmLibrosABM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPublico = new System.Windows.Forms.CheckBox();
            this.bsLibro = new System.Windows.Forms.BindingSource(this.components);
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cboEstanteria = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaLibro = new System.Windows.Forms.DateTimePicker();
            this.chkFavorito = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estanteria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Link:";
            // 
            // chkPublico
            // 
            this.chkPublico.AutoSize = true;
            this.chkPublico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPublico.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsLibro, "IsPublico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkPublico.Location = new System.Drawing.Point(17, 271);
            this.chkPublico.Name = "chkPublico";
            this.chkPublico.Size = new System.Drawing.Size(79, 17);
            this.chkPublico.TabIndex = 8;
            this.chkPublico.Text = "Es Publico:";
            this.chkPublico.UseVisualStyleBackColor = true;
            // 
            // bsLibro
            // 
            this.bsLibro.DataSource = typeof(DominioClases.Clases.Libro);
            // 
            // txtTitulo
            // 
            this.txtTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibro, "Titulo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTitulo.Location = new System.Drawing.Point(81, 89);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(210, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibro, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescripcion.Location = new System.Drawing.Point(81, 115);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(210, 93);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtLink
            // 
            this.txtLink.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibro, "Link", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLink.Location = new System.Drawing.Point(81, 214);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(210, 20);
            this.txtLink.TabIndex = 6;
            // 
            // cboEstanteria
            // 
            this.cboEstanteria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsLibro, "Estanteria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboEstanteria.DisplayMember = "Titulo_Estante";
            this.cboEstanteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstanteria.FormattingEnabled = true;
            this.cboEstanteria.Location = new System.Drawing.Point(81, 239);
            this.cboEstanteria.Name = "cboEstanteria";
            this.cboEstanteria.Size = new System.Drawing.Size(210, 21);
            this.cboEstanteria.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(219, 291);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibro, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(81, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(210, 20);
            this.txtId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Autor:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLibro, "Usuario_Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(81, 37);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(210, 20);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha:";
            // 
            // dtpFechaLibro
            // 
            this.dtpFechaLibro.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsLibro, "Fecha_Add", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaLibro.Enabled = false;
            this.dtpFechaLibro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLibro.Location = new System.Drawing.Point(81, 63);
            this.dtpFechaLibro.Name = "dtpFechaLibro";
            this.dtpFechaLibro.Size = new System.Drawing.Size(210, 20);
            this.dtpFechaLibro.TabIndex = 3;
            // 
            // chkFavorito
            // 
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFavorito.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsLibro, "IsFavorito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFavorito.Location = new System.Drawing.Point(102, 271);
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.Size = new System.Drawing.Size(67, 17);
            this.chkFavorito.TabIndex = 9;
            this.chkFavorito.Text = "Favorito:";
            this.chkFavorito.UseVisualStyleBackColor = true;
            // 
            // frmLibrosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 321);
            this.Controls.Add(this.chkFavorito);
            this.Controls.Add(this.dtpFechaLibro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboEstanteria);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.chkPublico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(322, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(322, 329);
            this.Name = "frmLibrosABM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.frmLibrosABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPublico;
        private System.Windows.Forms.TextBox txtTitulo;
        private DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ComboBox cboEstanteria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource bsLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaLibro;
        private System.Windows.Forms.CheckBox chkFavorito;
    }
}