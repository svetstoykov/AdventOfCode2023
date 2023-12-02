using System.Text;
using System.Text.RegularExpressions;
using AdventOfCode2023.Application.Day0;

namespace AdventOfCode2023.Application.Day1;

public class PartTwoPuzzleSolver : PuzzleSolver
{
    public override int Day => 1;

    public override int Part => 2;

    private readonly IDictionary<string, int> _numbersMapping = new Dictionary<string, int>
    {
        {"one", 1},
        {"two", 2},
        {"three", 3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 9}
    };

    public override void Solve()
    {
        var lines = Input.Split("\n");

        var total = 0;

        var numsAsWords = _numbersMapping.Keys.ToArray().AsSpan();

        Span<ValueTuple<int, int>> numsOrder = stackalloc ValueTuple<int, int>[20];

        foreach (var line in lines)
        {
            var numsIndexCollection = 0;

            foreach (var numsAsWord in numsAsWords)
            {
                ResolveAllIndexesForNumber(
                    line,
                    numsAsWord,
                    numsOrder,
                    ref numsIndexCollection);
            }

            var numsAllocated = numsOrder[..numsIndexCollection];

            numsAllocated.Sort((a, b) => a.Item1.CompareTo(b.Item1));

            total += numsAllocated[0].Item2 * 10 + numsAllocated[numsIndexCollection - 1].Item2;

            numsOrder[..numsIndexCollection].Clear();
        }
    }

    private void ResolveAllIndexesForNumber(
        string line,
        string numberAsWord,
        Span<ValueTuple<int, int>> numsIndexCollection,
        ref int numsIndexCollectionIndex)
    {
        var numWordStartIndex = 0;
        var numStartIndex = 0;
        
        while (true)
        {
            var num = _numbersMapping[numberAsWord];

            var indexOfWord = line.IndexOf(
                numberAsWord, numWordStartIndex, StringComparison.Ordinal);

            var indexOfNum = line.IndexOf(
                num.ToString(), numStartIndex, StringComparison.Ordinal);

            if (indexOfWord < 0 && indexOfNum < 0)
            {
                break;
            }
            
            if (indexOfWord >= 0)
            {
                numsIndexCollection[numsIndexCollectionIndex++] = (indexOfWord, num);

                numWordStartIndex = indexOfWord + 1;
            }

            if (indexOfNum >= 0)
            {
                numsIndexCollection[numsIndexCollectionIndex++] = (indexOfNum, num);
                
                numStartIndex = indexOfNum + 1;
            }
        }
    }
}