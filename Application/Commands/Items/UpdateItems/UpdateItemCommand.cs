using MediatR;

namespace Application.Commands.Items.UpdateItems;
public record UpdateItemCommand(Guid Id, string Title, string Description, decimal Price, bool IsActive): IRequest<Unit>;

