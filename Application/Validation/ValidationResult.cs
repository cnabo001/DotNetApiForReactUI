using System.ComponentModel;

namespace Application.Validation;

public class ValidationResult
{
    public bool IsValid => !Errors.Any();
    public List<string> Errors { get; } = new();

    public void AddError(string message)
    {
        Errors.Add(message);
    }
}
