namespace LIBRERIA_MELIZA
{
    partial class formMenu
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnbibliotecarios = new System.Windows.Forms.Button();
            this.btnlectores = new System.Windows.Forms.Button();
            this.btnlibros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.BackgroundImage = global::LIBRERIA_MELIZA.Properties.Resources.boton;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(426, 317);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(272, 109);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.White;
            this.btnregresar.BackgroundImage = global::LIBRERIA_MELIZA.Properties.Resources.boton;
            this.btnregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregresar.ForeColor = System.Drawing.Color.White;
            this.btnregresar.Location = new System.Drawing.Point(148, 317);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(272, 109);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnbibliotecarios
            // 
            this.btnbibliotecarios.BackColor = System.Drawing.Color.White;
            this.btnbibliotecarios.BackgroundImage = global::LIBRERIA_MELIZA.Properties.Resources.boton;
            this.btnbibliotecarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbibliotecarios.ForeColor = System.Drawing.Color.White;
            this.btnbibliotecarios.Location = new System.Drawing.Point(262, 153);
            this.btnbibliotecarios.Name = "btnbibliotecarios";
            this.btnbibliotecarios.Size = new System.Drawing.Size(272, 109);
            this.btnbibliotecarios.TabIndex = 3;
            this.btnbibliotecarios.Text = "BIBLIOTECARIOS";
            this.btnbibliotecarios.UseVisualStyleBackColor = false;
            this.btnbibliotecarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnlectores
            // 
            this.btnlectores.BackColor = System.Drawing.Color.White;
            this.btnlectores.BackgroundImage = global::LIBRERIA_MELIZA.Properties.Resources.boton;
            this.btnlectores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlectores.ForeColor = System.Drawing.Color.White;
            this.btnlectores.Location = new System.Drawing.Point(516, 12);
            this.btnlectores.Name = "btnlectores";
            this.btnlectores.Size = new System.Drawing.Size(272, 109);
            this.btnlectores.TabIndex = 2;
            this.btnlectores.Text = "LECTORES";
            this.btnlectores.UseVisualStyleBackColor = false;
            this.btnlectores.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlibros
            // 
            this.btnlibros.BackColor = System.Drawing.Color.White;
            this.btnlibros.BackgroundImage = global::LIBRERIA_MELIZA.Properties.Resources.boton;
            this.btnlibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlibros.ForeColor = System.Drawing.Color.White;
            this.btnlibros.Location = new System.Drawing.Point(12, 12);
            this.btnlibros.Name = "btnlibros";
            this.btnlibros.Size = new System.Drawing.Size(272, 109);
            this.btnlibros.TabIndex = 1;
            this.btnlibros.Text = "LIBROS";
            this.btnlibros.UseVisualStyleBackColor = false;
            this.btnlibros.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIBRERIA_MELIZA.Properties.Resources.ortega;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnbibliotecarios);
            this.Controls.Add(this.btnlectores);
            this.Controls.Add(this.btnlibros);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formMenu";
            this.Text = "formMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlibros;
        private System.Windows.Forms.Button btnlectores;
        private System.Windows.Forms.Button btnbibliotecarios;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnsalir;
    }
}