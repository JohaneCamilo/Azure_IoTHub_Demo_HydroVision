using System;
using System.Collections.Generic;
using System.Text;

namespace HydroVision_TemperatureHumiditySensor.Models
{
    class Device
    {
        public string DeviceId { get; set; }
        public int TimeSent { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }
}
