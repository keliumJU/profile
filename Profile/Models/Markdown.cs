using Westwind.Web.Markdown.MarkdownParser;

public static class Markdown {
    public static string Parse(string markdown, bool usePragmaLines = false, bool forceReload = false)
    {
        if (string.IsNullOrEmpty(markdown))
            return "";

        var parser = MarkdownParserFactory.GetParser(usePragmaLines, forceReload);
        return parser.Parse(markdown);
    }
}
