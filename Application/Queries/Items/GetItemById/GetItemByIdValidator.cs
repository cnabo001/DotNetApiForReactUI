using Application.Validation;
using Contracts.Request;

namespace Application.Queries.Items.GetItemById;

public class GetItemByIdValidator : ValidatorBase<Guid>
{
    public GetItemByIdValidator()
    {
        For(x => x, nameof(GetItemRequest.Id))
            .NotEmpty("Item Id");

    }
}
