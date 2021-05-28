
namespace newCursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.calibrationButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.startStopLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.serialPortTemp = new System.IO.Ports.SerialPort(this.components);
            this.max0Label = new System.Windows.Forms.Label();
            this.max2Label = new System.Windows.Forms.Label();
            this.min0Label = new System.Windows.Forms.Label();
            this.min2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calibrationButton
            // 
            this.calibrationButton.Location = new System.Drawing.Point(328, 70);
            this.calibrationButton.Name = "calibrationButton";
            this.calibrationButton.Size = new System.Drawing.Size(148, 62);
            this.calibrationButton.TabIndex = 0;
            this.calibrationButton.Text = "Калибровка";
            this.calibrationButton.UseVisualStyleBackColor = true;
            this.calibrationButton.Click += new System.EventHandler(this.calibrationButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(328, 180);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(148, 62);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(328, 299);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(148, 62);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // serialPort3
            // 
            this.serialPort3.PortName = "COM3";
            // 
            // serialPort4
            // 
            this.serialPort4.PortName = "COM4";
            // 
            // startStopLabel
            // 
            this.startStopLabel.AutoSize = true;
            this.startStopLabel.Location = new System.Drawing.Point(565, 188);
            this.startStopLabel.Name = "startStopLabel";
            this.startStopLabel.Size = new System.Drawing.Size(47, 17);
            this.startStopLabel.TabIndex = 3;
            this.startStopLabel.Text = "angle:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(568, 124);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 17);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "status:";
            // 
            // max0Label
            // 
            this.max0Label.AutoSize = true;
            this.max0Label.Location = new System.Drawing.Point(566, 225);
            this.max0Label.Name = "max0Label";
            this.max0Label.Size = new System.Drawing.Size(49, 17);
            this.max0Label.TabIndex = 5;
            this.max0Label.Text = "max0: ";
            // 
            // max2Label
            // 
            this.max2Label.AutoSize = true;
            this.max2Label.Location = new System.Drawing.Point(565, 262);
            this.max2Label.Name = "max2Label";
            this.max2Label.Size = new System.Drawing.Size(45, 17);
            this.max2Label.TabIndex = 6;
            this.max2Label.Text = "max2:";
            // 
            // min0Label
            // 
            this.min0Label.AutoSize = true;
            this.min0Label.Location = new System.Drawing.Point(569, 299);
            this.min0Label.Name = "min0Label";
            this.min0Label.Size = new System.Drawing.Size(46, 17);
            this.min0Label.TabIndex = 7;
            this.min0Label.Text = "min0: ";
            // 
            // min2Label
            // 
            this.min2Label.AutoSize = true;
            this.min2Label.Location = new System.Drawing.Point(569, 344);
            this.min2Label.Name = "min2Label";
            this.min2Label.Size = new System.Drawing.Size(42, 17);
            this.min2Label.TabIndex = 8;
            this.min2Label.Text = "min2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.min2Label);
            this.Controls.Add(this.min0Label);
            this.Controls.Add(this.max2Label);
            this.Controls.Add(this.max0Label);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startStopLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.calibrationButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calibrationButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        private System.Windows.Forms.Label startStopLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.IO.Ports.SerialPort serialPortTemp;
        private System.Windows.Forms.Label max0Label;
        private System.Windows.Forms.Label max2Label;
        private System.Windows.Forms.Label min0Label;
        private System.Windows.Forms.Label min2Label;
    }
}

