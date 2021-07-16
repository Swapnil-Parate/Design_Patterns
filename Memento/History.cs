using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class History
    {
        List<EditorState> states = new List<EditorState>();
        public void Push(EditorState state)
        {
            states.Add(state);
        }
        public EditorState Pop()
        {
            var lastIndex = states.Count - 1;
            var LastState = states[lastIndex];
            states.Remove(LastState);
            return LastState;
        }
    }
}
