using FluentValidation.TestHelper;
using NUnit.Framework;
using Sorter.Service.Contracts;
using Sorter.Service.Validators;
using System.Collections.Generic;

namespace Sorter.Test.Validators
{
    [TestFixture]
    internal sealed class SortOptionValidatorTests
    {
        private SortOptionsValidator _sortOptionsValidator;

        [SetUp]
        public void SetUp()
        {
            _sortOptionsValidator = new SortOptionsValidator();
        }

        [Test]
        public void ShouldHaveErrorWhenAlgorithmIsEmpty()
        {
            var sortOptions = new SortOptions
            {
                Numbers = new List<int> { 2, 1, 3 }
            };

            var validationResult = _sortOptionsValidator.TestValidate(sortOptions);
            validationResult.ShouldHaveValidationErrorFor(x => x.SortingAlgorithms);
        }

        [Test]
        public void ShouldHaveErrorWhenNumbersAreEmpty()
        {
            var sortOptions = new SortOptions
            {
                SortingAlgorithms = new List<Algorithm> { Algorithm.BubbleSort }
            };

            var validationResult = _sortOptionsValidator.TestValidate(sortOptions);
            validationResult.ShouldHaveValidationErrorFor(x => x.Numbers);
        }

        [Test]
        public void ShouldHaveNoErrorsWhenInputIsCorrect()
        {
            var sortOptions = new SortOptions
            {
                SortingAlgorithms = new List<Algorithm> { Algorithm.BubbleSort },
                Numbers = new List<int> { 2, 1, 3 }
            };

            var validationResult = _sortOptionsValidator.TestValidate(sortOptions);
            validationResult.ShouldNotHaveAnyValidationErrors();
        }
    }
}
