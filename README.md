
# Theoistic.Arxiv
A .NET library for querying and parsing data from the arXiv API. This library allows users to easily fetch academic papers' information from arXiv based on queries, categories, and other filters.

## Features
- Query arXiv for papers based on a search query.
- Fetch papers by specific arXiv categories.
- Supports pagination for large result sets.
- Customizable sorting order.
- Parse returned data into well-defined .NET objects.

## Getting Started
To use `Theoistic.Arxiv` in your project, first install the package via NuGet:

```shell
Install-Package Theoistic.Arxiv
```

## Usage
Here's how you can use the library in your project:

### Searching by Query
```csharp
using Theoistic.Arxiv;

var results = ArxivParser.Search("quantum computing", ArxivOrder.Descending, page: 1, resultsPerPage: 10);
if (results != null)
{
    foreach (var entry in results.Entries)
    {
        Console.WriteLine($"{entry.Title} by {string.Join(", ", entry.Authors.Select(a => a.Name))}");
    }
}
```

### Fetching by Category
```csharp
using Theoistic.Arxiv;

var categoryResults = ArxivParser.Category("cs.AI", ArxivOrder.Ascending, page: 0, resultsPerPage: 5);
if (categoryResults != null)
{
    foreach (var entry in categoryResults.Entries)
    {
        Console.WriteLine($"{entry.Title} - {entry.Summary}");
    }
}
```

## Contributing
Contributions are welcome! Please feel free to submit a pull request.

## License
This library is licensed under the [MIT License](LICENSE).

## Acknowledgements
This library was created to facilitate access to the vast amount of academic literature available on arXiv.

## Disclaimer
This project is not affiliated with arXiv or Cornell University.
