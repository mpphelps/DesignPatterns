using DesignPatterns.Memento;
using System;

namespace DesignPatterns
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var editor = new Editor();
            var history  = new History();
            editor.SetContent("a");
            history.Push(editor.CreateState());

            editor.SetContent("b");
            history.Push(editor.CreateState());

            editor.SetContent("c");
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.GetContent());

            var document = new Document();
            var documentHistory = new DocumentHistory();
            document.SetContent("a");
            document.setFontName("Times New Roman");
            document.setFontSize(12);
            documentHistory.Push(document.createMemento());

            document.setFontSize(10);
            documentHistory.Push(document.createMemento());

            document.SetContent("Hello World");
            documentHistory.Push(document.createMemento());

            Console.WriteLine(document.ToString());
            document.restore(documentHistory.Pop());

            Console.WriteLine(document.ToString());
            document.restore(documentHistory.Pop());

            Console.WriteLine(document.ToString());


        }
    }
}
