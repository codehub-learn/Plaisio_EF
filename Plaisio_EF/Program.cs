using Plaisio_EF.Domain;
using Plaisio_EF.Data;

Author author = new Author()
{
    FirstName = "Umberto",
    LastName = "Eco"
};

Synopsis rosesynopsis = new()
{
    WriterFirstName = "John",
    WriterLastName = "Smith"
};

Book pendulum = new Book()
{
    Title = "Foucault's Pendulumn",
    PubDate = new DateTime(1988, 3, 15),
    Pages = 700,
    Author = author
};

Book rose = new Book()
{
    Title = "The Name of the Rose",
    PubDate = new DateTime(1990, 6, 15),
    Pages = 600,
    Author = author,
    Synopsis = rosesynopsis
};

using LibraryContext context = new();
//context.Books.Add(pendulum);
context.Books.AddRange(pendulum, rose);

List<Book> Books = context.Books.ToList();












































































































context.SaveChanges();