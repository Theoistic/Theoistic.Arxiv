using System.Net;
using System.Xml.Linq;

namespace Theoistic.Arxiv;

public static class ArxivParser
{

    private static readonly string Base = "http://export.arxiv.org/api/query?search_query=";

    /// <summary>
    /// Fetches feed on a specific query from arXiv.
    /// - Set order to None to work with pagination.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="order">Sorting order of the results. Set to None for pagination.</param>
    /// <param name="page">Page number for pagination.</param>
    /// <param name="resultsPerPage">Number of results per page.</param>
    /// <returns>A Feed object with search results or null if an error occurs.</returns>
    public static Feed? Search(string query, ArxivOrder order = ArxivOrder.Descending, int page = 0, int resultsPerPage = 10)
    {
        try
        {
            WebClient webClient = new WebClient();
            string paging = order == ArxivOrder.None ? $"&start={page}&max_results={resultsPerPage}" : "";
            string sorting = order != ArxivOrder.None ? $"&sortBy=lastUpdatedDate&sortOrder={order.ToString().ToLower()}" : "";
            string url = ($"{Base}all:\"{query}\"{paging}{sorting}");
            string atomFeed = webClient.DownloadString(url);
            Feed feed = Parse(atomFeed);
            return feed;
        } catch {
            // if something goes wrong we just default.. [BADPRACTICE]
            return null;
        }
    }

    /// <summary>
    /// Fetches feeds based on a specific category from arXiv.
    /// </summary>
    /// <param name="category">The category to search within.</param>
    /// <param name="order">Sorting order of the results. Set to None for pagination.</param>
    /// <param name="page">Page number for pagination.</param>
    /// <param name="resultsPerPage">Number of results per page.</param>
    /// <returns>A Feed object with search results or null if an error occurs.</returns>
    public static Feed? Category(string category, ArxivOrder order = ArxivOrder.Descending, int page = 0, int resultsPerPage = 10)
    {
        try
        {
            WebClient webClient = new WebClient();
            string paging = order == ArxivOrder.None ? $"&start={page}&max_results={resultsPerPage}" : "";
            string sorting = order != ArxivOrder.None ? $"&sortBy=lastUpdatedDate&sortOrder={order.ToString().ToLower()}" : "";
            string url = $"{Base}cat:{Uri.EscapeDataString(category)}{paging}{sorting}";
            string atomFeed = webClient.DownloadString(url);
            Feed feed = Parse(atomFeed);
            return feed;
        }
        catch
        {
            // Handle exceptions appropriately
            return null;
        }
    }

    /// <summary>
    /// Fetches feeds based on a specific category from arXiv. (use the string implementation for up to date categories)
    /// </summary>
    /// <param name="category">The category to search within.</param>
    /// <param name="order">Sorting order of the results. Set to None for pagination.</param>
    /// <param name="page">Page number for pagination.</param>
    /// <param name="resultsPerPage">Number of results per page.</param>
    /// <returns>A Feed object with search results or null if an error occurs.</returns>
    public static Feed? Category(ArxivCategory category, ArxivOrder order = ArxivOrder.Descending, int page = 0, int resultsPerPage = 10)
        => Category(ArxivUtils.GetCategoryDescription(category), order, page, resultsPerPage);

    private static Feed Parse(string xml)
    {
        XDocument doc = XDocument.Parse(xml);
        XNamespace ns = "http://www.w3.org/2005/Atom";
        XNamespace opensearch = "http://a9.com/-/spec/opensearch/1.1/";
        XNamespace arxiv = "http://arxiv.org/schemas/atom";

        var feed = new Feed
        {
            Link = doc.Root.Element(ns + "link")?.Attribute("href")?.Value,
            Title = doc.Root.Element(ns + "title")?.Value,
            Id = doc.Root.Element(ns + "id")?.Value,
            Updated = DateTime.Parse(doc.Root.Element(ns + "updated")?.Value),
            TotalResults = int.Parse(doc.Root.Elements(opensearch + "totalResults").First().Value),
            StartIndex = int.Parse(doc.Root.Elements(opensearch + "startIndex").First().Value),
            ItemsPerPage = int.Parse(doc.Root.Elements(opensearch + "itemsPerPage").First().Value),
            Entries = doc.Root.Elements(ns + "entry").Select(entry => new Entry
            {
                Id = entry.Element(ns + "id")?.Value,
                Updated = DateTime.Parse(entry.Element(ns + "updated")?.Value),
                Published = DateTime.Parse(entry.Element(ns + "published")?.Value),
                Title = entry.Element(ns + "title")?.Value,
                Summary = entry.Element(ns + "summary")?.Value,
                Authors = entry.Elements(ns + "author").Select(author => new Author
                {
                    Name = author.Element(ns + "name")?.Value,
                    Affiliation = author.Element(arxiv + "affiliation")?.Value
                }),
                DOI = entry.Element(arxiv + "doi")?.Value,
                Links = entry.Elements(ns + "link").Select(link => new Link
                {
                    Src = link.Attribute("href")?.Value,
                    Type = link.Attribute("type")?.Value
                }),
                Comment = entry.Element(arxiv + "comment")?.Value,
                JournalRef = entry.Element(arxiv + "journal_ref")?.Value,
                PrimaryCategory = entry.Element(arxiv + "primary_category")?.Attribute("term")?.Value,
                Category = entry.Elements(ns + "category").Select(cat => cat.Attribute("term")?.Value)
            })
        };

        return feed;
    }
}
