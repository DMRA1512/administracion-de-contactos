namespace Administracion_de_contactos
{
    partial class frm_login
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
            this.btn_iniciarsesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombreU = new System.Windows.Forms.TextBox();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_iniciarsesion
            // 
            this.btn_iniciarsesion.Location = new System.Drawing.Point(202, 223);
            this.btn_iniciarsesion.Name = "btn_iniciarsesion";
            this.btn_iniciarsesion.Size = new System.Drawing.Size(112, 45);
            this.btn_iniciarsesion.TabIndex = 0;
            this.btn_iniciarsesion.Text = "Iniciar Sesion";
            this.btn_iniciarsesion.UseVisualStyleBackColor = true;
            this.btn_iniciarsesion.Click += new System.EventHandler(this.btn_iniciarsesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // tb_nombreU
            // 
            this.tb_nombreU.Location = new System.Drawing.Point(169, 96);
            this.tb_nombreU.Name = "tb_nombreU";
            this.tb_nombreU.Size = new System.Drawing.Size(185, 20);
            this.tb_nombreU.TabIndex = 3;
            this.tb_nombreU.TextChanged += new System.EventHandler(this.tb_nombre_TextChanged);
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(169, 144);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(185, 20);
            this.tb_contraseña.TabIndex = 4;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(202, 296);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(112, 41);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 383);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_nombreU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_iniciarsesion);
            this.Name = "frm_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciarsesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombreU;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.Button btn_registrar;
    }
}

