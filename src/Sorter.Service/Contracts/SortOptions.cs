using CommandLine;
using System.Collections.Generic;

namespace Sorter.Service.Contracts
{
    [Verb("sort", HelpText = "Sort using the selected algorithm/s")]
    public sealed class SortOptions
    {
        [Option('a', "algorithm", Separator = ',', Required = true, HelpText = "Sorting Algorithm/s")]
        public IEnumerable<Algorithm> SortingAlgorithms { get; set; }

        [Option('n', "numbers", Separator = ',', Required = true, HelpText = "Input Numbers")]
        public IEnumerable<int> Numbers { get; set; }
    }
}
