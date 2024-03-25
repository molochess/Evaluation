using Evaluation.Objects;

namespace Evaluation.Collections;

public class StackTest
{
    private readonly Stack<Product> productQueue = new Stack<Product>();

    public StackTest()
    {
        for (int i = 0; i < 50; i++)
        {
            int id = i + 1;
            productQueue.Push(Product.GenerateRandomProduct(id));
        }
    }

}