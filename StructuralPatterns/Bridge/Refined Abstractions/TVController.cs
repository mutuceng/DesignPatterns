using Bridge.Abstraction;
using Bridge.Concrete___Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Refined_Abstractions
{
    public class TVController: RemoteControl
    {
        private readonly Television _tv;

        public TVController(Television tv):base(tv)
        {
            _tv = tv;
        }

        public void ChangeChannel(int channel)
        {
            _tv.SetChannel(channel);
        }

        public void Mute()
        {
            _tv.Mute();
        }
    }
}
