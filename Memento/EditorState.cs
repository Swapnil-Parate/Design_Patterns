using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class EditorState
    {
        public readonly string _content;
        public EditorState(string content)
        {
            this._content = content;
        }

    }
}
