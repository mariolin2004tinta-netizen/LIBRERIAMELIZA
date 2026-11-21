namespace LIBRERIA_MELIZA
{
    partial class formlibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formlibros));
            this.gbdatoslibro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.dgbdatoslibros = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.agregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.limpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.regresar = new System.Windows.Forms.ToolStripButton();
            this.gbdatoslibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbdatoslibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdatoslibro
            // 
            this.gbdatoslibro.BackColor = System.Drawing.Color.Black;
            this.gbdatoslibro.Controls.Add(this.txtstock);
            this.gbdatoslibro.Controls.Add(this.txteditorial);
            this.gbdatoslibro.Controls.Add(this.txtautor);
            this.gbdatoslibro.Controls.Add(this.txttitulo);
            this.gbdatoslibro.Controls.Add(this.txtcodigo);
            this.gbdatoslibro.Controls.Add(this.dtpfecha);
            this.gbdatoslibro.Controls.Add(this.label6);
            this.gbdatoslibro.Controls.Add(this.label5);
            this.gbdatoslibro.Controls.Add(this.label4);
            this.gbdatoslibro.Controls.Add(this.label3);
            this.gbdatoslibro.Controls.Add(this.label2);
            this.gbdatoslibro.Controls.Add(this.label1);
            this.gbdatoslibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatoslibro.ForeColor = System.Drawing.Color.White;
            this.gbdatoslibro.Location = new System.Drawing.Point(12, 64);
            this.gbdatoslibro.Name = "gbdatoslibro";
            this.gbdatoslibro.Size = new System.Drawing.Size(553, 219);
            this.gbdatoslibro.TabIndex = 1;
            this.gbdatoslibro.TabStop = false;
            this.gbdatoslibro.Text = "DATOS DEL LIBRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "AUTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "EDITORIAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "STOCK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "FECHA";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(366, 129);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(140, 26);
            this.dtpfecha.TabIndex = 6;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(136, 36);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 26);
            this.txtcodigo.TabIndex = 7;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(136, 83);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(100, 26);
            this.txttitulo.TabIndex = 8;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(350, 39);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(100, 26);
            this.txtautor.TabIndex = 9;
            // 
            // txteditorial
            // 
            this.txteditorial.Location = new System.Drawing.Point(380, 89);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(100, 26);
            this.txteditorial.TabIndex = 10;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(136, 128);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(91, 26);
            this.txtstock.TabIndex = 11;
            // 
            // dgbdatoslibros
            // 
            this.dgbdatoslibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbdatoslibros.Location = new System.Drawing.Point(25, 289);
            this.dgbdatoslibros.Name = "dgbdatoslibros";
            this.dgbdatoslibros.RowHeadersWidth = 51;
            this.dgbdatoslibros.RowTemplate.Height = 24;
            this.dgbdatoslibros.Size = new System.Drawing.Size(749, 149);
            this.dgbdatoslibros.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LIBRERIA_MELIZA.Properties.Resources.casimiro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 446);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregar,
            this.toolStripSeparator1,
            this.actualizar,
            this.toolStripSeparator2,
            this.eliminar,
            this.toolStripSeparator3,
            this.limpiar,
            this.toolStripSeparator4,
            this.regresar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // agregar
            // 
            this.agregar.Image = ((System.Drawing.Image)(resources.GetObject("agregar.Image")));
            this.agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(79, 44);
            this.agregar.Text = "AGREGAR";
            this.agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // actualizar
            // 
            this.actualizar.Image = ((System.Drawing.Image)(resources.GetObject("actualizar.Image")));
            this.actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(99, 44);
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(79, 44);
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // limpiar
            // 
            this.limpiar.Image = ((System.Drawing.Image)(resources.GetObject("limpiar.Image")));
            this.limpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(68, 44);
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // regresar
            // 
            this.regresar.Image = ((System.Drawing.Image)(resources.GetObject("regresar.Image")));
            this.regresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(84, 44);
            this.regresar.Text = "REGRESAR";
            this.regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // formlibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgbdatoslibros);
            this.Controls.Add(this.gbdatoslibro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formlibros";
            this.Text = "formlibros";
            this.gbdatoslibro.ResumeLayout(false);
            this.gbdatoslibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbdatoslibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbdatoslibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.DataGridView dgbdatoslibros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton agregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton actualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton limpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton regresar;
    }
}