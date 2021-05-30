using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newCursach
{
    public partial class Form1 : Form
    {
        Thread readThread;
        public Form1()
        {
            InitializeComponent();
            serialPortTemp.BaudRate = 9600;
            serialPortTemp.DtrEnable = true;
            serialPort3.BaudRate = 9600;
            serialPort3.DtrEnable = true;
            serialPort4.BaudRate = 9600;
            serialPort4.DtrEnable = true;
            serialPort3.PortName = "COM3";
            serialPort4.PortName = "COM4";
            startButton.Enabled = false;
            stopButton.Enabled = false;
        }

        public static bool calibrationFlag { get; set; }

        public static string max0 { get; set; }
        public static string max1 { get; set; }
        public static string max2 { get; set; }
        public static string max3 { get; set; }

        public static string min0 { get; set; }
        public static string min1 { get; set; }
        public static string min2 { get; set; }
        public static string min3 { get; set; }
        public static string potenzPort { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calibrationButton_Click(object sender, EventArgs e)
        {
            calibrationForm newForm = new calibrationForm(this.startButton);
            statusLabel.Text = "COM name: " + serialPort3.PortName;
            newForm.Show();
        }
        
        //public Button startButton;

        bool startFlag;
        public void startButton_Click(object sender, EventArgs e)
        {
            if (!serialPort4.IsOpen)
            {
                serialPort4.Open();
                serialPort4.DiscardInBuffer();
                Thread.Sleep(1500);
            }
            calibrationButton.Enabled = false;
            stopButton.Enabled = true;
            serialPort4.WriteLine("START");
            this.startButton.Enabled = false;
            max0Label.Text = "start writing";
            Thread.Sleep(1500);
            serialPort4.WriteLine(Form1.max0);
            Thread.Sleep(1500);
            serialPort4.WriteLine(Form1.max1);
            Thread.Sleep(1500);
            serialPort4.WriteLine(Form1.max2);
            Thread.Sleep(1500);
            serialPort4.WriteLine(Form1.min0);
            Thread.Sleep(1500);
            serialPort4.WriteLine(Form1.min1);
            Thread.Sleep(1500);
            serialPort4.WriteLine(Form1.min2);
            Thread.Sleep(1500);
            serialPort4.WriteLine(Form1.min3);
            Thread.Sleep(1500);
            if (!serialPort3.IsOpen)
            {
                serialPort3.Open();
                serialPort3.DiscardInBuffer();
                Thread.Sleep(1600);
            }
            serialPort3.WriteLine("START");
            startFlag = false;
            max0Label.Text = "max0: " + serialPort4.ReadLine();
            max2Label.Text = "max2: " + serialPort4.ReadLine();
            min0Label.Text = "min0: " + serialPort4.ReadLine();
            min2Label.Text = "min2: " + serialPort4.ReadLine();
            Thread.Sleep(1200);
            readThread = new Thread(new ThreadStart(Count));
            readThread.Start();
        }
        private void Count()
        {
            string angle_str;
            while (!startFlag)
            {
                if (startFlag)
                {
                    return;
                }
                try
                {
                    angle_str = serialPort4.ReadLine();
                    Thread.Sleep(1000);
                    serialPort3.WriteLine(angle_str);
                    File.AppendAllText("C:/Users/asus/Desktop/kursovaya/newCursach/output.txt", angle_str);
                    string str;
                    str = serialPort3.ReadLine();
                    File.AppendAllText("C:/Users/asus/Desktop/kursovaya/newCursach/output_servo.txt", str);
                }
                catch (Exception e)
                {
                    startFlag = true;
                    File.AppendAllText("C:/Users/asus/Desktop/kursovaya/newCursach/output_excepts.txt", e.Message);
                }
                Thread.Sleep(100);
            }
            
        }

        

        private void stopButton_Click(object sender, EventArgs e)
        {
            startFlag = true;
            calibrationButton.Enabled = true;
            stopButton.Enabled = false;
            this.startStopLabel.Text = readThread.ThreadState.ToString();
            this.statusLabel.Text = "stop reading";
            this.startButton.Enabled = true;
            serialPort3.Close();
            serialPort4.Close();
        }
    }
}
