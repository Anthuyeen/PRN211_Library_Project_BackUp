using _06_LibraryManagement_PRN221_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LibraryManagement_PRN221_Project.Logics
{
    internal class LibrarianManagement
    {
        public static List<Librarian> GetLibrarians()
        {
            using var context = new LibraryManagementContext();
            return context.Librarians.ToList();
        }

        public static Librarian? GetLibrarian(int librarianId)
        {
            using var context = new LibraryManagementContext();
            return context.Librarians.FirstOrDefault(x => x.LibrarianId == librarianId);
        }

        public static void AddLibrarian(Librarian data)
        {
            using var context = new LibraryManagementContext();
            context.Librarians.Add(data);
            context.SaveChanges();
        }

        public static void UpdateLibrarian(Librarian data)
        {
            using var context = new LibraryManagementContext();
            context.Librarians.Update(data);
            context.SaveChanges();
        }

        public static void DeleteLibrarian(Librarian data)
        {
            using var context = new LibraryManagementContext();
            context.Librarians.Remove(data);
            context.SaveChanges();
        }
    }
}
