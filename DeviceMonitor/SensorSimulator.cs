using System;

namespace DeviceMonitor
{
    public class SensorData
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
    }

    public class SensorSimulator
    {
        private Random random = new Random();

        public SensorData GetSensorData()
        {
            int temperature = random.Next(20, 40); // 20°C to 40°C
            int humidity = random.Next(30, 70);    // 30% to 70%
            return new SensorData
            {
                Temperature = temperature,
                Humidity = humidity
            };
        }
    }
}
