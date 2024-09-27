namespace PryPresentacion
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cblTipo = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cblTipo);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(449, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 556);
            this.panel1.TabIndex = 0;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(152, 456);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(148, 46);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(55, 363);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(349, 38);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(55, 292);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(349, 38);
            this.txtCorreoElectronico.TabIndex = 3;
            this.txtCorreoElectronico.Enter += new System.EventHandler(this.txtCorreoElectronico_Enter);
            this.txtCorreoElectronico.Leave += new System.EventHandler(this.txtCorreoElectronico_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecciona tu tipo de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryPresentacion.Properties.Resources.image__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cblTipo
            // 
            this.cblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblTipo.FormattingEnabled = true;
            this.cblTipo.Items.AddRange(new object[] {
            "Administrativo",
            "Cliente",
            "Empleado/Entrenador"});
            this.cblTipo.Location = new System.Drawing.Point(64, 150);
            this.cblTipo.Name = "cblTipo";
            this.cblTipo.Size = new System.Drawing.Size(318, 118);
            this.cblTipo.TabIndex = 6;
            this.cblTipo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblTipo_ItemCheck);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox cblTipo;
    }
}