using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public  class DocumentMemento
    {
        private readonly string _content;
        private readonly string _fontName;
        private readonly int _fontSize;

        public DocumentMemento(string content, string fontName, int fontSize)
        {
            _content = content;
            _fontName = fontName;
            _fontSize = fontSize;
        }

        public string GetContent()
        {
            return _content;
        }
        public string GetFontName()
        {
            return _fontName;
        }
        public int GetFontSize()
        {
            return _fontSize;
        }
    }
}
