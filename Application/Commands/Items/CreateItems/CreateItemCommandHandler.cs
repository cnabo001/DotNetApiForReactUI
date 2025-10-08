using Domain.Entities;
using Infrastructure;
using MediatR;

namespace Application.Commands.Items.CreateItems;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
{
    private readonly StoreItemsContext _context;
    public CreateItemCommandHandler(StoreItemsContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateItemCommand command, CancellationToken token)
    {

        var item = new Item
        {
            Id = 1,
            Title = command.Title,
            Description = command.Description,
            Price = command.Price,
            IsActive = true,
            CreateDate = DateTime.UtcNow,
            UpdateDate = DateTime.UtcNow
        };

        await _context.Item.AddAsync(item, token);
        await _context.SaveChangesAsync(token);

        return item.Id;
    }
}
