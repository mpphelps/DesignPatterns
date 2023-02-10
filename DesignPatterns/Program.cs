using System.ComponentModel;
using MementoPattern;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MementoPatternDemo();
        }

        public static void MementoPatternDemo()
        {
            var editor = new Editor("My Document");
            var history = new History();
            editor.FontName = "Times New Roman";
            editor.FontSize = 12;
            editor.Content = "a";
            editor.PrintContent();
            history.Push(editor.CreateState());
            editor.Content = "b";
            history.Push(editor.CreateState());
            editor.Content = "c";
            history.Push(editor.CreateState());
            editor.Content = "d";
            editor.Restore(history.Pop());
            editor.PrintContent();
        }
    }
}