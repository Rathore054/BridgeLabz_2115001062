using System;

class TextState
{
    public string Content;
    public TextState Next;
    public TextState Prev;

    public TextState(string content)
    {
        Content = content;
        Next = null;
        Prev = null;
    }
}

class TextEditor
{
    private TextState current;

    public void AddState(string content)
    {
        TextState newState = new TextState(content);
        if (current != null)
        {
            newState.Prev = current;
            current.Next = newState;
        }
        current = newState;
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No previous state.");
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No next state.");
        }
    }

    public void DisplayCurrentState()
    {
        Console.WriteLine("Current State: " + (current != null ? current.Content : "Empty"));
    }

    static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        editor.DisplayCurrentState();
        editor.Undo();
        editor.Undo();
        editor.Redo();
    }
}
