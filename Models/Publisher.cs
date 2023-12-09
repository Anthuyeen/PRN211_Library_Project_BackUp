using System;
using System.Collections.Generic;

namespace _06_LibraryManagement_PRN221_Project.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            BookInfos = new HashSet<BookInfo>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; } = null!;

        public virtual ICollection<BookInfo> BookInfos { get; set; }
    }
}
