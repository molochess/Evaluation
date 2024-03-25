using Evaluation.Objects;

namespace Evaluation.Collections;

public class ListTest
{
    readonly List<Product> productList = new List<Product>();

    public ListTest()
    {
        for (int i = 0; i < 105; i++)
        {
            int id = i + 1;
            productList.Add(Product.GenerateRandomProduct(id));
        }

    }
}