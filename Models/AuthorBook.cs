using System;
using System.Collections.Generic;

namespace _06_LibraryManagement_PRN221_Project.Models
{
    public partial class AuthorBook
    {
        public int AuthorId { get; set; }
        public int TitleId { get; set; }
        public string AuthorRole { get; set; } = null!;

        public virtual Author Author { get; set; } = null!;
        public virtual BookInfo Title { get; set; } = null!;
    }
}
