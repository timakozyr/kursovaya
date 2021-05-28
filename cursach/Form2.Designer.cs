
namespace cursach
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
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.maxButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.countinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort4
            // 
            this.serialPort4.PortName = "COM4";
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(312, 74);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(150, 73);
            this.maxButton.TabIndex = 0;
            this.maxButton.Text = "Разжатие";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(312, 186);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(150, 75);
            this.minButton.TabIndex = 1;
            this.minButton.Text = "Сжатие";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.Location = new System.Drawing.Point(312, 307);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(150, 69);
            this.repeatButton.TabIndex = 2;
            this.repeatButton.Text = "Повторить";
            this.repeatButton.UseVisualStyleBackColor = true;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // countinueButton
            // 
            this.countinueButton.Location = new System.Drawing.Point(312, 412);
            this.countinueButton.Name = "countinueButton";
            this.countinueButton.Size = new System.Drawing.Size(150, 69);
            this.countinueButton.TabIndex = 5;
            this.countinueButton.Text = "Готово";
            this.countinueButton.UseVisualStyleBackColor = true;
            this.countinueButton.Click += new System.EventHandler(this.countinueButton_Click);
            // 
            // calibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.countinueButton);
            this.Controls.Add(this.repeatButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.maxButton);
            this.Name = "calibrationForm";
            this.Text = "Calibration";
            this.Load += new System.EventHandler(this.calibrationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort4;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button countinueButton;
    }
}