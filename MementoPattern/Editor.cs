namespace MementoPattern;

public class Editor
{
    public string DocumentTitle { get; }
    public string Content { get; set; } = "";
    public string FontName { get; set; } = "";
    public int FontSize { get; set; }
    public Editor(string documentTitle)
    {
        DocumentTitle = documentTitle;
    }
    public EditorState CreateState()
    {
        return new EditorState(Content, FontName, FontSize);
    }

    public void Restore(EditorState state)
    {
        Content = state.Content;
        FontName = state.FontName;
        FontSize = state.FontSize;
    }

    public void PrintContent()
    {
        Console.WriteLine($"Document Title: {DocumentTitle}");
        Console.WriteLine($"Font Name: {FontName}");
        Console.WriteLine($"Font Size: {FontSize}");
        Console.WriteLine(Content);
    }

}