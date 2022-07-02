namespace POO20Junio2022
{
    partial class SalidaDeVehiculo
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
            this.textBoxIDTicketAPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonMostrarDatosComprobante = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFechayHoraEntrada = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIdTicket = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelTipoVehiculo = new System.Windows.Forms.Label();
            this.labelTarifa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFechaYHoraSalida = new System.Windows.Forms.Label();
            this.labelMedioDePago = new System.Windows.Forms.Label();
            this.labelEstadiaHoras = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelLugaresVehiculos = new System.Windows.Forms.Label();
            this.labelLugaresMotos = new System.Windows.Forms.Label();
            this.labelCantVehiculos = new System.Windows.Forms.Label();
            this.labelCantMotos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Id del ticket a cancelar";
            // 
            // textBoxIDTicketAPagar
            // 
            this.textBoxIDTicketAPagar.Location = new System.Drawing.Point(230, 73);
            this.textBoxIDTicketAPagar.Name = "textBoxIDTicketAPagar";
            this.textBoxIDTicketAPagar.Size = new System.Drawing.Size(98, 23);
            this.textBoxIDTicketAPagar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elija un medio de pago";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "efectivo",
            "tarjeta"});
            this.comboBox1.Location = new System.Drawing.Point(230, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // buttonMostrarDatosComprobante
            // 
            this.buttonMostrarDatosComprobante.FlatAppearance.BorderSize = 0;
            this.buttonMostrarDatosComprobante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMostrarDatosComprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMostrarDatosComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarDatosComprobante.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarDatosComprobante.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMostrarDatosComprobante.Location = new System.Drawing.Point(124, 157);
            this.buttonMostrarDatosComprobante.Name = "buttonMostrarDatosComprobante";
            this.buttonMostrarDatosComprobante.Size = new System.Drawing.Size(149, 47);
            this.buttonMostrarDatosComprobante.TabIndex = 4;
            this.buttonMostrarDatosComprobante.Text = "Mostrar datos del comprobante";
            this.buttonMostrarDatosComprobante.UseVisualStyleBackColor = true;
            this.buttonMostrarDatosComprobante.Click += new System.EventHandler(this.buttonMostrarDatosComprobante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(398, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datos del comprobante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(374, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "fecha y hora de entrada: ";
            // 
            // labelFechayHoraEntrada
            // 
            this.labelFechayHoraEntrada.AutoSize = true;
            this.labelFechayHoraEntrada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFechayHoraEntrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFechayHoraEntrada.Location = new System.Drawing.Point(538, 81);
            this.labelFechayHoraEntrada.Name = "labelFechayHoraEntrada";
            this.labelFechayHoraEntrada.Size = new System.Drawing.Size(12, 15);
            this.labelFechayHoraEntrada.TabIndex = 7;
            this.labelFechayHoraEntrada.Text = "-";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(446, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(374, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id del ticket a pagar: ";
            // 
            // labelIdTicket
            // 
            this.labelIdTicket.AutoSize = true;
            this.labelIdTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIdTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIdTicket.Location = new System.Drawing.Point(538, 66);
            this.labelIdTicket.Name = "labelIdTicket";
            this.labelIdTicket.Size = new System.Drawing.Size(12, 15);
            this.labelIdTicket.TabIndex = 10;
            this.labelIdTicket.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(374, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Patente del vehiculo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(374, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Vehiculo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(374, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tarifa en pesos por hora: ";
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPatente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPatente.Location = new System.Drawing.Point(538, 96);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(12, 15);
            this.labelPatente.TabIndex = 14;
            this.labelPatente.Text = "-";
            // 
            // labelTipoVehiculo
            // 
            this.labelTipoVehiculo.AutoSize = true;
            this.labelTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipoVehiculo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTipoVehiculo.Location = new System.Drawing.Point(538, 111);
            this.labelTipoVehiculo.Name = "labelTipoVehiculo";
            this.labelTipoVehiculo.Size = new System.Drawing.Size(12, 15);
            this.labelTipoVehiculo.TabIndex = 15;
            this.labelTipoVehiculo.Text = "-";
            // 
            // labelTarifa
            // 
            this.labelTarifa.AutoSize = true;
            this.labelTarifa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTarifa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTarifa.Location = new System.Drawing.Point(538, 126);
            this.labelTarifa.Name = "labelTarifa";
            this.labelTarifa.Size = new System.Drawing.Size(12, 15);
            this.labelTarifa.TabIndex = 16;
            this.labelTarifa.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(374, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Medio de Pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(374, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha y hora de salida: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(374, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total horas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(374, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total a pagar en pesos: ";
            // 
            // labelFechaYHoraSalida
            // 
            this.labelFechaYHoraSalida.AutoSize = true;
            this.labelFechaYHoraSalida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFechaYHoraSalida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFechaYHoraSalida.Location = new System.Drawing.Point(538, 142);
            this.labelFechaYHoraSalida.Name = "labelFechaYHoraSalida";
            this.labelFechaYHoraSalida.Size = new System.Drawing.Size(12, 15);
            this.labelFechaYHoraSalida.TabIndex = 21;
            this.labelFechaYHoraSalida.Text = "-";
            // 
            // labelMedioDePago
            // 
            this.labelMedioDePago.AutoSize = true;
            this.labelMedioDePago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMedioDePago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMedioDePago.Location = new System.Drawing.Point(538, 157);
            this.labelMedioDePago.Name = "labelMedioDePago";
            this.labelMedioDePago.Size = new System.Drawing.Size(12, 15);
            this.labelMedioDePago.TabIndex = 22;
            this.labelMedioDePago.Text = "-";
            // 
            // labelEstadiaHoras
            // 
            this.labelEstadiaHoras.AutoSize = true;
            this.labelEstadiaHoras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEstadiaHoras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEstadiaHoras.Location = new System.Drawing.Point(538, 172);
            this.labelEstadiaHoras.Name = "labelEstadiaHoras";
            this.labelEstadiaHoras.Size = new System.Drawing.Size(12, 15);
            this.labelEstadiaHoras.TabIndex = 23;
            this.labelEstadiaHoras.Text = "-";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMonto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMonto.Location = new System.Drawing.Point(539, 185);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(12, 15);
            this.labelMonto.TabIndex = 24;
            this.labelMonto.Text = "-";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelLugaresVehiculos
            // 
            this.labelLugaresVehiculos.AutoSize = true;
            this.labelLugaresVehiculos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLugaresVehiculos.ForeColor = System.Drawing.Color.White;
            this.labelLugaresVehiculos.Location = new System.Drawing.Point(43, 252);
            this.labelLugaresVehiculos.Name = "labelLugaresVehiculos";
            this.labelLugaresVehiculos.Size = new System.Drawing.Size(117, 19);
            this.labelLugaresVehiculos.TabIndex = 27;
            this.labelLugaresVehiculos.Text = "Lugares vehiculos";
            // 
            // labelLugaresMotos
            // 
            this.labelLugaresMotos.AutoSize = true;
            this.labelLugaresMotos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLugaresMotos.ForeColor = System.Drawing.Color.White;
            this.labelLugaresMotos.Location = new System.Drawing.Point(43, 284);
            this.labelLugaresMotos.Name = "labelLugaresMotos";
            this.labelLugaresMotos.Size = new System.Drawing.Size(100, 19);
            this.labelLugaresMotos.TabIndex = 28;
            this.labelLugaresMotos.Text = "Lugares motos";
            // 
            // labelCantVehiculos
            // 
            this.labelCantVehiculos.AutoSize = true;
            this.labelCantVehiculos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCantVehiculos.ForeColor = System.Drawing.Color.White;
            this.labelCantVehiculos.Location = new System.Drawing.Point(187, 254);
            this.labelCantVehiculos.Name = "labelCantVehiculos";
            this.labelCantVehiculos.Size = new System.Drawing.Size(53, 19);
            this.labelCantVehiculos.TabIndex = 29;
            this.labelCantVehiculos.Text = "label15";
            // 
            // labelCantMotos
            // 
            this.labelCantMotos.AutoSize = true;
            this.labelCantMotos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCantMotos.ForeColor = System.Drawing.Color.White;
            this.labelCantMotos.Location = new System.Drawing.Point(187, 284);
            this.labelCantMotos.Name = "labelCantMotos";
            this.labelCantMotos.Size = new System.Drawing.Size(53, 19);
            this.labelCantMotos.TabIndex = 30;
            this.labelCantMotos.Text = "label16";
            // 
            // SalidaDeVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(644, 313);
            this.Controls.Add(this.labelCantMotos);
            this.Controls.Add(this.labelCantVehiculos);
            this.Controls.Add(this.labelLugaresMotos);
            this.Controls.Add(this.labelLugaresVehiculos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelEstadiaHoras);
            this.Controls.Add(this.labelMedioDePago);
            this.Controls.Add(this.labelFechaYHoraSalida);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTarifa);
            this.Controls.Add(this.labelTipoVehiculo);
            this.Controls.Add(this.labelPatente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelIdTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFechayHoraEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMostrarDatosComprobante);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDTicketAPagar);
            this.Controls.Add(this.label1);
            this.Name = "SalidaDeVehiculo";
            this.Text = "Id del ticket a pagar: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxIDTicketAPagar;
        private Label label2;
        private ComboBox comboBox1;
        private Button buttonMostrarDatosComprobante;
        private Label label3;
        private Label label4;
        private Label labelFechayHoraEntrada;
        private Button button1;
        private Label label5;
        private Label labelIdTicket;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelPatente;
        private Label labelTipoVehiculo;
        private Label labelTarifa;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label labelFechaYHoraSalida;
        private Label labelMedioDePago;
        private Label labelEstadiaHoras;
        private Label labelMonto;
        private Button button2;
        private Label labelLugaresVehiculos;
        private Label labelLugaresMotos;
        private Label labelCantVehiculos;
        private Label labelCantMotos;
    }
}