namespace Profile.Models;

public class Post
{
    public String? Title { get; set; }
    public String? Description { get; set; }
    public String? Author { get; set; }
    public String? Date { get; set; }
    public String? Slug { get; set; }

    public String? Content { get; set; }

    public String GetUrl()
    {
        return $"/dsa/{Slug}";
    }

    public String GetFormattedDate()
    {
        return GetDateWithType().ToString("MMMM, dd, yyy");
    }

    public DateTime GetDateWithType()
    {
        return DateTime.Parse(Date);
    }
}

