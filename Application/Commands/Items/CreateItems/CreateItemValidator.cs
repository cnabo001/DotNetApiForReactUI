using Application.Validation;
using Contracts.Request;

namespace Application.Commands.Items.CreateItems;
public class CreateItemValidator : ValidatorBase<GetItemRequest>
{
    public CreateItemValidator()
    {
        For(x => x.Title, nameof(GetItemRequest.Title))
            .NotEmpty("Title")
            .MaxLength(50);

        For(x => x.Description, nameof(GetItemRequest.Description))
            .NotEmpty("Description")
            .MaxLength(200);

        For(x => x.Price, nameof(GetItemRequest.Price))
            .NotEmpty("Price")
            .CurrencyType("Price");
    }
}
