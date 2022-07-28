using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Asgn2
{
    internal class LibraryBooks
    {
        public int bksBorrowed;  
<<<<<<< HEAD
        public int newBorrowed;
        public object[,] book = new object[5, 2]; 
        public object[,] newsp = new object[5, 2];
        public object[,] bookIssue = new object[3, 2]; 
        public object[,] newspIssue = new object[3, 2];
=======
        public object[,] book = new object[5, 2];  
        public object[,] bookIssue = new object[3, 2];
>>>>>>> e1a6d6e2d0947013edc90f3d284060c58577d3dd

        public virtual void catalogue()
        {
            System.Console.WriteLine("Catalogues");
        }

        public LibraryBooks()
        {
            char va = 'A';
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    book[i, j] = va;
                    va++;
                }
                for (int j = 1; j < 2; j++)
                {
                    book[i, j] = 5;
                }
            }

            char nva = 'N';
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    newsp[i, j] = nva;
                    nva++;
                }
                for (int j = 1; j < 2; j++)
                {
                    newsp[i, j] = 5;
                }
            }
        }



    }
}
