namespace UART_Framework
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
            this.Estado = new System.Windows.Forms.Label();
            this.led_1 = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pulses = new System.Windows.Forms.Label();
            this.pulse2 = new System.Windows.Forms.Label();
            this.pulse3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.Disconnect = new System.Windows.Forms.PictureBox();
            this.Conect = new System.Windows.Forms.PictureBox();
            this.led_2 = new System.Windows.Forms.CheckBox();
            this.pKg = new System.Windows.Forms.Button();
            this.lKg = new System.Windows.Forms.Button();
            this.lC = new System.Windows.Forms.Button();
            this.pC = new System.Windows.Forms.Button();
            this.lLux = new System.Windows.Forms.Button();
            this.pLux = new System.Windows.Forms.Button();
            this.FlamesTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conect)).BeginInit();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(198, 618);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(221, 20);
            this.Estado.TabIndex = 2;
            this.Estado.Text = "Estado Actual: Desconectado";
            // 
            // led_1
            // 
            this.led_1.AutoSize = true;
            this.led_1.BackColor = System.Drawing.Color.Transparent;
            this.led_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led_1.Location = new System.Drawing.Point(12, 90);
            this.led_1.Name = "led_1";
            this.led_1.Size = new System.Drawing.Size(68, 24);
            this.led_1.TabIndex = 5;
            this.led_1.Text = "Led 1";
            this.led_1.UseVisualStyleBackColor = false;
            this.led_1.Visible = false;
            this.led_1.CheckedChanged += new System.EventHandler(this.led_1_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 654);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // pulses
            // 
            this.pulses.AutoSize = true;
            this.pulses.BackColor = System.Drawing.Color.Transparent;
            this.pulses.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulses.Location = new System.Drawing.Point(508, 196);
            this.pulses.Name = "pulses";
            this.pulses.Size = new System.Drawing.Size(175, 46);
            this.pulses.TabIndex = 4;
            this.pulses.Text = "None Kg";
            // 
            // pulse2
            // 
            this.pulse2.AutoSize = true;
            this.pulse2.BackColor = System.Drawing.Color.Transparent;
            this.pulse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulse2.Location = new System.Drawing.Point(508, 319);
            this.pulse2.Name = "pulse2";
            this.pulse2.Size = new System.Drawing.Size(172, 46);
            this.pulse2.TabIndex = 10;
            this.pulse2.Text = "None °C";
            // 
            // pulse3
            // 
            this.pulse3.AutoSize = true;
            this.pulse3.BackColor = System.Drawing.Color.Transparent;
            this.pulse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulse3.Location = new System.Drawing.Point(508, 442);
            this.pulse3.Name = "pulse3";
            this.pulse3.Size = new System.Drawing.Size(154, 46);
            this.pulse3.TabIndex = 11;
            this.pulse3.Text = "None V";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::UART_Framework.Properties.Resources.DaySm;
            this.pictureBox3.Location = new System.Drawing.Point(255, 555);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 50);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(103, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 404);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 373);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Image = global::UART_Framework.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(732, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 8;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Disconnect.Enabled = false;
            this.Disconnect.Image = global::UART_Framework.Properties.Resources.DisconnectB;
            this.Disconnect.Location = new System.Drawing.Point(481, 666);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(108, 36);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.TabStop = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            this.Disconnect.MouseLeave += new System.EventHandler(this.Disconnect_MouseLeave);
            this.Disconnect.MouseHover += new System.EventHandler(this.Disconnect_MouseHover);
            // 
            // Conect
            // 
            this.Conect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Conect.Image = global::UART_Framework.Properties.Resources.ConnectB;
            this.Conect.Location = new System.Drawing.Point(40, 666);
            this.Conect.Name = "Conect";
            this.Conect.Size = new System.Drawing.Size(108, 36);
            this.Conect.TabIndex = 0;
            this.Conect.TabStop = false;
            this.Conect.Click += new System.EventHandler(this.Conect_Click);
            this.Conect.MouseLeave += new System.EventHandler(this.Conect_MouseLeave);
            this.Conect.MouseHover += new System.EventHandler(this.Conect_MouseHover);
            // 
            // led_2
            // 
            this.led_2.AutoSize = true;
            this.led_2.BackColor = System.Drawing.Color.Transparent;
            this.led_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led_2.Location = new System.Drawing.Point(12, 120);
            this.led_2.Name = "led_2";
            this.led_2.Size = new System.Drawing.Size(68, 24);
            this.led_2.TabIndex = 6;
            this.led_2.Text = "Led 2";
            this.led_2.UseVisualStyleBackColor = false;
            this.led_2.Visible = false;
            this.led_2.CheckedChanged += new System.EventHandler(this.led_2_CheckedChanged);
            // 
            // pKg
            // 
            this.pKg.Location = new System.Drawing.Point(5, 160);
            this.pKg.Name = "pKg";
            this.pKg.Size = new System.Drawing.Size(75, 23);
            this.pKg.TabIndex = 15;
            this.pKg.Text = "+ Kg";
            this.pKg.UseVisualStyleBackColor = true;
            this.pKg.Click += new System.EventHandler(this.pKg_Click);
            // 
            // lKg
            // 
            this.lKg.Location = new System.Drawing.Point(5, 196);
            this.lKg.Name = "lKg";
            this.lKg.Size = new System.Drawing.Size(75, 23);
            this.lKg.TabIndex = 16;
            this.lKg.Text = "- Kg";
            this.lKg.UseVisualStyleBackColor = true;
            this.lKg.Click += new System.EventHandler(this.lKg_Click);
            // 
            // lC
            // 
            this.lC.Location = new System.Drawing.Point(5, 308);
            this.lC.Name = "lC";
            this.lC.Size = new System.Drawing.Size(75, 23);
            this.lC.TabIndex = 18;
            this.lC.Text = "- C";
            this.lC.UseVisualStyleBackColor = true;
            this.lC.Click += new System.EventHandler(this.lC_Click);
            // 
            // pC
            // 
            this.pC.Location = new System.Drawing.Point(5, 272);
            this.pC.Name = "pC";
            this.pC.Size = new System.Drawing.Size(75, 23);
            this.pC.TabIndex = 17;
            this.pC.Text = "+ C";
            this.pC.UseVisualStyleBackColor = true;
            this.pC.Click += new System.EventHandler(this.pC_Click);
            // 
            // lLux
            // 
            this.lLux.Location = new System.Drawing.Point(5, 426);
            this.lLux.Name = "lLux";
            this.lLux.Size = new System.Drawing.Size(75, 23);
            this.lLux.TabIndex = 20;
            this.lLux.Text = "- Lux";
            this.lLux.UseVisualStyleBackColor = true;
            this.lLux.Click += new System.EventHandler(this.lLux_Click);
            // 
            // pLux
            // 
            this.pLux.Location = new System.Drawing.Point(5, 390);
            this.pLux.Name = "pLux";
            this.pLux.Size = new System.Drawing.Size(75, 23);
            this.pLux.TabIndex = 19;
            this.pLux.Text = "+ Lux";
            this.pLux.UseVisualStyleBackColor = true;
            this.pLux.Click += new System.EventHandler(this.pLux_Click);
            // 
            // FlamesTimer
            // 
            this.FlamesTimer.Enabled = true;
            this.FlamesTimer.Interval = 200;
            this.FlamesTimer.Tick += new System.EventHandler(this.FlamesTimer_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UART_Framework.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(770, 730);
            this.Controls.Add(this.lLux);
            this.Controls.Add(this.pLux);
            this.Controls.Add(this.lC);
            this.Controls.Add(this.pC);
            this.Controls.Add(this.lKg);
            this.Controls.Add(this.pKg);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pulse3);
            this.Controls.Add(this.pulse2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.led_2);
            this.Controls.Add(this.led_1);
            this.Controls.Add(this.pulses);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Conect);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Conect;
        private System.Windows.Forms.PictureBox Disconnect;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.CheckBox led_1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label pulses;
        private System.Windows.Forms.Label pulse2;
        private System.Windows.Forms.Label pulse3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox led_2;
        private System.Windows.Forms.Button pKg;
        private System.Windows.Forms.Button lKg;
        private System.Windows.Forms.Button lC;
        private System.Windows.Forms.Button pC;
        private System.Windows.Forms.Button lLux;
        private System.Windows.Forms.Button pLux;
        private System.Windows.Forms.Timer FlamesTimer;
    }
}

