using System;
namespace prjConCsProjectCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 choice, addnum, multinum;
            Single vals, div1, div2, sub1, sub2; ;
            char yn;

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t     NUMERIC CALCULATOR");
                    Console.WriteLine("\tMain Menu Operators Choice");
                    Console.WriteLine("\t--------------------------\n");
                    Console.WriteLine("1 - ADDITION");
                    Console.WriteLine("2 - DIVISION");
                    Console.WriteLine("3 - MULTIPLICATION");
                    Console.WriteLine("4 - SUBSTRACTION");
                    Console.WriteLine("5 - QUIT\n");
                    Console.Write("Make your choice (1 - 5) : ");
                    choice = Convert.ToInt16(Console.ReadLine());
                } while (choice > 5 || choice < 1);


                switch (choice)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tADDITION OPERATION");
                            Console.WriteLine("\t\t------------------\n");
                            Console.Write("Enter the number of values to add : ");
                            addnum = Convert.ToInt16(Console.ReadLine());

                            while (addnum < 2 || addnum > 20)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\tADDITION OPERATION");
                                Console.WriteLine("\t\t------------------\n");
                                Console.Write("Enter the number of values to add : ");
                                addnum = Convert.ToInt16(Console.ReadLine());
                            }
                            Single sum = 0;

                            for (Int16 i = 1; i <= addnum; i++)
                            {
                                Console.Write("\tEnter value " + i + " : ");
                                vals = Convert.ToSingle(Console.ReadLine());
                                sum += vals;
                            }


                            Console.WriteLine("\t\t     -------");
                            Console.WriteLine("\tThe Result is   " + sum + "\n");

                            do
                            {
                                Console.Write("Do you want to do another addition ? (y/n): ");
                                yn = Convert.ToChar(Console.ReadLine());
                            } while (!(yn == 'y' || yn == 'n' || yn == 'Y' || yn == 'N'));

                        } while (yn == 'y' || yn == 'Y');
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tDIVISION OPERATION");
                            Console.WriteLine("\t\t------------------\n");
                            Console.Write(" Enter the value to divide : ");
                            div1 = Convert.ToSingle(Console.ReadLine());

                            Console.Write(" Enter the divider (not 0) : ");
                            div2 = Convert.ToSingle(Console.ReadLine());

                            while (div2 == 0)
                            {
                                Console.Write(" Enter the divider (not 0) : ");
                                div2 = Convert.ToSingle(Console.ReadLine());
                            }
                            Single sum = div1 / div2;

                            Console.WriteLine("\t\t\t    -------");
                            Console.WriteLine("\t   The Result is     " + sum + "\n");

                            do
                            {
                                Console.Write("Do you want to do another division ? (y/n): ");
                                yn = Convert.ToChar(Console.ReadLine());
                            } while (!(yn == 'y' || yn == 'Y' || yn == 'n' || yn == 'N'));

                        } while (yn == 'y' || yn == 'Y');
                        break;

                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tMULTIPLICATION OPERATION");
                            Console.WriteLine("\t\t------------------------\n");
                            Console.Write("Enter the number of values to multiply : ");
                            multinum = Convert.ToInt16(Console.ReadLine());
                            while (multinum < 2 || multinum > 20)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\tMULTIPLICATION OPERATION");
                                Console.WriteLine("\t\t------------------------\n");
                                Console.Write("Enter the number of values to multiply : ");
                                multinum = Convert.ToInt16(Console.ReadLine());
                            }

                            Single sum = 1;

                            for (Int16 i = 1; i <= multinum; i++)
                            {
                                Console.Write("\tEnter value " + i + " : ");
                                vals = Convert.ToSingle(Console.ReadLine());
                                sum *= vals;
                            }

                            Console.WriteLine("\t\t     -------");
                            Console.WriteLine("\tThe Result is  " + sum + "\n");

                            do
                            {
                                Console.Write("Do you want to do another multiplication ? (y/n): ");
                                yn = Convert.ToChar(Console.ReadLine());
                            } while (!(yn == 'y' || yn == 'Y' || yn == 'n' || yn == 'N'));

                        } while (yn == 'y' || yn == 'Y');

                        break;

                    case 4:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tSUBTRACTION OPERATION");
                            Console.WriteLine("\t\t---------------------\n");
                            Console.Write(" Enter the first value : ");
                            sub1 = Convert.ToSingle(Console.ReadLine());

                            Console.Write(" Enter value to subtract: ");
                            sub2 = Convert.ToSingle(Console.ReadLine());

                            Single sum = sub1 - sub2;

                            Console.WriteLine("\t\t\t------");
                            Console.WriteLine("\t The Result is    " + sum + "\n");

                            do
                            {
                                Console.Write("Do you want to do another subtraction ? (y/n): ");
                                yn = Convert.ToChar(Console.ReadLine());
                            } while (!(yn == 'y' || yn == 'Y' || yn == 'n' || yn == 'N'));

                        } while (yn == 'y' || yn == 'Y');
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Thank you for using this calculator!");
                        break;
                }
            } while (choice != 5);

        }
    }
}