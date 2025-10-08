using MediatR;

namespace Application.Commands.Items.CreateItems;

public record CreateItemCommand(string Title, string Description, int Price) : IRequest<int>;



