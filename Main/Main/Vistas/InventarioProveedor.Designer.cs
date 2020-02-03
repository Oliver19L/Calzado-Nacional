namespace Main.Vistas
{
    partial class InventarioProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.btnActu = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnelim = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 30);
            this.panel1.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(91, 82);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(276, 47);
            this.txtDescrip.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(91, 154);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(267, 154);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(91, 42);
            this.mskCodigo.Mask = "0000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(64, 20);
            this.mskCodigo.TabIndex = 10;
            // 
            // btnActu
            // 
            this.btnActu.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnActu.FlatAppearance.BorderSize = 2;
            this.btnActu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnActu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnActu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActu.Image = ((System.Drawing.Image)(resources.GetObject("btnActu.Image")));
            this.btnActu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActu.Location = new System.Drawing.Point(210, 234);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(87, 25);
            this.btnActu.TabIndex = 67;
            this.btnActu.Text = "Actualizar";
            this.btnActu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActu.UseVisualStyleBackColor = true;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnInsert.FlatAppearance.BorderSize = 2;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(210, 234);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 25);
            this.btnInsert.TabIndex = 66;
            this.btnInsert.Text = "Guardar";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnelim
            // 
            this.btnelim.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnelim.FlatAppearance.BorderSize = 2;
            this.btnelim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnelim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelim.Image = ((System.Drawing.Image)(resources.GetObject("btnelim.Image")));
            this.btnelim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnelim.Location = new System.Drawing.Point(210, 234);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(87, 25);
            this.btnelim.TabIndex = 65;
            this.btnelim.Text = "Eliminar";
            this.btnelim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnelim.UseVisualStyleBackColor = true;
            this.btnelim.Click += new System.EventHandler(this.btnelim_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(91, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 25);
            this.btnLimpiar.TabIndex = 64;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(303, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 25);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Materia Prima";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(354, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 30);
            this.button2.TabIndex = 69;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(306, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 30);
            this.button1.TabIndex = 68;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InventarioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 271);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnelim);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioProveedor";
            this.Text = "InventarioProveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnelim;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}