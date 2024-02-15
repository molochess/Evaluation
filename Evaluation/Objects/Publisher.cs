namespace Evaluation.Objects;

public class Publisher
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public int EstablishedYear { get; set; }
    public int NumberOfPublishedBooks { get; set; }

    public Publisher(string name, string address, string contactNumber, string email, int establishedYear, int numberOfPublishedBooks)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
        Email = email;
        EstablishedYear = establishedYear;
        NumberOfPublishedBooks = numberOfPublishedBooks;
    }
}