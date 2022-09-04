using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentHistory
    {
        private Stack<DocumentMemento> _mementos = new Stack<DocumentMemento>();

        public void Push(DocumentMemento memento)
        {
            _mementos.Push(memento);
        }
        public DocumentMemento Pop()
        {
            return _mementos.Pop();
        }
    }
}
