class Program
{
    static void Main(string[] args)
    {
        // Create rooms
        Room hallway = new Room("Hallway", "A long corridor with doors on each side.");
        Room kitchen = new Room("Kitchen", "A spacious area with countertops and appliances.");
        Room bedroom = new Room("Bedroom", "A cozy room with a comfortable bed.");
        Room livingroom = new Room("Livingroom", "Where you chill and watch TV.");
        Room balcony = new Room("Balcony", "You can watch birds and the skies.");
        Room bathroom = new Room("Bathroom", "Land of relief.");
        Room basement = new Room("Basement", "I keep the kids I kidnapp there all the time.");
        Room guestroom = new Room("Guestroom", "Where guests stay, obviously.");





        // Connect rooms
        hallway.AddExit(kitchen);
        kitchen.AddExit(hallway);
        hallway.AddExit(livingroom);
        livingroom.AddExit(hallway);
        livingroom.AddExit(bathroom);
        bathroom.AddExit(livingroom);
        livingroom.AddExit(basement);
        basement.AddExit(livingroom);
        basement.AddExit(guestroom);
        guestroom.AddExit(basement);
        basement.AddExit(balcony);
        balcony.AddExit(basement);



        // Create player instance
        Player player = new Player("Dr.Muhammed", hallway);

        Console.WriteLine("Hi Dr.Muhammed, let's start the game, try finding me in this house.");

        // Game loop
        while (true)
        {
            // Display player information
            Console.WriteLine();
            player.DisplayInfo();

            // Prompt player for input
            Console.WriteLine("\nWhere do you want to go? (type 'quit' to exit)");

            // Display available exits
            Console.Write("You can now go to: ");
            foreach (Room exit in player.CurrentRoom.Exits)
            {
                Console.Write(exit.Name + " ");
            }
            Console.WriteLine();

            // Read player input
            string input = Console.ReadLine();

            // Check if the player wants to quit
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the game...");
                break;
            }

            // Find the room with the input name
            Room nextRoom = player.CurrentRoom.Exits.Find(r => r.Name.ToLower() == input.ToLower());

            // Move to the next room if it exists
            if (nextRoom != null)
            {
                player.Move(nextRoom);
            }
            else
            {
                Console.WriteLine("Invalid room name. Please try again.");
            }

            // Check if the player is in the balcony (win condition)
            if (player.CurrentRoom == balcony)
            {
                Console.WriteLine("\nYou found me!! Good job, you won.");
                break;
            }
        }
    }
}