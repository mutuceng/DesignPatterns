using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class ComputerDirector
    {
        private IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }
        public Computer BuildGamingComputer()
        {
            return _builder
                .SetCPU("Intel Core i9")
                .SetRAM(32)
                .SetStorage("1TB NVMe SSD")
                .SetGPU("NVIDIA RTX 4080")
                .SetOperatingSystem("Windows 11")
                .EnableWiFi(true)
                .Build();
        }

        public Computer BuildOfficeComputer()
        {
            return _builder
                .SetCPU("Intel Core i5")
                .SetRAM(16)
                .SetStorage("512GB SSD")
                .SetGPU("Integrated Intel Graphics")
                .SetOperatingSystem("Windows 10 Pro")
                .EnableWiFi(false)
                .Build();
        }

        public Computer BuildLinuxDeveloperLaptop()
        {
            return _builder
                .SetCPU("AMD Ryzen 7")
                .SetRAM(32)
                .SetStorage("1TB SSD")
                .SetGPU("Integrated AMD Radeon")
                .SetOperatingSystem("Ubuntu 24.04")
                .EnableWiFi(true)
                .Build();
        }
    }
}
