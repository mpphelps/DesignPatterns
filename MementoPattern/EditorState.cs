namespace MementoPattern;

public class EditorState
{
    public EditorState(string content, string fontName, int fontSize)
    {
        Content = content;
        FontName = fontName;
        FontSize = fontSize;
    }

    public string Content { get; }
    public string FontName { get; }
    public int FontSize { get; }
}