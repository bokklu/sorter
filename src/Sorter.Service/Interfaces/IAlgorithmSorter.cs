using Sorter.Service.Contracts;

namespace Sorter.Service.Interfaces
{
    public interface IAlgorithmSorter
    {
        SortResult Sort(int[] numbers);
    }
}
