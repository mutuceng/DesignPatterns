using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleague
{
    public abstract class Widget
    {
        protected DialogDirector director;

        public DialogDirector Director
        {
            set { director = value; }
        }

        public abstract void Changed();
    }
}
