namespace aplicacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombreCaf = new System.Windows.Forms.TextBox();
            this.lblNomCafeteria = new System.Windows.Forms.Label();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoDeIncio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoDeFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuDesPorDia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumEsPorDia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCaf
            // 
            this.txtNombreCaf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNombreCaf.Location = new System.Drawing.Point(403, 137);
            this.txtNombreCaf.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCaf.Name = "txtNombreCaf";
            this.txtNombreCaf.Size = new System.Drawing.Size(133, 22);
            this.txtNombreCaf.TabIndex = 1;
            this.txtNombreCaf.TextChanged += new System.EventHandler(this.TxtNombreCaf_TextChanged);
            // 
            // lblNomCafeteria
            // 
            this.lblNomCafeteria.AutoSize = true;
            this.lblNomCafeteria.BackColor = System.Drawing.Color.White;
            this.lblNomCafeteria.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCafeteria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomCafeteria.Image = ((System.Drawing.Image)(resources.GetObject("lblNomCafeteria.Image")));
            this.lblNomCafeteria.Location = new System.Drawing.Point(54, 141);
            this.lblNomCafeteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomCafeteria.Name = "lblNomCafeteria";
            this.lblNomCafeteria.Size = new System.Drawing.Size(185, 22);
            this.lblNomCafeteria.TabIndex = 2;
            this.lblNomCafeteria.Text = "Nombre de la Cafetería";
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarDatos.FlatAppearance.BorderSize = 2;
            this.btnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDatos.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarDatos.Location = new System.Drawing.Point(106, 363);
            this.btnGuardarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(191, 42);
            this.btnGuardarDatos.TabIndex = 3;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = false;
            this.btnGuardarDatos.Click += new System.EventHandler(this.BtnGuardarDatos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::aplicacion.Properties.Resources.logo_icesi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 82);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(52, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "#Inicial de Cubiertos no desechables";
            // 
            // txtNoDeIncio
            // 
            this.txtNoDeIncio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNoDeIncio.Location = new System.Drawing.Point(403, 175);
            this.txtNoDeIncio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoDeIncio.Name = "txtNoDeIncio";
            this.txtNoDeIncio.Size = new System.Drawing.Size(133, 22);
            this.txtNoDeIncio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(52, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "# Final de cubiertos no desechables";
            // 
            // txtNoDeFinal
            // 
            this.txtNoDeFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNoDeFinal.Location = new System.Drawing.Point(403, 213);
            this.txtNoDeFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoDeFinal.Name = "txtNoDeFinal";
            this.txtNoDeFinal.Size = new System.Drawing.Size(133, 22);
            this.txtNoDeFinal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(51, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "#Cubiertos desechables vendidos diariamente";
            // 
            // txtCuDesPorDia
            // 
            this.txtCuDesPorDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCuDesPorDia.Location = new System.Drawing.Point(403, 251);
            this.txtCuDesPorDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuDesPorDia.Name = "txtCuDesPorDia";
            this.txtCuDesPorDia.Size = new System.Drawing.Size(133, 22);
            this.txtCuDesPorDia.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(51, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "# Promedio diario de estudiantes atendidos";
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.BackColor = System.Drawing.Color.Yellow;
            this.btnAbrirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbrirArchivo.FlatAppearance.BorderSize = 2;
            this.btnAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirArchivo.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(307, 363);
            this.btnAbrirArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(195, 42);
            this.btnAbrirArchivo.TabIndex = 14;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = false;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.BtnAbrirArchivo_Click);
            // 
            // txtNumEsPorDia
            // 
            this.txtNumEsPorDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumEsPorDia.Location = new System.Drawing.Point(403, 288);
            this.txtNumEsPorDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumEsPorDia.Name = "txtNumEsPorDia";
            this.txtNumEsPorDia.Size = new System.Drawing.Size(133, 22);
            this.txtNumEsPorDia.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::aplicacion.Properties.Resources.cafeteria;
            this.ClientSize = new System.Drawing.Size(592, 455);
            this.Controls.Add(this.txtNumEsPorDia);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuDesPorDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoDeFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoDeIncio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.lblNomCafeteria);
            this.Controls.Add(this.txtNombreCaf);
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Registro de Cubiertos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreCaf;
        private System.Windows.Forms.Label lblNomCafeteria;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoDeIncio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoDeFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuDesPorDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtNumEsPorDia;
    }
}

