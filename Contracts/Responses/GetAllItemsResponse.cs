namespace Contracts.Responses;

public sealed class GetAllItemsResponse
{
    public List<GetItemResponse> Items { get; set; } = new();
}

public sealed class GetItemResponse
{
    public int Id { get; set; }         
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public string? DeletedBy { get; set; } = "";
    public DateTime? DeletedDate { get; set; }
}
