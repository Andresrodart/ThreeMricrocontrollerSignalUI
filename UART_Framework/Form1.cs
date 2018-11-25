using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UART_Framework
{
    public partial class Form1 : Form
    {
        int flag = 0;
        double pulse_one = 0, pulse_two = 297, pulse_three = 0;
        int tiempo = 0, KgCheck = 0, Sun = 1, FlameSelector = 0, FlameInstensity = 0, FlameInstensityR = 0;
        string lectura;

        List<List<Image>> FlamesBorder = new List<List<Image>>() {
            new List<Image>() { UART_Framework.Properties.Resources._1_25, UART_Framework.Properties.Resources._2_25, UART_Framework.Properties.Resources._3_25, UART_Framework.Properties.Resources._4_25 },
            new List<Image>() { UART_Framework.Properties.Resources._1_50, UART_Framework.Properties.Resources._2_50, UART_Framework.Properties.Resources._3_50, UART_Framework.Properties.Resources._4_50 },
            new List<Image>() { UART_Framework.Properties.Resources._1_75, UART_Framework.Properties.Resources._2_75, UART_Framework.Properties.Resources._3_75, UART_Framework.Properties.Resources._4_75 },
            new List<Image>() { UART_Framework.Properties.Resources._1, UART_Framework.Properties.Resources._2, UART_Framework.Properties.Resources._3, UART_Framework.Properties.Resources._4 }
        };
        List<List<Image>> Body = new List<List<Image>>(){
             new List<Image>() { UART_Framework.Properties.Resources._0_5, UART_Framework.Properties.Resources._1_5, UART_Framework.Properties.Resources._2_5, UART_Framework.Properties.Resources._3_5, UART_Framework.Properties.Resources._4_5, UART_Framework.Properties.Resources._5_5 },
             new List<Image>() { UART_Framework.Properties.Resources._0_4, UART_Framework.Properties.Resources._1_4, UART_Framework.Properties.Resources._2_4, UART_Framework.Properties.Resources._3_4, UART_Framework.Properties.Resources._4_4, UART_Framework.Properties.Resources._5_4 },
             new List<Image>() { UART_Framework.Properties.Resources._0_3, UART_Framework.Properties.Resources._1_3, UART_Framework.Properties.Resources._2_3, UART_Framework.Properties.Resources._3_3, UART_Framework.Properties.Resources._4_3, UART_Framework.Properties.Resources._5_3 },
             new List<Image>() { UART_Framework.Properties.Resources._0_2, UART_Framework.Properties.Resources._1_2, UART_Framework.Properties.Resources._2_2, UART_Framework.Properties.Resources._3_2, UART_Framework.Properties.Resources._4_2, UART_Framework.Properties.Resources._5_2 }
        };
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Image = null;
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(40, 0);
            pictureBox1.BackColor = Color.Transparent;
            try
            {
                foreach (String s in System.IO.Ports.SerialPort.GetPortNames())
                    comboBox1.Items.Add(s);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Conect_MouseHover(object sender, EventArgs e)
        {
            Conect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            if (comboBox1.Text == "")
                Conect.Enabled = false;
        }

        private void Conect_MouseLeave(object sender, EventArgs e)
        {
            Conect.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void Disconnect_MouseHover(object sender, EventArgs e)
        {
            Disconnect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void Disconnect_MouseLeave(object sender, EventArgs e)
        {
            Disconnect.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Conect_Click(object sender, EventArgs e)
        {
            flag = 1;                
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            Conect.Enabled = false;
            Disconnect.Enabled = true;
            led_1.Enabled = led_2.Enabled = true;
            Estado.Text = "Estado Actual: Conectado";
            //chart1.Series[0].Points.Clear();
            tiempo = 0;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            flag = 2;
            Conect.Enabled = true;
            Disconnect.Enabled = false;
            led_1.Enabled = led_2.Enabled = false;
            Estado.Text = "Estado Actual: Desconectado";
            /*Se escribe en el puerto serial 2 y 4 para que le lleguen al pic
             y para que el pic apague los leds que previemente se hizo en el 
             micro*/
            serialPort1.Write("2");
            serialPort1.Write("4");
            serialPort1.Close();
        }

        private void led_1_CheckedChanged(object sender, EventArgs e)
        {
            if(flag == 1)
                if(led_1.Checked == true)
                    serialPort1.Write("1");
                else
                    serialPort1.Write("2");
        }

        private void led_2_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
                if (led_2.Checked == true)
                    serialPort1.Write("3");
                else
                    serialPort1.Write("4");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag == 1)
                serialPort1.Write("9"); //Para que devuelva al adc lo leido

            pulses.Text = pulse_one / 100 + "Kg";
            pulse2.Text = pulse_two / 100 + "°C";
            pulse3.Text = pulse_three / 100 + "V";

            if (pulse_one < 100 && (KgCheck != 0 || FlameInstensityR != FlameInstensity)){
                pictureBox1.Image = Body[FlameInstensity][0];
                KgCheck = 0;
            } else if (pulse_one >= 100 && pulse_one < 200 && (KgCheck != 1 || FlameInstensityR != FlameInstensity)){
                pictureBox1.Image = Body[FlameInstensity][1];
                KgCheck = 1;
            } else if (pulse_one >= 200 && pulse_one < 300 && (KgCheck != 2 || FlameInstensityR != FlameInstensity)){
                pictureBox1.Image = Body[FlameInstensity][2];
                KgCheck = 2;
            } else if (pulse_one >= 300 && pulse_one < 400 && (KgCheck != 3 || FlameInstensityR != FlameInstensity)){
                pictureBox1.Image = Body[FlameInstensity][3];
                KgCheck = 3;
            } else if (pulse_one >= 400 && pulse_one < 500 && (KgCheck != 4 || FlameInstensityR != FlameInstensity)){
                pictureBox1.Image = Body[FlameInstensity][4];
                KgCheck = 4;
            } else if (pulse_one >= 500 && (KgCheck != 5 || FlameInstensityR != FlameInstensity)){
                pictureBox1.Image = Body[FlameInstensity - 1][5];
                KgCheck = 5;
            }

            if (pulse_three <= 200 && Sun == 1){
                pictureBox3.Image = UART_Framework.Properties.Resources.D_N_50x14msSm;
                Sun = 0;
            } else if (pulse_three <= 200 && Sun == 0){
                pictureBox3.Image = UART_Framework.Properties.Resources.NiteSm;
            } else if (pulse_three > 200 && Sun == 0){
                pictureBox3.Image = UART_Framework.Properties.Resources.N_D_50x14msSm;
                Sun = 1;
            }else if (pulse_three > 200 && Sun == 1){
                pictureBox3.Image = UART_Framework.Properties.Resources.DaySm;
            }

            FlameInstensityR = FlameInstensity;
        }
        
        private void pKg_Click(object sender, EventArgs e)
        {
            pulse_one += 10;
        }

        private void lKg_Click(object sender, EventArgs e)
        {
            pulse_one -= 10;
        }

        private void pC_Click(object sender, EventArgs e)
        {
            pulse_two += 1;
        }

        private void lC_Click(object sender, EventArgs e)
        {
            pulse_two -= 1;
        }

        private void FlamesTimer_Tick(object sender, EventArgs e)
        {
            FlameSelector = FlameSelector == 3 ? 0 : ++FlameSelector;
            if (pulse_two < 303){
                pictureBox2.Image = null;
                FlameInstensity = 0;
            } else if (pulse_two >= 303 && pulse_two < 308){
                pictureBox2.Image = FlamesBorder[0][FlameSelector];
                FlameInstensity = 1;
            } else if (pulse_two >= 308 && pulse_two < 313){
                pictureBox2.Image = FlamesBorder[1][FlameSelector];
                FlameInstensity = 2;
            } else if (pulse_two >= 313 && pulse_two < 318){
                pictureBox2.Image = FlamesBorder[2][FlameSelector];
                FlameInstensity = 3;
            } else if (pulse_two >= 318){
                pictureBox2.Image = FlamesBorder[3][FlameSelector];
                FlameInstensity = 4;
            }

        }

        private void pLux_Click(object sender, EventArgs e)
        {
            pulse_three += 10;
        }

        private void lLux_Click(object sender, EventArgs e)
        {
            pulse_three -= 10;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (flag == 1){
                lectura = serialPort1.ReadLine();
                System.Console.WriteLine("Lectura: " + lectura);
                string [] separetor = lectura.Split('-');
                System.Console.WriteLine("Miultiplexor: " + separetor[0] + " value " + separetor[1]);
                string value_aux = separetor[1].ToString();
                double temporal = Convert.ToDouble(value_aux.Remove(value_aux.ToString().Length - 1));
                int multiplexor = Convert.ToInt16(separetor[0]);
                //isEnable.Text = "Detección del sensor: " + temporal + "V"; 
                if(multiplexor == 0)
                    pulse_one= temporal;
                else if (multiplexor == 1)
                    pulse_two = temporal;
                else if (multiplexor == 2)
                    pulse_three = temporal;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.Titles.Add("Gráfica de voltaje");
        }
    }
}
