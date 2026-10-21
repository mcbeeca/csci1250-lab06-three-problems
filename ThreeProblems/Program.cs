/*
* Name: Chase McBee
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

int choice = 0;

// do while: the menu needs to reprint every time if the value is not 5
do
{
   choice = 0;

   Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
   Console.WriteLine("1. The Grade Checker");
   Console.WriteLine("2. The Dice Table");
   Console.WriteLine("3. The Score Report");
   Console.WriteLine("4. All three");
   Console.WriteLine("5. Quit");

   Console.Write("Choose 1 through 5: ");
   int.TryParse(Console.ReadLine(), out choice);

    // while: the number of invalid entries is unknown, and there may be none
            while (choice < 1 || choice > 5)
            {
                Console.Write("Choose a number from 1 to 5: ");
                int.TryParse(Console.ReadLine(), out choice);
            }

            if (choice == 1 || choice == 4)
            {
                Console.WriteLine("test 1.");
            }

            if (choice == 2 || choice == 4)
            {
                Console.WriteLine("test 2.");
            }

            if (choice == 3 || choice == 4)
            {
                Console.WriteLine("test 3.");
            }

} while (choice != 5);

Console.WriteLine("Goodbye.");

    
