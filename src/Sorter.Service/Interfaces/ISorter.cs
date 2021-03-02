using Sorter.Service.Contracts;
using System.Collections.Generic;

namespace Sorter.Service.Interfaces
{
    public interface ISorter
    {
        IEnumerable<SortResult> Sort(SortOptions sortOptions);
    }
}
