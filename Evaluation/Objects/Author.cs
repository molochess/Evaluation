namespace Evaluation.Objects;

public class Author(
    string firstName,
    string lastName,
    DateTime dateOfBirth,
    string nationality,
    string biography,
    string email,
    int numberOfPublishedBooks)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public DateTime DateOfBirth { get; set; } = dateOfBirth;
    public string Nationality { get; set; } = nationality;
    public string Biography { get; set; } = biography;
    public string Email { get; set; } = email;
    public int NumberOfPublishedBooks { get; set; } = numberOfPublishedBooks;
}