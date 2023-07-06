using FluentValidation;

namespace DataFileAnalizer;

public class DataFileAnalizerValidator : AbstractValidator<DataAnalizer>
{
    public DataFileAnalizerValidator()
    {
        ClassLevelCascadeMode = CascadeMode.Stop;

        RuleFor(x => x.path)
            .Must(File.Exists)
            .WithMessage("The file does not exist");

        RuleForEach(x => x.stringArray)
            .Must(x => int.TryParse(x, out _))
            .WithMessage("All data must be integer numbers");

        RuleFor(x => x.stringArray)
            .NotEmpty()
            .WithMessage("File is empty");
    }
}
