using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaisio_EF.Domain
{
    public class Book
    {
        public int Id { get; set; } //or BookId
        public string? Title { get; set; }
        public DateTime? PubDate { get; set; }
        public int? Pages { get; set; }
    }
}
