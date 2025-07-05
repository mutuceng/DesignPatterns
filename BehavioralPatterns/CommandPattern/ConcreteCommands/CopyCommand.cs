using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.CommandInterface;
using Document = CommandPattern.Receiver.Document;
using ICommand = CommandPattern.CommandInterface.ICommand;

namespace CommandPattern.ConcreteCommands
{
    public class CopyCommand : ICommand
    {
        private Document _document;
        private int baslangic;
        private int uzunluk;

        public CopyCommand(Document document, int baslangic, int uzunluk)
        {
            _document = document;
            this.baslangic = baslangic;
            this.uzunluk = uzunluk;
        }

        public void Execute()
        {
           _document.copyText(baslangic, uzunluk);
            Console.WriteLine($"Copy Command Executed: Copied text from position {baslangic} with length {uzunluk}.\n");
        }

        public void Undo()
        {
            Console.WriteLine("Undo operation for Copy Command is not applicable.");
        }

    }
}
