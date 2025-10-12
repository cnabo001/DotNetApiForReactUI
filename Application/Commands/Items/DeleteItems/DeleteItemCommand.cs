using MediatR;

namespace Application.Commands.Items.DeleteItems;

public record DeleteItemCommand(Guid Id) : IRequest<Unit>;
