using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DI_Contruct_Injection.Model
{
    public class BookManager
    {
        public IBookReader bookReader;

        public BookManager(IBookReader reader)
        {
            bookReader = reader;
        }

        public void ReadBooks()
        {
            bookReader.ReadBooks();
        }
    }
}
