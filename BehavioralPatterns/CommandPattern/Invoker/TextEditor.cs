using CommandPattern.CommandInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Invoker
{
    public class TextEditor
    {
        private List<ICommand> _commands = new List<ICommand>();
        private Stack<ICommand> _undoStack = new Stack<ICommand>();
    
        public void addCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void executeCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
                _undoStack.Push(command);
            }
            _commands.Clear();
        }

        public void undoLastCommand()
        {
            if (_undoStack.Count > 0)
            {
                ICommand lastCommand = _undoStack.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }
}
