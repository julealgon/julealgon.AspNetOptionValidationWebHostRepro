namespace julealgon.AspNetOptionValidationWebHostRepro;

using Microsoft.Extensions.Options;

public sealed class MyOptionsValidator : IValidateOptions<MyOptions>
{
    ValidateOptionsResult IValidateOptions<MyOptions>.Validate(string name, MyOptions options)
    {
        return ValidateOptionsResult.Fail("Some failure");
    }
}
