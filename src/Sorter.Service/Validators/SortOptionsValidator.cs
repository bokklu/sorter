using FluentValidation;
using Sorter.Service.Contracts;

namespace Sorter.Service.Validators
{
    public class SortOptionsValidator : AbstractValidator<SortOptions>
    {
        public SortOptionsValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(opts => opts.SortingAlgorithms).NotEmpty();
            RuleFor(opts => opts.Numbers).NotEmpty();
        }
    }
}
