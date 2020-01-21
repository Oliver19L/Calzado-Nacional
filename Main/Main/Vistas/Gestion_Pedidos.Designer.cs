namespace Main.Vistas
{
    partial class Gestion_Pedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnEditarDetalle = new System.Windows.Forms.Button();
            this.btnNuevoDetalle = new System.Windows.Forms.Button();
            this.btnElimDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(405, 496);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(304, 496);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(208, 496);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(16, 70);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(445, 405);
            this.dgvPedidos.TabIndex = 7;
            // 
            // btnEditarDetalle
            // 
            this.btnEditarDetalle.BackColor = System.Drawing.Color.White;
            this.btnEditarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnEditarDetalle.FlatAppearance.BorderSize = 2;
            this.btnEditarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDetalle.Location = new System.Drawing.Point(1244, 496);
            this.btnEditarDetalle.Name = "btnEditarDetalle";
            this.btnEditarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDetalle.TabIndex = 16;
            this.btnEditarDetalle.Text = "Editar";
            this.btnEditarDetalle.UseVisualStyleBackColor = false;
            // 
            // btnNuevoDetalle
            // 
            this.btnNuevoDetalle.BackColor = System.Drawing.Color.White;
            this.btnNuevoDetalle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnNuevoDetalle.FlatAppearance.BorderSize = 2;
            this.btnNuevoDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDetalle.Location = new System.Drawing.Point(1143, 496);
            this.btnNuevoDetalle.Name = "btnNuevoDetalle";
            this.btnNuevoDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoDetalle.TabIndex = 15;
            this.btnNuevoDetalle.Text = "Nuevo";
            this.btnNuevoDetalle.UseVisualStyleBackColor = false;
            // 
            // btnElimDetalle
            // 
            this.btnElimDetalle.BackColor = System.Drawing.Color.White;
            this.btnElimDetalle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnElimDetalle.FlatAppearance.BorderSize = 2;
            this.btnElimDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimDetalle.Location = new System.Drawing.Point(1048, 496);
            this.btnElimDetalle.Name = "btnElimDetalle";
            this.btnElimDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnElimDetalle.TabIndex = 14;
            this.btnElimDetalle.Text = "Eliminar";
            this.btnElimDetalle.UseVisualStyleBackColor = false;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(563, 70);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(754, 405);
            this.dgvDetalle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(861, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Buscar:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(943, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tabla De Pedidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tabla De Detalle Pedidos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1175, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Reporte Detalle Pedido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestion_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnEditarDetalle);
            this.Controls.Add(this.btnNuevoDetalle);
            this.Controls.Add(this.btnElimDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Gestion_Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnEditarDetalle;
        private System.Windows.Forms.Button btnNuevoDetalle;
        private System.Windows.Forms.Button btnElimDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}