namespace DeviceMonitor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Button btnStartLogging;
        private System.Windows.Forms.Button btnStopLogging;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.btnStartLogging = new System.Windows.Forms.Button();
            this.btnStopLogging = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // lblTemperature
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTemperature.Location = new System.Drawing.Point(30, 30);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(170, 25);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "Temperature: 0°C";

            // lblHumidity
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblHumidity.Location = new System.Drawing.Point(30, 70);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(135, 25);
            this.lblHumidity.TabIndex = 1;
            this.lblHumidity.Text = "Humidity: 0%";

            // btnStartLogging
            this.btnStartLogging.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStartLogging.Location = new System.Drawing.Point(30, 120);
            this.btnStartLogging.Name = "btnStartLogging";
            this.btnStartLogging.Size = new System.Drawing.Size(120, 40);
            this.btnStartLogging.TabIndex = 2;
            this.btnStartLogging.Text = "Start Logging";
            this.btnStartLogging.UseVisualStyleBackColor = true;
            this.btnStartLogging.Click += new System.EventHandler(this.btnStartLogging_Click);

            // btnStopLogging
            this.btnStopLogging.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStopLogging.Location = new System.Drawing.Point(170, 120);
            this.btnStopLogging.Name = "btnStopLogging";
            this.btnStopLogging.Size = new System.Drawing.Size(120, 40);
            this.btnStopLogging.TabIndex = 3;
            this.btnStopLogging.Text = "Stop Logging";
            this.btnStopLogging.UseVisualStyleBackColor = true;
            this.btnStopLogging.Click += new System.EventHandler(this.btnStopLogging_Click);
            this.btnStopLogging.Enabled = false;

            // timer1
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 200);
            this.Controls.Add(this.btnStopLogging);
            this.Controls.Add(this.btnStartLogging);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Device Monitor";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
