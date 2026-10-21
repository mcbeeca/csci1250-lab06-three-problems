/*
* Name: Chase McBee
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.Formats.Asn1;

int choice = 0;
Random rng = new Random(4000);

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

            // while: choices may be more than the range of 1 to 5, or may be invalid/nothing at all
            while (choice < 1 || choice > 5)
            {
                Console.Write("Choose a number from 1 to 5: ");
                int.TryParse(Console.ReadLine(), out choice);
            }
            
            // if: choices can range from 1 to 5
            if (choice == 1 || choice == 4)
            {
                Console.WriteLine("\n=== The Grade Checker ===");

                Console.WriteLine("Score: ");
                int score = int.Parse(Console.ReadLine());

                // while: scores may not be in between 0 and 100, may be invalid characters or nothing at all
                while (score < 0 || score > 100)
                {
                    Console.WriteLine("A score must be between 0 and 100.");
                    Console.WriteLine("Score: ");
                    score = int.Parse(Console.ReadLine());
                }

        char grade;
        
        // if: scores can be in the range of any of the else-if values
        if (score >= 90)
                   grade = 'A';
                // else if: scores can be in the range of 80
                else if (score >= 80)
                   grade = 'B';
                // else if: scores can be in the range of 70
                else if (score >= 70)
                   grade = 'C';
                // else if: scores can be in the range of 60
                else if (score >= 60)
                   grade = 'D';
                else 
                   grade = 'F';
                
                Console.WriteLine($"{score} earns a {grade}!");
            }
            
            // if: choices can range from 1 to 5
            if (choice == 2 || choice == 4)
            {
                int rollNumber = 0;
                int wins = 0;
                Console.WriteLine("=== Exercise 2: The Dice Table ===");
                char answer = 'y';
                // while: as long as the answer is y, it'll continue the loop
                while (answer == 'y')
                {
                  int dice1 = rng.Next(1, 7);
                  int dice2 = rng.Next(1, 7);
                  rollNumber++;
                  
                  int total = dice1 + dice2;
                  Console.Write($"Roll {rollNumber}: {dice1} and {dice2}, total {total}");
                  
                  // if: total can be anything in the range of the combined values of the two dice
                  if (total == 7 || total == 11)
                  {
                    Console.Write(" Winner!");
                    wins++;
                  }
                  // if: the two dice rolls indivdually can be anything between 1 to 6
                  if (dice1 == 1 && dice2 == 1)
                  {
                    Console.Write(" Snake Eyes!");
                  }
                  // else if: the two dice rolls indivdually can be anything between 1 to 6
                  else if (dice1 == dice2)
                  {
                    Console.Write(" Doubles!");
                  }

                  Console.WriteLine($"\nRoll again? y/n");
                  string input = Console.ReadLine();
                  answer = input.Length > 0 ? char.ToLower(input[0]) : 'n';

                }
                
                // if: the answer could either be y or n
                if (answer == 'n')
                {
                    Console.WriteLine($"You rolled {rollNumber} times and won {wins} times!");
                }
                
            }
            
            // if: choices can range from 1 to 5
            if (choice == 3 || choice == 4)
            {
                int[] scores = new int[5];
                int total = 0;
                int highest = int.MinValue;
                int passing = 0;

                Console.WriteLine("\n=== Exercise 3: The Score Report ===");
                
                // if: choices can range from 1 to 5
                for (int i = 0; i < scores.Length; i++)
                {
                   Console.WriteLine($"Score {i + 1}: ");
                   scores[i] = int.Parse(Console.ReadLine()!);

                   total += scores[i];

                   if (scores[i] > highest);
                   {
                      highest = scores[i];
                   }

                   if (scores[i] >= 60); 
                   {
                     passing++;
                   }
                }

                double average = (double)total / scores.Length;

                Console.WriteLine($"Scores entered: {scores.Length}");
                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"Average: {average:F1}");
                Console.WriteLine($"Highest: {highest}");
                Console.WriteLine($"Passing: {passing} of {scores.Length}");
            }

} while (choice != 5);

Console.WriteLine("Goodbye.");

    
