namespace Theoistic.Arxiv;

public class Entry
{
    public string Id { get; set; }
    public DateTime Updated { get; set; }
    public DateTime Published { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public IEnumerable<Author> Authors { get; set; }
    public string DOI { get; set; }
    public IEnumerable<Link> Links { get; set; }
    public string Comment { get; set; }
    public string JournalRef { get; set; }
    public string PrimaryCategory { get; set; }
    public IEnumerable<string> Category { get; set; }
}
