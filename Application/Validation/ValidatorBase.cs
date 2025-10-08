namespace Application.Validation;

public abstract class ValidatorBase<T>
{
    private readonly List<Func<T, ValidationResult>> _rules = new();

    public void Rule(Func<T, bool> predicate, string errorMessage)
    {
        _rules.Add(obj =>
        {
            var result = new ValidationResult();
            if (!predicate(obj))
                result.AddError(errorMessage);
            return result;
        });
    }

    protected RuleBuilder<T> For<TProperty>(Func<T, TProperty> propertyFunc, string propertyName)
    {
        return new RuleBuilder<T>(this, x => propertyFunc(x),  propertyName);
    }

    public ValidationResult Validate(T instance)
    {
        var result = new ValidationResult();

        foreach(var rule in _rules)
        {
            var ruleResult = rule(instance);
            result.Errors.AddRange(ruleResult.Errors);
        }
        return result;
    }
}
