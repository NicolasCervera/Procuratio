namespace Procuratio
{
    partial class FrmPantallaDePresentacion
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
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblInicioDeSesion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.picBTNCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContFrm = new System.Windows.Forms.Panel();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).BeginInit();
            this.pnlContFrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(1)))));
            this.pnlIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIzquierdo.Controls.Add(this.label1);
            this.pnlIzquierdo.Controls.Add(this.picLogo);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(173, 281);
            this.pnlIzquierdo.TabIndex = 1;
            this.pnlIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROCURATIO";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Procuratio.Properties.Resources.Icono_2;
            this.picLogo.Location = new System.Drawing.Point(30, 80);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(112, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblInicioDeSesion
            // 
            this.lblInicioDeSesion.AutoSize = true;
            this.lblInicioDeSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioDeSesion.ForeColor = System.Drawing.Color.Gray;
            this.lblInicioDeSesion.Location = new System.Drawing.Point(179, 80);
            this.lblInicioDeSesion.Name = "lblInicioDeSesion";
            this.lblInicioDeSesion.Size = new System.Drawing.Size(149, 20);
            this.lblInicioDeSesion.TabIndex = 6;
            this.lblInicioDeSesion.Text = "DESARROLLADORES:";
            this.lblInicioDeSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(179, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "GMAIL:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(178, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TELEFONO/WHATSAPP:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.Gray;
            this.lblCargando.Location = new System.Drawing.Point(299, 38);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(106, 20);
            this.lblCargando.TabIndex = 9;
            this.lblCargando.Text = "CARGANDO...";
            this.lblCargando.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(326, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(228, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Tomas Gavagnin, Cervera Nicolás";
            this.lblNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGmail.Location = new System.Drawing.Point(234, 120);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(195, 40);
            this.lblGmail.TabIndex = 11;
            this.lblGmail.Text = "tomasgavagnin@gmail.com\r\nnicodapa99899@gmail.com";
            this.lblGmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(340, 171);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 40);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "3534274171\r\n3534771969\r\n";
            this.lblTelefono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // picBTNCerrar
            // 
            this.picBTNCerrar.Image = global::Procuratio.Properties.Resources.Cerrar2;
            this.picBTNCerrar.Location = new System.Drawing.Point(541, 5);
            this.picBTNCerrar.Name = "picBTNCerrar";
            this.picBTNCerrar.Size = new System.Drawing.Size(27, 22);
            this.picBTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBTNCerrar.TabIndex = 13;
            this.picBTNCerrar.TabStop = false;
            this.picBTNCerrar.Visible = false;
            this.picBTNCerrar.Click += new System.EventHandler(this.PicBTNCerrar_Click);
            this.picBTNCerrar.MouseLeave += new System.EventHandler(this.ColorFondoBotones_MouseLeave);
            this.picBTNCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorFondoBotones_MouseMove);
            // 
            // pnlContFrm
            // 
            this.pnlContFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContFrm.Controls.Add(this.lblNombre);
            this.pnlContFrm.Controls.Add(this.lblTelefono);
            this.pnlContFrm.Controls.Add(this.label3);
            this.pnlContFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContFrm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlContFrm.Name = "pnlContFrm";
            this.pnlContFrm.Size = new System.Drawing.Size(572, 281);
            this.pnlContFrm.TabIndex = 14;
            this.pnlContFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            // 
            // FrmPantallaDePresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(572, 281);
            this.Controls.Add(this.picBTNCerrar);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInicioDeSesion);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlContFrm);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPantallaDePresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPantallaDePresentacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPantallaDePresentacion_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastre_MouseDown);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTNCerrar)).EndInit();
            this.pnlContFrm.ResumeLayout(false);
            this.pnlContFrm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicioDeSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.PictureBox picBTNCerrar;
        private System.Windows.Forms.Panel pnlContFrm;
    }
}