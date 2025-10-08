using Contracts.Responses;
using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries.Items.GetItems;
public class GetItemsRequestQueryHandler: IRequestHandler<GetItemsQuery, GetAllItemsResponse>
{
    private readonly StoreItemsContext _context;
    public GetItemsRequestQueryHandler(StoreItemsContext context)
    {
        _context = context;
    }
    public async Task<GetAllItemsResponse> Handle(GetItemsQuery request, CancellationToken token)
    {
        var items = await _context.Item.ToListAsync(token);

        var response = new GetAllItemsResponse();

        foreach (var item in items)
        {
            response.Items.Add(new GetItemResponse
            {
                Id = item.Id, 
                Title = item.Title,
                Description = item.Description,
                Price = item.Price,
                IsActive = item.IsActive,
                CreateDate = item.CreateDate,
                UpdateDate = item.UpdateDate,
                DeletedBy = item.DeletedBy,
                DeletedDate = item.DeletedDate
            });
        }
        return response;
    }
}
    
