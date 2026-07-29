using System;

namespace ExpenseApplication
{
    class ExpenseInfo
    {
        public int ExpenseNo;
        public string ExpenseType;
        public double ExpenseAmount;
        public string PaymentMethod;
        public DateTime EntryDate;

        public ExpenseInfo(int no, string type, double amount, string method)
        {
            ExpenseNo = no;
            ExpenseType = type;
            ExpenseAmount = amount;
            PaymentMethod = method;
            EntryDate = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Expense Number : " + ExpenseNo);
            Console.WriteLine("Category       : " + ExpenseType);
            Console.WriteLine("Amount         : " + ExpenseAmount);
            Console.WriteLine("Payment Method : " + PaymentMethod);
            Console.WriteLine("Date           : " + EntryDate);
            Console.WriteLine("--------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExpenseInfo[] expense = new ExpenseInfo[100];
            int count = 0;

            int choice;

            do
            {
                Console.WriteLine("\n======= Expense Tracker =======");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. View Total Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter Expense Number: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Category: ");
                            string category = Console.ReadLine();

                            Console.Write("Enter Amount: ");
                            double amount = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Payment Method: ");
                            string payment = Console.ReadLine();

                            expense[count] = new ExpenseInfo(id, category, amount, payment);
                            count++;

                            Console.WriteLine("Expense Added Successfully.");
                            break;

                        case 2:

                            if (count == 0)
                            {
                                Console.WriteLine("No Expense Records Found.");
                            }
                            else
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    expense[i].Display();
                                }
                            }

                            break;

                        case 3:

                            double total = 0;

                            for (int i = 0; i < count; i++)
                            {
                                total += expense[i].ExpenseAmount;
                            }

                            Console.WriteLine("Total Expense = " + total);

                            break;

                        case 4:

                            Console.WriteLine("Thank You!");
                            break;

                        default:

                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! Please enter numeric values only.");
                    choice = 0;
                }

            } while (choice != 4);
        }
    }
}