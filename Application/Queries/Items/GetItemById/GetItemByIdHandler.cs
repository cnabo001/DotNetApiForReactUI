using Contracts.Responses;
using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries.Items.GetItemById
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdQuery, GetItemResponse>
    {
        private readonly StoreItemsContext _context;
        public GetItemByIdHandler(StoreItemsContext context)
        {
            _context = context;
        }

        public async Task<GetItemResponse> Handle(GetItemByIdQuery request, CancellationToken token)
        {
            var response = new GetItemResponse();

            var item = await _context.Item.FirstOrDefaultAsync(x => x.Id == request.Id, token);

            if (item == null)
            {
                throw new Exception("There is no record that exist from your request");
            }

            response.Id = item.Id;
            response.Title = item.Title ?? null;
            response.Price = item.Price;
            response.Description = item.Description;
            response.IsActive = item.IsActive;
            response.CreateDate = item.CreateDate;
            response.UpdateDate = item.UpdateDate;
            response.DeletedBy = item.DeletedBy;
            response.DeletedDate = item.DeletedDate;
            
            return response;
        }
    }
}
