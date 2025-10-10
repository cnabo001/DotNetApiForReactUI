using Application.Validation;
using Contracts.Request;

namespace Application.Commands.Items.UpdateItems;

public class UpdateItemValidator : ValidatorBase<GetItemRequest>
{
    public UpdateItemValidator()
    {
        For(x => x.Id, nameof(GetItemRequest.Id))
            .NotEmpty();

        For(x => x.Title, nameof(GetItemRequest.Title))
           .NotEmpty()
           .MaxLength(50);

        For(x => x.Description, nameof(GetItemRequest.Description))
            .NotEmpty()
            .MaxLength(200);

        For(x => x.Price, nameof(GetItemRequest.Price))
            .NotEmpty();
    }
}
