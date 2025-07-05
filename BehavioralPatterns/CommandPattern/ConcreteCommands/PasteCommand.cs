using CommandPattern.CommandInterface;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommands
{
    public class PasteCommand : ICommand
    {
        private Document _document;
        private int position;
        private string previousText;
        public PasteCommand(Document document, int position)
        {
            _document = document;
            this.position = position;
        }
        public void Execute()
        {
            previousText = _document.getText();
            _document.pasteText(position);
        }
        public void Undo()
        {
            if(previousText != null)
            {
                _document.cutText(position, _document.getText().Length - previousText.Length);
                Console.WriteLine($"Undo Paste Command: Restored previous text at position {position}.\n");
            }
            else
            {
                Console.WriteLine("No previous text to restore.");
            }
        }
    }
}
