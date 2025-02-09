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
            bool result;

            while (true)
            {
                Console.WriteLine("Choose the difficulty level:");
                Console.WriteLine("press '1' for easy:");
                Console.WriteLine("press '2' for medium:");
                Console.WriteLine("press '3' for Hard:");
                List<int> validdificulty = new List<int>() {1,2,3 };
                int difficulty;
                int seed;
                bool inpresult=int.TryParse(Console.ReadLine(), out difficulty);
                while(!inpresult || (!validdificulty.Contains(difficulty)))
                {
                    Console.WriteLine("Please select a valid integer between 1,2 or 3:");
                    inpresult = int.TryParse(Console.ReadLine(), out difficulty);
                }
                if(difficulty==1)
                {
                    seed = 100;
                }
                else if(difficulty==2)
                {
                    seed = 500;
                }
                else
                {
                    seed = 2000;
                }
                Console.Clear();
                Console.WriteLine("Hello let's play a Fun Math Game? please select your choice:");
                Console.WriteLine("To View previous Games: press 'V'");
                Console.WriteLine("To Play Addition Games: Press 'A'");
                Console.WriteLine("To Play Subtract Games: Press 'S'");
                Console.WriteLine("To Play Division Games: Press 'D'");
                Console.WriteLine("To Play Multiplication Games: Press 'M'");
                string inp = Console.ReadLine();
                DateTime t1=DateTime.Now;
                
                switch (inp.ToUpper())
                { 
                    case "A":
                        Console.Clear();
                        Console.WriteLine("Addition Game: ");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Clear();
                            int first = rand.Next(seed);
                            int second = rand.Next(seed);
                            Console.WriteLine($"{first} + {second}");
                            int res;
                            result= int.TryParse(Console.ReadLine(),out res);
                            while(!result)
                            {
                                Console.WriteLine("please enter a valid integer: ");
                                result= int.TryParse(Console.ReadLine(), out res);
                            }
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
                            int first = rand.Next(seed);
                            int second = rand.Next(seed);
                            Console.WriteLine($"{first} - {second}");
                            int res;
                            result = int.TryParse(Console.ReadLine(), out res);
                            while (!result)
                            {
                                Console.WriteLine("please enter a valid integer: ");
                                result = int.TryParse(Console.ReadLine(), out res);
                            }
                            if (res == first - second)
                            {
                                score++;
                                Console.WriteLine("Correct! ");
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
                            int first = rand.Next(seed);
                            int second = rand.Next(seed);
                            Console.WriteLine($"{first} * {second}");
                            int res;
                            result = int.TryParse(Console.ReadLine(), out res);
                            while (!result)
                            {
                                Console.WriteLine("please enter a valid integer: ");
                                result = int.TryParse(Console.ReadLine(), out res);
                            }
                            if (res == first * second)
                            {
                                score++;
                                Console.WriteLine("Correct!");
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
                        int count = 0;
                        while(count<5)
                        {
                            Console.Clear();
                            int first = rand.Next(seed);
                            int second = rand.Next(1,seed);
                            if (first % second == 0)
                            {
                                count++;
                                Console.WriteLine($"{first} / {second}");
                                int res;
                                result = int.TryParse(Console.ReadLine(), out res);
                                while (!result)
                                {
                                    Console.WriteLine("please enter a valid integer: ");
                                    result = int.TryParse(Console.ReadLine(), out res);
                                }
                                if (res == first / second)
                                {
                                    score++;
                                    Console.WriteLine("Correct!");
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
                        History();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input: ");
                        break;


                }
                DateTime t2 = DateTime.Now;
                Console.WriteLine("you've completed the game in " + (t2 - t1) + " seconds");
                Console.WriteLine("Press any key to Go back to Main Menu ");
                Console.ReadLine();
            }
        }
        static void History()
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