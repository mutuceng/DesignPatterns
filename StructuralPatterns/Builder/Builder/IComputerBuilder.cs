using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetCPU(string cpu);
        IComputerBuilder SetRAM(int ram);
        IComputerBuilder SetStorage(string storage);
        IComputerBuilder SetGPU(string gpu);
        IComputerBuilder SetOperatingSystem(string os);
        IComputerBuilder EnableWiFi(bool enabled);
        Computer Build();
    }
}
