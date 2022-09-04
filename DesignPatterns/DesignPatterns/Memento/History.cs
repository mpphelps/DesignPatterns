using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class History
    {
        private List<EditorState> _editorStates = new List<EditorState>();
        public void Push(EditorState state)
        {
            _editorStates.Add(state);
        }
        public EditorState Pop()
        {
            var lastState = _editorStates[_editorStates.Count-1];
            _editorStates.Remove(lastState);
            return lastState;
        }
    }
}
