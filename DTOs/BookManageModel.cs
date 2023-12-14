using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LibraryManagement_PRN221_Project.DTOs
{
    internal class BookManageModel
    {
        public int TitleId { get; set; }
        public string? BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int InStock { get; set; }
        public int NumberOfPages { get; set; }
        public string? Condition { get; set; }
    }
}
