using MediatR;

namespace Application.Commands.Items.UpdateItems;
public record UpdateItemCommand(int Id, string Title, string Description, int Price, bool IsActive): IRequest<Unit>;

