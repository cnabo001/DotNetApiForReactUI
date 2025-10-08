using Contracts.Responses;
using MediatR;

namespace Application.Queries.Items.GetItems;
public sealed record GetItemsQuery(): IRequest<GetAllItemsResponse>;


