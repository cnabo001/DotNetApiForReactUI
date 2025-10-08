using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Commands.Items.UpdateItems;

public class UpdateItemCommandHandler: IRequestHandler<UpdateItemCommand, Unit>
{
    private StoreItemsContext _context;

    public UpdateItemCommandHandler(StoreItemsContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateItemCommand command, CancellationToken token)
    {
        var itemUpdate = await _context.Item.FirstOrDefaultAsync(x => x.Id == command.Id);

        if (itemUpdate is not null) 
        {
            itemUpdate.Title = command.Title;
            itemUpdate.Description = command.Description;
            itemUpdate.Price = command.Price;
            itemUpdate.IsActive = command.IsActive;
            itemUpdate.UpdateDate = DateTime.UtcNow;

            await _context.SaveChangesAsync(token);
            return Unit.Value;
        }

        throw new Exception();
    }
}
