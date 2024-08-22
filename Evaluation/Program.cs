// See https://aka.ms/new-console-template for more information

using System.Data;
using Evaluation.Collections;
using Evaluation.Objects;
using Evaluation.StringVisualizers;

/*
    Try to evaluate values in this collections with "View" button
    in Immediate Window or in evaluation pop-up
*/

Console.WriteLine("Evaluation program");
int k = 223343;
var str = "fhebrfhberuygfyrefyuer=uyfgeryu";
var html =
    $"<html><head><title>Your = Title Here</title></head><body bgcolor=\"000000\"><hr/><a href=\"http://somegreatsite.com\">Link Name</a> is a link to = another site<h1>This is a Header</h1><h2>This is a Medium Header</h2>Send me mail at <a href=\"mailto:support@yourcompany.com\">support@yourcompany.com</a>.<p>This is a new paragraph!</p><p><b>This is a new paragraph!</b><br/><b><i>This is a new sentence without a paragraph break, in bold italics.</i></b></p><hr/></body></html>";
var jwt =
    "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJPbmxpbmUgSldUID0gQnVpbGRlciIsImlhdCI6MTcyMjUzNjc5NSwiZXhwIjoxNzU0MDcyNzk1LCJhdWQiOiJ3d3cuZXhhbXBsZS5jb20iLCJzdWIiOiJqcm9ja2V0QGV4YW1wbGUuY29tIiwiR2l2ZW5OYW1lIjoiSm9oPW5ueSIsIlN1cm5hbWUiOiJSb2NrZXQiLCJFbWFpbCI6Impyb2NrZXRAZXhhbXBsZS5jb20iLCJSb2xlIjpbIk1hbmFnZXIiLCJQcm9qZWN0IEFkbWluaXN0cmF0b3IiXX0.mnI_StjcRgDuSrXMZQyafxyuNUSSt9S8AUu0_oqkcjg";
var strVis = new StringVisualizersTest();
var strings = new StringVisualizersTest();
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
var dataTable = DataTableTest.CreateDataTable();

int[,] array2D = new int[151, 151];

for (int i = 0; i < 151; i++)
{
    for (int j = 0; j < 151; j++)
    {
        array2D[i, j] = i+j;
    }
}

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

Console.WriteLine("Evaluation program");
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



