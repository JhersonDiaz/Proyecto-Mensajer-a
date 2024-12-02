namespace Proycto_Mensajeria
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMensajeria = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajeria)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Blue;
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtCorreo);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtRespuesta);
            this.splitContainer1.Panel1.Controls.Add(this.btnProcesar);
            this.splitContainer1.Panel1.Controls.Add(this.btnRegistrar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtReceptor);
            this.splitContainer1.Panel1.Controls.Add(this.txtMensaje);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMensajeria);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Productor";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(12, 139);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(205, 20);
            this.txtMensaje.TabIndex = 2;
            // 
            // txtReceptor
            // 
            this.txtReceptor.Location = new System.Drawing.Point(12, 197);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(205, 20);
            this.txtReceptor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consumidor o Receptor";
            // 
            // dgvMensajeria
            // 
            this.dgvMensajeria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajeria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreProductor,
            this.Correo,
            this.Mensaje,
            this.Receptor,
            this.Respuesta});
            this.dgvMensajeria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMensajeria.Location = new System.Drawing.Point(0, 0);
            this.dgvMensajeria.Name = "dgvMensajeria";
            this.dgvMensajeria.Size = new System.Drawing.Size(530, 450);
            this.dgvMensajeria.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.Cyan;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(58, 290);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 38);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.BackColor = System.Drawing.Color.Cyan;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Location = new System.Drawing.Point(167, 290);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 38);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(12, 246);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(205, 20);
            this.txtRespuesta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Respuesta";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(12, 88);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(205, 20);
            this.txtCorreo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correo Electronico";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // NombreProductor
            // 
            this.NombreProductor.HeaderText = "NombreProductor";
            this.NombreProductor.Name = "NombreProductor";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Mensaje
            // 
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            // 
            // Receptor
            // 
            this.Receptor.HeaderText = "Receptor";
            this.Receptor.Name = "Receptor";
            // 
            // Respuesta
            // 
            this.Respuesta.HeaderText = "Respuesta";
            this.Respuesta.Name = "Respuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajeria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvMensajeria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta;
    }
}

