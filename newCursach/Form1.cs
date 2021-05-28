using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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
            //string[] ports = SerialPort.GetPortNames();
            serialPortTemp.BaudRate = 9600;
            serialPortTemp.DtrEnable = true;
            serialPort3.BaudRate = 9600;
            serialPort3.DtrEnable = true;
            serialPort4.BaudRate = 9600;
            serialPort4.DtrEnable = true;/*
            for (int i = 0; i < ports.Length; i++)
            {
                serialPortTemp.PortName = ports[i];
                Thread.Sleep(2000);
                serialPortTemp.Open();
                string message = serialPortTemp.ReadLine();
                if (message == "I AM SERVO") serialPort3.PortName = ports[i];
                serialPortTemp.Close();
            }*/
            
            //startButton.Enabled = false;
            serialPort3.PortName = "COM3";
            //serialPort3.Open();
            serialPort4.PortName = "COM4";
            //serialPort4.Open();
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

            //serialPort4.PortName = Form1.potenzPort;
            if (!serialPort4.IsOpen)
            {
                serialPort4.Open();
                Thread.Sleep(1500);
            }
            serialPort4.WriteLine("START");

            this.startButton.Enabled = false;
            /*while (true)
            {
                serialPort4.WriteLine("START");
                max0Label.Text = "+" + input;
                if (input.Contains("end cycle"))
                    break;
                
            }*/
            max0Label.Text = "start writing";
            Thread.Sleep(1000);

            serialPort4.WriteLine(Form1.max0);
            Thread.Sleep(1000);
            serialPort4.WriteLine(Form1.max1);
            Thread.Sleep(1000);
            serialPort4.WriteLine(Form1.max2);
            Thread.Sleep(1000);

            //serialPort4.WriteLine(Form1.max3);
            serialPort4.WriteLine(Form1.min0);
            Thread.Sleep(1000);
            serialPort4.WriteLine(Form1.min1);
            Thread.Sleep(1000);
            serialPort4.WriteLine(Form1.min2);
            Thread.Sleep(1000);
            serialPort4.WriteLine(Form1.min3);
            Thread.Sleep(1000);
            if (!serialPort3.IsOpen)
            {
                serialPort3.Open();
                Thread.Sleep(1500);
            }
            //serialPort3.WriteLine("START");
            Thread.Sleep(500);
            
            
            
            
            startFlag = false;
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
                    serialPort3.WriteLine(angle_str);
                }
                catch
                {
                    startFlag = true;
                }
                Thread.Sleep(100);
            }
            
        }

        

        private void stopButton_Click(object sender, EventArgs e)
        {
            startFlag = true;
            this.startStopLabel.Text = readThread.ThreadState.ToString();
            this.statusLabel.Text = "stop reading";
            this.startButton.Enabled = true;
            serialPort3.Close();
            serialPort4.Close();
        }
    }
}
