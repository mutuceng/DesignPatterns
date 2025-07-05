using Mediator.Colleague;
using Mediator.ConcreteColleagues;
using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteMediators
{
    public class FontDialogDirector: DialogDirector
    {
        private Listbox list;
        private EntryField field;
        private PreviewWidget preview;
        private Dictionary<string, (string[] weights, string[] slants, int[] sizes)> fontOptions;
        private string currentWeight = "medium";
        private string currentSlant = "roman";
        private int currentSize = 12;


        public FontDialogDirector()
        {
            list = new Listbox();
            field = new EntryField();
            preview = new PreviewWidget();

            list.Director = this;
            field.Director = this;
            preview.Director = this;

            fontOptions = new Dictionary<string, (string[] weights, string[] slants, int[] sizes)>
        {
            { "new century schoolbook", (new[] { "medium", "bold", "demibold" }, new[] { "roman", "italic", "oblique" }, new[] { 10, 12, 14, 18 }) },
            { "avant garde", (new[] { "medium", "bold" }, new[] { "roman", "oblique" }, new[] { 8, 10, 12, 16 }) },
            { "courier", (new[] { "medium", "bold" }, new[] { "roman" }, new[] { 10, 12, 14 }) },
            { "helvetica", (new[] { "medium", "bold", "demibold" }, new[] { "roman", "italic" }, new[] { 9, 11, 13, 15 }) },
            { "palatino", (new[] { "medium", "bold" }, new[] { "roman", "italic" }, new[] { 10, 12, 14 }) },
            { "times roman", (new[] { "medium", "bold" }, new[] { "roman", "italic" }, new[] { 10, 12, 14 }) },
            { "zapf dingbats", (new[] { "medium" }, new[] { "roman" }, new[] { 12, 14, 16 }) }
        };

            CreateWidgets();
        }

        public void ShowDialog()
        {
            Console.WriteLine("\nShow Dialog Called");
            Console.WriteLine("Font Dialog displayed.");
            UpdateOptions(list.GetSelection()); // Başlangıçta varsayılan seçenekleri güncelle
            UpdatePreview();
        }

        public void WidgetChanged(Widget widget)
        {
            if (widget == list)
            {
                string selectedFont = list.GetSelection();
                field.SetText(selectedFont); // Seçilen fontu EntryField’a yaz
                UpdateOptions(selectedFont); // Seçenekleri güncelle
                UpdatePreview(); // Preview’u güncelle
                Console.WriteLine($"Font changed to: {selectedFont}. Updated EntryField, options, and preview.");
            }
            else if (widget == field)
            {
                Console.WriteLine($"EntryField text changed to: {field.GetText()}");
                // Gerekirse ek mantık eklenebilir
            }
            else if (widget == preview)
            {
                Console.WriteLine($"Preview updated.");
            }
        }

        public void SelectFont(string fontName)
        {
            if (!fontOptions.ContainsKey(fontName))
            {
                Console.WriteLine($"Font '{fontName}' not found in options.");
                return;
            }
            Console.WriteLine($"\nSelecting font: {fontName}");
            list.SetSelection(fontName); // Private list'e erişim için public metot
        }

        private void UpdateOptions(string selectedFont)
        {
            if (fontOptions.ContainsKey(selectedFont))
            {
                var (weights, slants, sizes) = fontOptions[selectedFont];
                currentWeight = weights[0]; // Varsayılan weight
                currentSlant = slants[0];  // Varsayılan slant
                currentSize = sizes[0];    // Varsayılan size
                Console.WriteLine($"Available Weights: {string.Join(", ", weights)}");
                Console.WriteLine($"Available Slants: {string.Join(", ", slants)}");
                Console.WriteLine($"Available Sizes: {string.Join(", ", sizes)}");
            }
            else
            {
                Console.WriteLine("Font not found in options.");
            }
        }

        private void UpdatePreview()
        {
            string selectedFont = field.GetText();
            if (fontOptions.ContainsKey(selectedFont))
            {
                preview.UpdatePreview(selectedFont, currentWeight, currentSlant, currentSize);
            }
        }

        private void CreateWidgets()
        {
            Console.WriteLine("\nCreating widgets constructor called");
            list.SetSelection("new century schoolbook"); // Başlangıç fontu
        }
    }
}
