using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaisio_EF.Domain
{
    public class Synopsis
    {
        public int Id { get; set; }
        public string? WriterFirstName { get; set; }
        public string? WriterLastName { get; set; }
        public int BookId { get; set; }
        //public Book? Book { get; set; } -- Needed if i want to navigate to book from synopsis
    }
}
