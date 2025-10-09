using MediatR;

namespace Application.Commands.Items.CreateItems;

public record CreateItemCommand(string Title, string Description, decimal Price) : IRequest<int>;



