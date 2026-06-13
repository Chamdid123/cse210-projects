using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save/Load");
            Console.WriteLine("6. Quit");

            Console.Write("Select: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Goal name: ");
                    string name = Console.ReadLine();

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    Goal goal = new SimpleGoal(name,description, points );

                    manager.AddGoal(goal);
                    Console.WriteLine("Goal created!");
                    break;

                case 2:
                    manager.DisplayGoals();
                    break;

                case 3:
                    manager.DisplayGoals();
                    Console.Write("Goal Number: ");
                    int goalNumber = int.Parse(Console.ReadLine());
                    manager.RecordGoal(goalNumber - 1);
                    break;

                case 4:
                    manager.DisplayScore();
                    break;
            }
        }
    }
}
