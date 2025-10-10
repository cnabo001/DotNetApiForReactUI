using MediatR;

namespace Application.Commands.Items.DeleteItems;

public record DeleteItemCommand(int Id) : IRequest<Unit>;
