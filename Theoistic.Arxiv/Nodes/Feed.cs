namespace Theoistic.Arxiv;

public class Feed
{
    public string Link { get; set; }
    public string Title { get; set; }
    public string Id { get; set; }
    public DateTime Updated { get; set; }
    public int TotalResults { get; set; }
    public int StartIndex { get; set; }
    public int ItemsPerPage { get; set; }
    public IEnumerable<Entry> Entries { get; set; }
}
