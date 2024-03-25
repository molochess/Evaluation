using Evaluation.Objects;

namespace Evaluation.Collections;

public class SortedSetTest
{
    private readonly SortedSet<Product> productSortedSet = new SortedSet<Product>();

    public SortedSetTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productSortedSet.Add(Product.GenerateRandomProduct(id));
        }
    }
}