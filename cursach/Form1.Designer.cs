
namespace cursach
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
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calibrationButton
            // 
            this.calibrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrationButton.AutoSize = true;
            this.calibrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calibrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calibrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calibrationButton.Location = new System.Drawing.Point(306, 102);
            this.calibrationButton.Name = "calibrationButton";
            this.calibrationButton.Size = new System.Drawing.Size(169, 62);
            this.calibrationButton.TabIndex = 0;
            this.calibrationButton.Text = "Калибровка";
            this.calibrationButton.UseVisualStyleBackColor = true;
            this.calibrationButton.Click += new System.EventHandler(this.calibrationButton_Click);
            // 
            // serialPort3
            // 
            this.serialPort3.PortName = "COM3";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(306, 184);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(169, 75);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // serialPort4
            // 
            this.serialPort4.PortName = "COM4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.calibrationButton);
            this.Name = "Form1";
            this.Text = "Mechanical Glove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calibrationButton;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.Button startButton;
        private System.IO.Ports.SerialPort serialPort4;
        private System.Windows.Forms.Button button1;
    }
}

