using Contracts.Responses;
using MediatR;

namespace Application.Queries.Items.GetItemById;
public record GetItemByIdQuery(int Id) : IRequest<GetItemResponse>;
