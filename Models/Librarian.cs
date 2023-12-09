using System;
using System.Collections.Generic;

namespace _06_LibraryManagement_PRN221_Project.Models
{
    public partial class Librarian
    {
        public Librarian()
        {
            Accounts = new HashSet<Account>();
            LendBookDetails = new HashSet<LendBookDetail>();
            ReturnBooks = new HashSet<ReturnBook>();
        }

        public int LibrarianId { get; set; }
        public string LibrarianName { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<LendBookDetail> LendBookDetails { get; set; }
        public virtual ICollection<ReturnBook> ReturnBooks { get; set; }
    }
}
