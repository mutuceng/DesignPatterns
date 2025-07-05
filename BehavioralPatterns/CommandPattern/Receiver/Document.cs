using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class Document
    {
        private string content = "";
        private string copiedContent = "";

        public void addText(string text)
        {
            content += text;
            Console.WriteLine($"Added text: {text}" + " New Content: " + content);
        }

        public void cutText(int startIndex, int length)
        {
            if (startIndex < 0 || startIndex + length > content.Length)
            {
                Console.WriteLine("Invalid cut operation.");
                return;
            }
            copiedContent = content.Substring(startIndex, length);
            content = content.Remove(startIndex, length);
            Console.WriteLine($"Cut text: {copiedContent}" + " New Content: " + content);
        }

        public void pasteText(int index)
        {
            if (index < 0 || index > content.Length)
            {
                Console.WriteLine("Invalid paste operation.");
                return;
            }
            content = content.Insert(index, copiedContent);
            Console.WriteLine($"Pasted text: {copiedContent}" + " New Content: " + content);
        }

        public void copyText(int startIndex, int length)
        {
            if (startIndex < 0 || startIndex + length > content.Length)
            {
                Console.WriteLine("Invalid copy operation.");
                return;
            }
            copiedContent = content.Substring(startIndex, length);
            Console.WriteLine($"Copied text: {copiedContent}");
        }

        public void showContent()
        {
            Console.WriteLine("Current Document Content: " + content);
        }

        public string getText()
        {
            return content;
        }   
    }
}
