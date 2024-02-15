using Evaluation.Objects;

namespace Evaluation.Collections;

public class SortedDictionaryTest
{
    private readonly SortedDictionary<int, Product> productSortedDictionary =
        new SortedDictionary<int, Product>();

    public SortedDictionaryTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productSortedDictionary.Add(id, Product.GenerateRandomProduct(id));
        }
    }
}