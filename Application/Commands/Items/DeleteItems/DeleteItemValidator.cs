using Application.Validation;

namespace Application.Commands.Items.DeleteItems;

public class DeleteItemValidator: ValidatorBase<Guid>
{
    public DeleteItemValidator()
    {
        For(x => x, nameof(DeleteItemValidator))
            .NotEmpty("Id cannot be empty");
    }
}
