// See https://aka.ms/new-console-template for more information

using Evaluation.Collections;
using Evaluation.Objects;

/*
    Try to evaluate values in this collections with "View" button
    in Immediate Window or in evaluation pop-up
*/
var array = new ArrayTest();
var concurrentDictionary = new ConcurrentDictionaryTest();
var hashSet = new HashSetTest();
var linkedList = new LinkedListTest();
var list = new ListTest();
var observableCollection = new ObservableCollectionTest();
var queue = new QueueTest();
var sortedDictionary = new SortedDictionaryTest();
var sortedSet = new SortedSetTest();
var stack = new StackTest();
var authors = new List<Author>();
var publishers = new List<Publisher>();
var books = new List<Book>();

// Create 60 unique Authors
for (int i = 1; i <= 60; i++)
{
    authors.Add(new Author(
        $"FirstName{i}",
        $"LastName{i}",
        new DateTime(1970 + (i % 30), 1, 1), 
        $"Nationality{i}",
        $"Biography of Author {i}",
        $"author{i}@example.com",
        i 
    ));
}

// Create 10 unique Publishers
for (int i = 1; i <= 10; i++)
{
    publishers.Add(new Publisher(
        $"PublisherName{i}",
        $"Address{i}",
        $"ContactNumber{i}",
        $"publisher{i}@example.com",
        1900 + i, 
        i * 10 
    ));
}

// Generate 100 Books, reusing Authors and Publishers
for (int i = 1; i <= 1000; i++)
{
    Author author = authors[(i - 1) % 60]; 
    Publisher publisher = publishers[(i - 1) % 10]; 
    
    Book book = new Book(
        $"Book Title {i}",
        (i % 2 == 0),
        $"ISBN-{i}",
        author,
        publisher,
        2000 + (i % 20), 
        [$"Genre{i}", $"Genre{i + 1}", $"Genre{i + 2}", $"Genre{i + 3}"],
        100 + i, 
        10 + (i % 5), 
        1.99 + (i % 5), 
        $"ShelfLocation{i}"
    );

    books.Add(book);
}

Console.WriteLine("Hello, World!"); // Here create a breakpoint, if there is no