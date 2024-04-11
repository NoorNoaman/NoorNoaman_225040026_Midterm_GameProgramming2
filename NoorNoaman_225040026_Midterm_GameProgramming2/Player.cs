using System;
using System.Collections.Generic;


// Define a class for the player
public class Player
{
    public string Name { get; set; }
    public Room CurrentRoom { get; set; }

    // Setting properties
    public Player(string name, Room startingRoom)
    {
        Name = name;
        CurrentRoom = startingRoom;
    }

    // Displaying info for orientation
    public void DisplayInfo()
    {
        Console.WriteLine("You are now in the " + CurrentRoom.Name);
        Console.WriteLine(CurrentRoom.Description);
    }

    // Incrementing the rooms as player progresses
    public void Move(Room newRoom)
    {
        CurrentRoom = newRoom;
    }
}