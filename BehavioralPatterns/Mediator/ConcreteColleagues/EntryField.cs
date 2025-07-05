using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteColleagues
{
    public class EntryField: Widget
    {
        private string text;

        public string GetText()
        {
            return text ?? string.Empty;
        }

        public void SetText(string text)
        {
            this.text = text;
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
