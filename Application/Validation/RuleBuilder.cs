namespace Application.Validation;

public class RuleBuilder<T>
{
    private readonly ValidatorBase<T> _validator;
    private readonly Func<T, object> _propertyFunc;
    private readonly string _propertyName;

    public RuleBuilder(ValidatorBase<T> validator, Func<T, object> propertyFunc, string propertyName)
    {
        _validator = validator;
        _propertyFunc = propertyFunc;
        _propertyName = propertyName;
    }

    public RuleBuilder<T> NotEmpty(string message = null) 
    {
        _validator.Rule(x => !string.IsNullOrWhiteSpace(_propertyFunc(x)?.ToString()),
            message ?? $"{_propertyName} cannot be empty");
        return this;
    }

    public RuleBuilder<T> MaxLength(int length, string message = null)
    {
        _validator.Rule(x => (_propertyFunc(x).ToString()?.Length ?? 0) <= length,
            message ?? $"{_propertyName} must be less than {length} characters");
        return this;
    }

    public RuleBuilder<T> MinLength(int length, string message = null)
    {
        _validator.Rule(x => (_propertyFunc(x).ToString()?.Length ?? 0) >= length,
            message ?? $"{_propertyName} must be more than {length} characters");
        return this;
    }

    public RuleBuilder<T> CurrencyType(string message = null)
    {
        _validator.Rule(x =>
        {
            var value = _propertyFunc(x)?.ToString();
            if (string.IsNullOrWhiteSpace(value)) return false;
            return decimal.TryParse(value, out var result) && result >= 0;
        }, message ?? $"{_propertyName} must be a valid currency amount");
        return this;
    }
}
