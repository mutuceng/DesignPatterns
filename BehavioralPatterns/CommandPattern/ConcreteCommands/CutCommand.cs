using CommandPattern.CommandInterface;
using CommandPattern.Receiver;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommands
{
    public class CutCommand : ICommand
    {
        protected Document _document;
        private int startIndex;
        private int length;
        private string cuttedText;

        public CutCommand(Document document, int startIndex, int length)
        {
            _document = document;
            this.startIndex = startIndex;
            this.length = length;
        }

        public void Execute()
        {
            if (startIndex < 0 || startIndex + length > _document.getText().Length)
            {
                throw new ArgumentOutOfRangeException("Invalid startIndex or length for Substring operation.\n");
            }
            cuttedText = _document.getText().Substring(startIndex, length);
            _document.cutText(startIndex, length);
        }

        public void Undo()
        {
            if (cuttedText != null)
            {
                _document.pasteText(startIndex);
                Console.WriteLine($"Undo Cut Command: Restored cut text at position {startIndex}.\n");
            }
            else
            {
                Console.WriteLine("No text to restore from cut operation.");
            }
        }
    }
}
