using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newCursach
{
    public partial class calibrationForm : Form
    {
        
        private Button button1;

        public calibrationForm(Button button1)
        {
            InitializeComponent();
            serialPortTemp.BaudRate = 9600;
            serialPortTemp.DtrEnable = true;
            serialPort4.BaudRate = 9600;
            serialPort4.DtrEnable = true;
            serialPort4.PortName = "COM4";
            if (!serialPort4.IsOpen)
            {
                maxButton.Enabled = false;
                serialPort4.Open();
                Thread.Sleep(1500);
            }
            maxButton.Enabled = true;
            minButton.Enabled = false;
            repeatButton.Enabled = false;
            countinueButton.Enabled = false;
            this.button1 = button1;
        }

        private void calibrationForm_Load(object sender, EventArgs e)
        {

        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            this.max0Label.Text = "Чтение начато";
            serialPort4.WriteLine("MAX");
            Form1.max0 = serialPort4.ReadLine();
            Form1.max1 = serialPort4.ReadLine();
            Form1.max2 = serialPort4.ReadLine();
            //Form1.max3 = serialPort4.ReadLine();
            this.max0Label.Text = "max0: " + Form1.max0.ToString();
            this.max3Label.Text = "max1: " + Form1.max1.ToString();
            maxButton.Enabled = false;
            minButton.Enabled = true;
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            serialPort4.WriteLine("MIN");
            Form1.min0 = serialPort4.ReadLine();
            Form1.min1 = serialPort4.ReadLine();
            Form1.min2 = serialPort4.ReadLine();
            Form1.min3 = serialPort4.ReadLine();
            this.min0Label.Text = "min0: " + Form1.min0.ToString();
            this.min3Label.Text = "min3: " + Form1.min3.ToString();
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
            button1.Enabled = true;
            serialPort4.WriteLine("COUNTINUE");
            serialPort4.Close();
            Close();
        }
    }
}
