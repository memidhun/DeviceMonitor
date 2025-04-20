using System;
using System.IO;
using System.Windows.Forms;

namespace DeviceMonitor
{
    public partial class Form1 : Form
    {
        private SensorSimulator simulator;
        private StreamWriter logWriter;
        private bool isLogging = false;

        public Form1()
        {
            InitializeComponent();
            simulator = new SensorSimulator();
            timer1.Interval = 1000; // 1 second
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var data = simulator.GetSensorData();
            lblTemperature.Text = $"Temperature: {data.Temperature}°C";
            lblHumidity.Text = $"Humidity: {data.Humidity}%";

            if (isLogging && logWriter != null)
            {
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, Temp: {data.Temperature}°C, Humidity: {data.Humidity}%";
                logWriter.WriteLine(logEntry);
            }
        }

        private void btnStartLogging_Click(object sender, EventArgs e)
        {
            if (!isLogging)
            {
                logWriter = new StreamWriter("SensorLog.txt", true);
                isLogging = true;
                btnStartLogging.Enabled = false;
                btnStopLogging.Enabled = true;
            }
        }

        private void btnStopLogging_Click(object sender, EventArgs e)
        {
            if (isLogging)
            {
                isLogging = false;
                logWriter?.Close();
                btnStartLogging.Enabled = true;
                btnStopLogging.Enabled = false;
            }
        }
    }
}
