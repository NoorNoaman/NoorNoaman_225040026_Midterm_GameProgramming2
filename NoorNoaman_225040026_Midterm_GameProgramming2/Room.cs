using System;
using System.Collections.Generic;


// Defining the class named Room
public class Room
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Room> Exits { get; set; }

    // Setting the properties
    public Room(string name, string description)
    {
        Name = name;
        Description = description;
        Exits = new List<Room>();
    }

    // Creating the exits of the rooms
    public void AddExit(Room room)
    {
        Exits.Add(room);
    }
}