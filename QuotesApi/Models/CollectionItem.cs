namespace QuotesApi.Models;

public class CollectionItem
{
    private CollectionItem() { } // EF Core

    public CollectionItem(int quoteId)
    {
        QuoteId = quoteId;
        AddedAt = DateTime.UtcNow;
    }

    public int QuoteId { get; private set; }
    public DateTime AddedAt { get; private set; }
}
