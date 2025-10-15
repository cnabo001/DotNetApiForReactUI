using Application.Validation;
using Contracts.Request;

namespace Application.Commands.Items.UpdateItems;

public class UpdateItemValidator : ValidatorBase<GetItemRequest>
{
    public UpdateItemValidator()
    {
        For(x => x.Id, nameof(GetItemRequest.Id))
            .NotEmpty("Id");

        For(x => x.Title, nameof(GetItemRequest.Title))
           .NotEmpty("Title")
           .MaxLength(50);

        For(x => x.Description, nameof(GetItemRequest.Description))
            .NotEmpty("Description")
            .MaxLength(200);

        For(x => x.Price, nameof(GetItemRequest.Price))
            .NotEmpty("Price");
    }
}
