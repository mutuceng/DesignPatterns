using Bridge.Abstraction;
using Bridge.Concrete___Implementors;
using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Refined_Abstractions
{
    public class AirConditionerController : RemoteControl
    {
        private readonly AirConditioner _ac;
        public AirConditionerController(AirConditioner device) : base(device)
        {
            _ac = device;
        }

        public void IncreaseTemp()
        {
            _ac.IncreaseTemperature();
        }

        public void DecreaseTemp()
        {
            _ac.DecreaseTemperature();
        }

        public void SetCoolingMode()
        {
            _ac.SetMode("Cooling");
        }
    }
}
