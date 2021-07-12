using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioseca.Model
{
    class BorrowBook
    {
        public virtual List<Book> Book { get; set; }
        public virtual User User { get; set; }
        public DateTime DateTime { get; set; }


    }


}

