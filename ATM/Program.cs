internal class Program
{
    private static void Main(string[] args)
    {
        int emergency_option;
        int card_option;
        int cardless_option;
        int user;

        Console.WriteLine("1 - Card Option");
        Console.WriteLine("2 - Cardless Option");
        user = int.Parse(Console.ReadLine());

        //The option if user selected card option
        if (user == 1)
        {
            Console.WriteLine("Please Insert Your Card");
            Console.WriteLine("**************************");
            
            Console.WriteLine("Please Enter Your Password");
            Console.ReadLine();
            Console.WriteLine("**************************");

            Console.WriteLine("Hi, Welcome to Oviria Bank ATM");

            Console.WriteLine("*******************************");

            Console.WriteLine("Please select an option");
            Console.WriteLine("1 : Withdraw" + "\n" +
                              "2 : Donations" + "\n" +
                              "3 : Deposit" + "\n" +
                              "4 : Balance" + "\n" +
                              "5 : Exit");

            card_option = int.Parse(Console.ReadLine());

            if (card_option == 1)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("Please enter the amount you want to withdraw");
                Console.ReadLine();
                Console.WriteLine("*******************************");
                Console.WriteLine("Successfully Done!");
            }
            else if (card_option == 2)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("Welcome to Donations Relief Fund.");
                Console.WriteLine("Please enter the amount you want to donate");
                Console.ReadLine();

            }
            else if (card_option == 3)
            {
                Console.WriteLine("Please enter the amount you want to deposit");
                Console.ReadLine();
            }
            else if (card_option == 4)
            {
                Console.WriteLine("Please enter the amount you want to check your balance");
                Console.ReadLine();
            }
            else if (card_option == 5)
            {
                Console.WriteLine("Thank you for using Oviria Bank ATM");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please select a valid option");
                Console.ReadLine();
            }
        }

        //The option given for cardless option
        else
        {
            Console.WriteLine("Please Enter Your Account Number");
            Console.ReadLine();
            Console.WriteLine("**************************");
            Console.WriteLine("Please Enter Your Password");
            Console.ReadLine();
            Console.WriteLine("**************************");

            Console.WriteLine("Hi, Welcome to Oviria Bank ATM");

            Console.WriteLine("*******************************");

            Console.WriteLine("Please select an option");
            Console.WriteLine("1 : Withdraw" + "\n" +
                              "2 : Donations" + "\n" +
                              "3 : Deposit" + "\n" +
                              "4 : Balance" + "\n" +
                              "5 : Emergency Line" + "\n" +
                              "6 : Exit");

            cardless_option = int.Parse(Console.ReadLine());

            if (cardless_option == 1)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("Please enter the amount you want to withdraw");
                Console.ReadLine();
                Console.WriteLine("*******************************");
                Console.WriteLine("Successfully Done!");
            }
            else if (cardless_option == 2)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("Welcome to Donations Relief Fund.");
                Console.WriteLine("Please enter the amount you want to donate");
                Console.ReadLine();

            }
            else if (cardless_option == 3)
            {
                Console.WriteLine("Please enter the amount you want to deposit");
                Console.ReadLine();
            }
            else if (cardless_option == 4)
            {
                Console.WriteLine("Please enter the amount you want to check your balance");
                Console.ReadLine();
            }

            else if (cardless_option == 5)
            {

                Console.WriteLine("Welcome to Emergency Line." + "\n" +
                    "1 - Block Card" + "\n" +
                    "2 - Change Limit");
                emergency_option = Console.Read();
                if (emergency_option == 1)
                {
                    Console.WriteLine("Your card is begin proccessed to be blocked");
                }
                else if (emergency_option == 2)
                {
                    Console.WriteLine("Please enter your new limit");
                    Console.ReadLine();
                    Console.WriteLine("****************************");
                    Console.WriteLine("Your limit has been changed");
                }
                else
                {
                    Console.WriteLine("Please select correct option!!!");
                }
            }

            else if (cardless_option == 6)
            {
                Console.WriteLine("Thank you for using Oviria Bank ATM");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please select a valid option");
                Console.ReadLine();
            }
        }
    }
}