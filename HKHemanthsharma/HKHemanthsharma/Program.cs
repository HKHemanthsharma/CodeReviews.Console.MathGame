namespace HKHemanthsharma
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static List<int> li = new List<int>();
        public static void Main(string[] args)
        {
            int score = 0;
            var rand = new Random();

            while (true)
            {
                Console.WriteLine("Hello let's play a Fun Math Game? please select your choice:");
                Console.WriteLine("To View previous Games: press 'V'");
                Console.WriteLine("To Play Addition Games: Press 'A'");
                Console.WriteLine("To Play Subtract Games: Press 'S'");
                Console.WriteLine("To Play Division Games: Press 'D'");
                Console.WriteLine("To Play Addition Games: Press 'M'");
                string inp = Console.ReadLine();
                DateTime t1 = DateTime.Now;
                switch (inp)
                {
                    case "A":
                        Console.Clear();
                        Console.WriteLine("Addition Game: ");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Clear();
                            int first = rand.Next(100);
                            int second = rand.Next(100);
                            Console.WriteLine($"{first} + {second}");
                            int res = int.Parse(Console.ReadLine());
                            if (res == first + second)
                            {
                                score++;
                                Console.WriteLine("Correct! press any key for next question!");
                            }
                            else
                            {
                                Console.WriteLine("Press any key for next question");
                            }
                            Console.ReadLine();
                        }
                        Console.WriteLine("Your final score is " + score);
                        li.Add(score);
                        score = 0;
                        break;
                    case "S":
                        Console.Clear();
                        Console.WriteLine("Subtraction Game: ");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Clear();
                            int first = rand.Next(100);
                            int second = rand.Next(100);
                            Console.WriteLine($"{first} - {second}");
                            int res = int.Parse(Console.ReadLine());
                            if (res == first - second)
                            {
                                score++;
                            }
                            Console.WriteLine("Press any key for next question ");
                            Console.ReadLine();
                        }
                        Console.WriteLine("Your final score is " + score);
                        li.Add(score);
                        score = 0;
                        break;
                    case "M":
                        Console.Clear();
                        Console.WriteLine("Multiplication Game: ");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Clear();
                            int first = rand.Next(100);
                            int second = rand.Next(100);
                            Console.WriteLine($"{first} - {second}");
                            int res = int.Parse(Console.ReadLine());
                            if (res == first * second)
                            {
                                score++;
                            }
                            Console.WriteLine("Press any key for next question");
                            Console.ReadLine();
                        }
                        Console.WriteLine("Your final score is " + score);
                        li.Add(score);
                        score = 0;
                        break;
                    case "D":
                        Console.Clear();
                        Console.WriteLine("Division Game: ");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Clear();
                            int first = rand.Next(100);
                            int second = rand.Next(100);
                            if (first % second == 0)
                            {
                                Console.WriteLine($"{first} / {second}");
                                int res = int.Parse(Console.ReadLine());
                                if (res == first / second)
                                {
                                    score++;
                                }
                                Console.WriteLine("Press any key for next question ");
                                Console.ReadLine();
                            }
                        }
                        Console.WriteLine("Your final score is " + score);
                        li.Add(score);
                        score = 0;
                        break;
                    case "V":
                        Console.Clear();
                        history();
                        break;



                }
                DateTime t2 = DateTime.Now;
                Console.WriteLine("you've completed the game in " + (t2 - t1) + " seconds");
                Console.WriteLine("Press any key to Go back to Main Menu ");
                Console.ReadLine();
            }
        }
        static void history()
        {
            if (li.Count == 0)
            {
                Console.WriteLine("you have not played any game as of now please choose a game and play to see your results history");
            }
            foreach (var sc in li)
            {
                Console.WriteLine(sc);
            }
        }







    }
}