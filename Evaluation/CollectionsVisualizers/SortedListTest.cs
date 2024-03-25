using Evaluation.Objects;

namespace Evaluation.Collections;

public class SortedListTest
{
    readonly SortedList<int, Product> productSortedList = new SortedList<int, Product>();

    public SortedListTest()
    {
        for (int i = 0; i < 105; i++)
        {
            int id = i + 1;
            productSortedList.Add(id, Product.GenerateRandomProduct(id));
        }

    }
}