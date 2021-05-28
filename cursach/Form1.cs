using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    public partial class Form1 : Form
    {
        private const string nameOfMainForm = "Mechanical Glove";

        public Form1()
        {
            InitializeComponent();
            Text = nameOfMainForm;
            //serialPort3.Open();
            //startButton.Enabled = false;
        }

        private void calibrationButton_Click(object sender, EventArgs e)
        {
            calibrationForm newForm = new calibrationForm();
            
            newForm.Show();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        bool startFlag;

        public void startButton_Click(object sender, EventArgs e)
        {
            serialPort4.Open();
            serialPort3.Open();
            serialPort4.WriteLine("START");
            serialPort3.WriteLine("START");
            startFlag = false;
            string angle_str;
            while (true)
            {
                angle_str = serialPort4.ReadLine();
                serialPort3.WriteLine(angle_str);
                if (startFlag) break;
            }
        }

        public void stopButton_Click(object sender, EventArgs e)
        {
            startFlag = true;
        }

    }
}
