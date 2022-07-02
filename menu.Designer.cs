namespace POO20Junio2022
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bntAyuda = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.bntSalida = new System.Windows.Forms.Button();
            this.bntIngreso = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.panelSecundario = new System.Windows.Forms.Panel();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.bntAyuda);
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.btnPrincipal);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(233, 468);
            this.panelMenu.TabIndex = 0;
            // 
            // bntAyuda
            // 
            this.bntAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntAyuda.FlatAppearance.BorderSize = 0;
            this.bntAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAyuda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntAyuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntAyuda.Location = new System.Drawing.Point(0, 252);
            this.bntAyuda.Name = "bntAyuda";
            this.bntAyuda.Size = new System.Drawing.Size(233, 45);
            this.bntAyuda.TabIndex = 5;
            this.bntAyuda.Text = "Ayuda ";
            this.bntAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAyuda.UseVisualStyleBackColor = true;
            this.bntAyuda.Click += new System.EventHandler(this.bntAyuda_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu.Controls.Add(this.bntSalida);
            this.panelSubMenu.Controls.Add(this.bntIngreso);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 158);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(233, 94);
            this.panelSubMenu.TabIndex = 4;
            // 
            // bntSalida
            // 
            this.bntSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntSalida.FlatAppearance.BorderSize = 0;
            this.bntSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntSalida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntSalida.Location = new System.Drawing.Point(0, 40);
            this.bntSalida.Name = "bntSalida";
            this.bntSalida.Size = new System.Drawing.Size(233, 40);
            this.bntSalida.TabIndex = 1;
            this.bntSalida.Text = "Salida De Vehiculo";
            this.bntSalida.UseVisualStyleBackColor = true;
            this.bntSalida.Click += new System.EventHandler(this.bntSalida_Click);
            // 
            // bntIngreso
            // 
            this.bntIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntIngreso.FlatAppearance.BorderSize = 0;
            this.bntIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntIngreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntIngreso.Location = new System.Drawing.Point(0, 0);
            this.bntIngreso.Name = "bntIngreso";
            this.bntIngreso.Size = new System.Drawing.Size(233, 40);
            this.bntIngreso.TabIndex = 0;
            this.bntIngreso.Text = "Ingreso De Vehiculo";
            this.bntIngreso.UseVisualStyleBackColor = true;
            this.bntIngreso.Click += new System.EventHandler(this.bntIngreso_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 113);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(233, 45);
            this.btnPrincipal.TabIndex = 3;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 113);
            this.panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.lbFecha);
            this.panel2.Controls.Add(this.lbHora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(233, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFecha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbFecha.Location = new System.Drawing.Point(330, 32);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(96, 37);
            this.lbFecha.TabIndex = 27;
            this.lbFecha.Text = "label6";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHora.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbHora.Location = new System.Drawing.Point(56, 32);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(96, 37);
            this.lbHora.TabIndex = 26;
            this.lbHora.Text = "label4";
            // 
            // panelSecundario
            // 
            this.panelSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSecundario.Location = new System.Drawing.Point(233, 0);
            this.panelSecundario.Name = "panelSecundario";
            this.panelSecundario.Size = new System.Drawing.Size(661, 368);
            this.panelSecundario.TabIndex = 2;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(894, 468);
            this.Controls.Add(this.panelSecundario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnPrincipal;
        private Panel panelLogo;
        private Panel panel2;
        private Panel panelSubMenu;
        private Button bntIngreso;
        private Button bntSalida;
        private Button bntAyuda;
        private Panel panelSecundario;
        private Label lbFecha;
        private Label lbHora;
        private System.Windows.Forms.Timer horaFecha;
        private PictureBox pictureBox1;
    }
}