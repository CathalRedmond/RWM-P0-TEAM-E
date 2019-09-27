using System.Collections.Generic;
using System.Linq;
public class CombinedFilter
{

    public static List<int> combinedFilter(List<int> inputNumbers)
    {
        return RunningTotalFilter.runningTotal(Modulo3.modulo3(XOR21Filter.XOR21s(inputNumbers.ToArray())).ToList<int>());
    }

}