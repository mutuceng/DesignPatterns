using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    public interface DialogDirector
    {
        public void ShowDialog();
        public void WidgetChanged(Widget widget);
    }
}
