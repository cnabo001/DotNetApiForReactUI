using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.Items.DeleteItems;

public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand, Unit>
{
    private readonly StoreItemsContext _context;

    public DeleteItemCommandHandler(StoreItemsContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteItemCommand command, CancellationToken token)
    {
        var item = await _context.Item.FirstOrDefaultAsync(x => x.Id == command.Id);

        if (item == null) { throw new Exception(); }

        //TODO: Add Auth config then add Hard Delete:  _context.Item.Remove(item);
        //Soft Delete
        item.DeletedBy = "guest_client";//TODO: add auth for currentUser fetch
        item.DeletedDate = DateTime.UtcNow;
        item.IsActive = false;
        await _context.SaveChangesAsync(token);

        return Unit.Value;
    }
}
