using Domain.Entities;
using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.Items.CreateItems;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, Guid>
{
    private readonly StoreItemsContext _context;
    public CreateItemCommandHandler(StoreItemsContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreateItemCommand command, CancellationToken token)
    {

        var items = await _context.Item.ToListAsync(token);

        var item = new Item
        {
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
