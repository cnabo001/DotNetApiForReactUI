using Contracts.Responses;
using MediatR;

namespace Application.Queries.Items.GetItemById;
public record GetItemByIdQuery(Guid Id) : IRequest<GetItemResponse>;
