﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Asgn2
{
    internal class LibraryBooks
    {
        public int bksBorrowed;  // No of books borrowed
        public object[,] book = new object[5, 2];  // matrix of books for size 5 x 2
        public object[,] bookIssue = new object[3, 2]; // for a perticular user (name of the book and the issue date)matrix size 3 x 2

        public virtual void catalogue()
        {
            System.Console.WriteLine("Admin's Catalogue Management");
        }

        public LibraryBooks()
        {
            char va = 'a';
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
        }
    }
}
