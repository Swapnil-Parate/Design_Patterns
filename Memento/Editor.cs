using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
   public class Editor
    {
        public string content { get; set; }
        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState state)
        {
            content = state._content;
        }



    }
}
