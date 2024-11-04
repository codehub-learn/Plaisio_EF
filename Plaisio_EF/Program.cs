using Plaisio_EF.Domain;
using Plaisio_EF.Data;

Book pendulum = new Book()
{
    Title = "Foucault's Pendulumn",
    PubDate = new DateTime(1988, 3, 15),
    Pages = 700
};

using LibraryContext context = new();
context.Books.Add(pendulum);
context.SaveChanges();