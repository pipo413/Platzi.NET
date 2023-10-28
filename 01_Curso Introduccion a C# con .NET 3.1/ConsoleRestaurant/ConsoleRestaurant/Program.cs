using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> userNames = new List<string>();

        while (userNames.Count < 10)
        {
            Console.WriteLine("Write your name");
            string userName = Console.ReadLine().ToUpper();

            if (!string.IsNullOrEmpty(userName))
            {
                bool isNewUser = !userNames.Exists(u => u.Equals(userName, StringComparison.OrdinalIgnoreCase));

                if (isNewUser)
                {
                    Console.WriteLine("You are not registered yet.\nDo you want to register now? (Y/N)");

                    string userResponse;
                    do
                    {
                        userResponse = Console.ReadLine().ToUpper();
                        if (userResponse == "Y")
                        {
                            userNames.Add(userName);
                            Console.WriteLine("Congratulations, your user {0} is now registered.", userName);
                        }
                        else if (userResponse != "N")
                        {
                            Console.WriteLine("Please press (Y/N).");
                        }
                    } while (userResponse != "Y" && userResponse != "N");
                }
                else
                {
                    Console.WriteLine("Your user {0} is already registered.", userName);
                }
            }
        }

        Console.WriteLine("-------------------REGISTER-----------------");
        for (int i = 0; i < userNames.Count; i++)
        {
            Console.WriteLine("User #{0} - {1}", i + 1, userNames[i]);
        }
        Console.WriteLine("--------------------------------------------");
    }
}
