
namespace newCursach
{
    partial class calibrationForm
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
            this.components = new System.ComponentModel.Container();
            this.maxButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.countinueButton = new System.Windows.Forms.Button();
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.max0Label = new System.Windows.Forms.Label();
            this.max3Label = new System.Windows.Forms.Label();
            this.min0Label = new System.Windows.Forms.Label();
            this.min3Label = new System.Windows.Forms.Label();
            this.serialPortTemp = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(341, 49);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(149, 66);
            this.maxButton.TabIndex = 0;
            this.maxButton.Text = "Разжатие";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(341, 135);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(149, 66);
            this.minButton.TabIndex = 1;
            this.minButton.Text = "Сжатие";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.Location = new System.Drawing.Point(341, 221);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(149, 66);
            this.repeatButton.TabIndex = 2;
            this.repeatButton.Text = "Повторить";
            this.repeatButton.UseVisualStyleBackColor = true;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // countinueButton
            // 
            this.countinueButton.Location = new System.Drawing.Point(341, 313);
            this.countinueButton.Name = "countinueButton";
            this.countinueButton.Size = new System.Drawing.Size(149, 59);
            this.countinueButton.TabIndex = 3;
            this.countinueButton.Text = "Готово";
            this.countinueButton.UseVisualStyleBackColor = true;
            this.countinueButton.Click += new System.EventHandler(this.countinueButton_Click);
            // 
            // serialPort4
            // 
            this.serialPort4.PortName = "-";
            // 
            // max0Label
            // 
            this.max0Label.AutoSize = true;
            this.max0Label.Location = new System.Drawing.Point(553, 135);
            this.max0Label.Name = "max0Label";
            this.max0Label.Size = new System.Drawing.Size(41, 17);
            this.max0Label.TabIndex = 4;
            this.max0Label.Text = "max0";
            // 
            // max3Label
            // 
            this.max3Label.AutoSize = true;
            this.max3Label.Location = new System.Drawing.Point(556, 183);
            this.max3Label.Name = "max3Label";
            this.max3Label.Size = new System.Drawing.Size(41, 17);
            this.max3Label.TabIndex = 5;
            this.max3Label.Text = "max3";
            // 
            // min0Label
            // 
            this.min0Label.AutoSize = true;
            this.min0Label.Location = new System.Drawing.Point(556, 233);
            this.min0Label.Name = "min0Label";
            this.min0Label.Size = new System.Drawing.Size(38, 17);
            this.min0Label.TabIndex = 6;
            this.min0Label.Text = "min0";
            // 
            // min3Label
            // 
            this.min3Label.AutoSize = true;
            this.min3Label.Location = new System.Drawing.Point(559, 269);
            this.min3Label.Name = "min3Label";
            this.min3Label.Size = new System.Drawing.Size(38, 17);
            this.min3Label.TabIndex = 7;
            this.min3Label.Text = "min3";
            // 
            // calibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.min3Label);
            this.Controls.Add(this.min0Label);
            this.Controls.Add(this.max3Label);
            this.Controls.Add(this.max0Label);
            this.Controls.Add(this.countinueButton);
            this.Controls.Add(this.repeatButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.maxButton);
            this.Name = "calibrationForm";
            this.Text = "Калибровка";
            this.Load += new System.EventHandler(this.calibrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.Button countinueButton;
        private System.IO.Ports.SerialPort serialPort4;
        private System.Windows.Forms.Label max0Label;
        private System.Windows.Forms.Label max3Label;
        private System.Windows.Forms.Label min0Label;
        private System.Windows.Forms.Label min3Label;
        private System.IO.Ports.SerialPort serialPortTemp;
    }
}