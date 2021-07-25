using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioseca.Model
{
    class Punishment
    {
        public virtual int Id { get; set; }
        public virtual User User { get; set; }
        public virtual BorrowBook BorrowBook { get; set; }
        public virtual int Count { get; set; }

    }
}
