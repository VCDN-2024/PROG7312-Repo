using ArraysSpaceVC;

internal class Program
{

    private static void Main(string[] args)
    {
        CustomArray<Spaceship> fleet = new CustomArray<Spaceship>(10);

        bool breakFlag = false;

        while (!breakFlag)
        {
            Console.Clear();

            Console.WriteLine("SpaceVC - Space Fleet Manager");
            Console.WriteLine("1. Add Spaceship");
            Console.WriteLine("2. Remove Spaceship");
            Console.WriteLine("3. View All Spaceships");
            Console.WriteLine("4. Search for a Spaceship");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter spaceship name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter spaceship model: ");
                    var model = Console.ReadLine();
                    Console.Write("Enter crew capacity: ");
                    int crewCapacity = int.Parse(Console.ReadLine());
                    Console.Write("Enter max speed: ");
                    double maxSpeed = double.Parse(Console.ReadLine());
                    Console.Write("Enter status (active, inactive, maintenance): ");
                    var status = Console.ReadLine();
                    Console.Write("Enter launch date (yyyy-mm-dd): ");
                    DateTime launchDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter mission type (research, transport, military, communications): ");
                    var missionType = Console.ReadLine();

                    try
                    {
                        fleet.Add(new Spaceship(name, model, crewCapacity, maxSpeed, status, launchDate, missionType));
                        // fleet.AddResize(new Spaceship(name, model, crewCapacity, maxSpeed, status, launchDate, missionType));
                        Console.WriteLine("Added successfully!");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    
                    break;
                case "2":
                    Console.Write("Enter the index of the spaceship to remove: ");
                    int index = int.Parse(Console.ReadLine());
                    try
                    {
                        fleet.RemoveAt(index);
                        Console.WriteLine("Removed successfully!");
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Here is the fleet : ");
                    fleet.Print();
                    break;
                case "4":
                    Console.Write("Enter spaceship name to search: ");
                    var searchName = Console.ReadLine();
                    var foundIndex = -1;
                    for (int i = 0; i < fleet.Count; i++)
                    {
                        if (fleet.Get(i).Name.Equals(searchName))
                        {
                            foundIndex = i;
                            break;
                        }
                    }
                    if (foundIndex != -1)
                    {
                        Console.WriteLine($"Spaceship found at index {foundIndex}: {fleet.Get(foundIndex)}");
                    }
                    else
                    {
                        Console.WriteLine("Spaceship not found.");
                    }
                    break;
                case "5":
                    breakFlag = true;
                    Console.WriteLine("Good bye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}