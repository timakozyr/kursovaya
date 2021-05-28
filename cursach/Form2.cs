using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    public partial class calibrationForm : Form
    {
        public calibrationForm()
        {
            
            serialPort4 = new System.IO.Ports.SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            serialPort4.Open();
            minButton.Enabled = false;
            repeatButton.Enabled = false;
            countinueButton.Enabled = false;
            InitializeComponent();
            /*try
            {*/
            //serialPort4.Open();
            /*}
            catch (Exception e)
            {
                repeatButton.Text = e.Message;
            }*/


            private void calibrationForm_Load(object sender, EventArgs e)
        {

        }

        private void calibrationForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            //serialPort4.WriteLine("START");
            //serialPort4.Close();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            serialPort4.WriteLine("MAX");
            maxButton.Enabled = false;
            minButton.Enabled = true;
            /*TextBox textbox = new TextBox();
            textbox.Text = serialPort4.ReadLine();
            textbox.Location = new Point(526, 270);//местоположение нового текстбокса
            this.Controls.Add(textbox);*/

        }

        private void minButton_Click(object sender, EventArgs e)
        {
            serialPort4.WriteLine("MIN");
            minButton.Enabled = false;
            repeatButton.Enabled = true;
            countinueButton.Enabled = true;
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            maxButton.Enabled = true;
            repeatButton.Enabled = false;
            countinueButton.Enabled = false;
        }

        private void countinueButton_Click(object sender, EventArgs e)
        {
            serialPort4.WriteLine("COUNTINUE");
            serialPort4.Close();
        }
        }
    }  
}
