using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteColleagues
{
    public class PreviewWidget: Widget
    {
        private string previewText = "The quick brown fox...";

        public string GetPreviewText()
        {
            return previewText;
        }

        public void UpdatePreview(string fontFamily, string weight, string slant, int size)
        {
            previewText = $"[{weight} {slant} {size}pt] {fontFamily}: {previewText}";
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
