using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Colleague;

namespace Mediator.ConcreteColleagues
{
    public class Listbox:Widget
    {
        private string selection;

        public string GetSelection()
        {
            return selection ?? "Default";
        }

        public void SetSelection(string selection)
        {
            this.selection = selection;
            Changed();
        }

        public override void Changed()
        {
            if (director != null)
            {
                director.WidgetChanged(this);
            }
        }
    }
}
