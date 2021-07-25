using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioseca.Model
{
    class BorrowBook
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        //public virtual List<Book> Book { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime StartBorrow { get; set; }
        public virtual DateTime FinishBorrow { get; set; }

    }


}

