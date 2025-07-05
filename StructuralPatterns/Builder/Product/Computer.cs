using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    public class Computer
    {
        public string CPU { get; set; }
        public int RAM { get; set; } // GB
        public string Storage { get; set; }
        public string GPU { get; set; }
        public string OperatingSystem { get; set; }
        public bool HasWiFi { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, RAM: {RAM} GB, Storage: {Storage}, GPU: {GPU}, OS: {OperatingSystem}, WiFi: {HasWiFi}";
        }
    }
}
