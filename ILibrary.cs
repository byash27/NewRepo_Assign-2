using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Asgn2
{
    public interface ILibrary

    {
        bool searchB(string s);
        void borrow(string bor, DateTime t);
        void returnBook(string s);
        void Details();
    }
}
