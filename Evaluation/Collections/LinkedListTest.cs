using Evaluation.Objects;

namespace Evaluation.Collections;

public class LinkedListTest
{
    readonly LinkedList<Product> productLinkedList = new LinkedList<Product>();

    public LinkedListTest()
    {
        for (int i = 0; i < 105; i++)
        {
            int id = i + 1;
            productLinkedList.AddLast(Product.GenerateRandomProduct(id));
        }

    }
}