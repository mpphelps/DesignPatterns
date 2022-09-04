using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Document
    {
        private string _content;
        private string _fontName;
        private int _fontSize;

        public DocumentMemento createMemento()
        {
            return new DocumentMemento(_content, _fontName, _fontSize);
        }

        public void restore(DocumentMemento memento)
        {
            _content = memento.GetContent();
            _fontName = memento.GetFontName();
            _fontSize = memento.GetFontSize();
        }

        private string GetContent()
        {
            return _content;
        }
        public void SetContent(string content)
        {
            _content = content;
        }
        public String getFontName()
        {
            return _fontName;
        }

        public void setFontName(String fontName)
        {
            _fontName = fontName;
        }

        public int getFontSize()
        {
            return _fontSize;
        }

        public void setFontSize(int fontSize)
        {
            _fontSize = fontSize;
        }

        public String ToString()
        {
            return "Document{" +
                    "content='" + _content + '\'' +
                    ", fontName='" + _fontName + '\'' +
                    ", fontSize=" + _fontSize +
                    '}';
        }

    }
}
