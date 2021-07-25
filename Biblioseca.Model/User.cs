using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioseca.Model
{
    class User
    {
        public User()
        {
            Borrows = new HashSet<BorrowBook>();
        }
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        // List<Prestamo> Prestamos { get; set; }
        public virtual ISet<BorrowBook> Borrows { get; set; }

    }
}
