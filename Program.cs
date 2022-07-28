using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Asgn2
{
    class Program : LibraryBooks
    {
        static void Main(string[] args)
        {
   
            String ans = "yes";
            Admin ade = new Admin();
            do
            {
                Console.WriteLine("");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::    |");
                Console.WriteLine("|----------- LIBRARY MANAGEMENT SYSTEM-----------    |");
                Console.WriteLine("| Choose your option:                                |");
                Console.WriteLine("| 1.Librarian                                        |");
                Console.WriteLine("| 2.Borrower                                         |");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::    |");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());
                Program p = new Program();
                switch (ch)
                {

                    case 1:
                        p.adm(ade);
                        break;

                    case 2:
                        Console.WriteLine("Please enter your name");
                        String nam = Console.ReadLine();
                        Console.WriteLine("Please enter your Password");
                        String pw = Console.ReadLine();
                        int b = ade.Stuchk(nam, pw);
                        if (b == 1)
                            p.Stu(ade);
                        else if (b == 2)
                        {
                            Console.WriteLine("New User!!!");
                            ade.createStudent(nam, pw);
                            p.Stu(ade);
                        }
                        else
                            Console.WriteLine("Sorry!!!!! Wrong Password or Username");

                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;

                }
                Console.WriteLine("Do you want to continue?");
                ans = Console.ReadLine();
            } while (ans.Equals("yes"));
        }



        public void Stu(Admin ade)
        {
            String ans = "yes";
            ade.StuNo++;
            Student l = new Student();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::|");
                Console.WriteLine("|        Choose one option                        |");
                Console.WriteLine("|1.See Available Books                            |");
                Console.WriteLine("|2.Return Books                                   |");
                Console.WriteLine("|3.Borrow Books                                   |");
                Console.WriteLine("|4.View Details                                   |");
                Console.WriteLine("|5.View books                                     |");
                Console.WriteLine("|6.View Newspaper                                 |");
                Console.WriteLine("|7.Borrow Newspaper                               |");
                Console.WriteLine("|8.Return Newspaper                               |");
                Console.WriteLine("|9.Return to main menu                            |");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::|");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the book");
                        String name = Console.ReadLine();

                        bool p = l.searchB(name);
                        if (p == true)
                            Console.WriteLine("Book found!!");
                        else
                            Console.WriteLine("Book not found!!");
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of the book you want to return");
                        String sn = Console.ReadLine();
                        Console.WriteLine("Enter the no. of copies you want to return");
                        int ner = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                String sd = book[i, j].ToString();
                                if (sd.Equals(sn))
                                {
                                    book[i, j + 1] = (int)book[i, j + 1] + ner;
                                    break;
                                }
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the book you want to borrow");
                        String sn1 = Console.ReadLine();
                        Console.WriteLine("Enter the no. of copies you want to borrow");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter date");
                        DateTime t = Convert.ToDateTime(Console.ReadLine());
                        l.borrow(sn1, t);
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                String sd = book[i, j].ToString();
                                if (sd.Equals(sn1))
                                {
                                    book[i, j + 1] = (int)book[i, j + 1] - n2;
                                    break;
                                }
                            }
                        }

                        break;

                    case 4:
                        l.Details();
                        break;

                    case 5:
                        Console.WriteLine("Book name " + " " + "Available copies");

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write(this.book[i, j] + "             ");
                            }
                            Console.WriteLine("");
                        }

                        break;

                    case 6:
                        Console.WriteLine("Newspaper name " + " " + "Available copies");

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write(this.newsp[i, j] + "             ");
                            }
                            Console.WriteLine("");
                        }

                        break;


                    case 7:
                        Console.WriteLine("Enter the name of the newspaper");
                        String y1 = Console.ReadLine();
                        Console.WriteLine("Enter the no. of copies you want to remove");
                        int n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the issue date");
                        DateTime t1 = Convert.ToDateTime(Console.ReadLine());
                        l.borrowN(y1, t1);
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                String sd = newsp[i, j].ToString();
                                if (sd.Equals(y1))
                                {
                                    newsp[i, j + 1] = (int)newsp[i, j + 1] - n3;
                                    break;
                                }
                            }
                        }
                        break;

                    case 8:
                        Console.WriteLine("Enter the newspaper you want to return");
                        String g1 = Console.ReadLine();
                        Console.WriteLine("Enter the no. of copies you want to return");
                        int nern = int.Parse(Console.ReadLine());
                        l.returnN(g1);
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                String sd = newsp[i, j].ToString();
                                if (sd.Equals(g1))
                                {
                                    newsp[i, j + 1] = (int)newsp[i, j + 1] + nern;
                                    break;
                                }
                            }
                        }
                        break;

                    case 9:

                        return;



                }
                Console.WriteLine("Continue in LMS");
                ans = Console.ReadLine();
            } while (ans.Equals("yes"));

        }
        public void adm(Admin ade)
        {
            String ans = "yes";

            do
            {
                Console.WriteLine(":::::::::::::::::::::::::::::::::: |");
                Console.WriteLine("| 1.View Users                     |");
                Console.WriteLine("| 2.Manage Books and Newspaper     |");
                Console.WriteLine("| 3. Main menu                     |");
                Console.WriteLine("| Please enter your choice         |");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::|");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {

                    case 1:
                        ade.viewStu();
                        break;
                    case 2:
                        ade.catalogue();
                        break;
                    case 3:
                        return;

                }
                Console.WriteLine("Continue in LMS");
                ans = Console.ReadLine();
            }
            while (ans.Equals("yes"));

        }

    }
}
