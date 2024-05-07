using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
    // hardcode employee's username and password for login authentication
    static Dictionary<string, string> dict_login = new Dictionary<string, string>();
    static Dictionary<int, int> roomCapacity = new Dictionary<int, int>()
    {
        {101, 2}, {102, 2}, {103, 2}, {104, 2}, {105, 2},
        {106, 3}, {107, 3}, {108, 3}, {109, 3}, {110, 4}
    };

    static Dictionary<int, string> reservedRooms = new Dictionary<int, string>();

    public static void Main (string[] args) {
        dict_login.Add("alice", "alice123");

        Console.WriteLine("-----Welcome to Hotel Management System------");
        Console.WriteLine("Student's Name: Jose Torres");

        Login();
    }

    static void Login() {
        Console.Write("\nEnter username: ");
        string inputUsername = Console.ReadLine();

        Console.Write("Enter password: ");
        string inputPassword = Console.ReadLine();

        if (inputUsername == "alice" && inputPassword == "alice123") {
            Console.WriteLine($"\nWelcome, {inputUsername}!\n");

            ShowMainMenu();
        } else {
            Console.WriteLine("\nIncorrect username or password. Exiting the application.");
            Environment.Exit(0);
        }
    }

    static void ShowMainMenu() {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Show Available Rooms");
        Console.WriteLine("2. Check-In");
        Console.WriteLine("3. Show Reserved Rooms");
        Console.WriteLine("4. Check-Out");
        Console.WriteLine("5. Log Out");

        Console.Write("\nEnter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice) {
            case 1:
                ShowAvailableRooms();
                break;
            case 2:
                CheckIn();
                break;
            case 3:
                ShowReservedRooms();
                break;
            case 4:
                CheckOut();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                ShowMainMenu();
                break;
        }
    }

    static void ShowAvailableRooms() {
        Console.WriteLine("\nAvailable Rooms:");
        foreach (var room in roomCapacity) {
            if (!reservedRooms.ContainsKey(room.Key)) {
                Console.WriteLine($"Room number: {room.Key}; Capacity: {room.Value}");
            }
        }
    }

    static void CheckIn() {
        Console.Write("\nEnter number of people: ");
        int numOfPeople = Convert.ToInt32(Console.ReadLine());

        bool suitableRoomFound = false;

        Console.WriteLine("\nRooms with suitable capacity:");
        foreach (var room in roomCapacity) {
            if (!reservedRooms.ContainsKey(room.Key) && room.Value >= numOfPeople) {
                Console.WriteLine($"Room number: {room.Key}; Capacity: {room.Value}");
                suitableRoomFound = true;
            }
        }

        if (!suitableRoomFound) {
            Console.WriteLine("No suitable room available.");
            return;
        }

        Console.Write("\nEnter room number for check-in: ");
        int roomNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter customer email: ");
        string customerEmail = Console.ReadLine();

        reservedRooms.Add(roomNumber, $"{customerName} ({customerEmail})");
        Console.WriteLine("Check-in successful!");
    }

    static void ShowReservedRooms() {
        Console.WriteLine("\nReserved Rooms:");
        foreach (var room in reservedRooms) {
            Console.WriteLine($"Room number: {room.Key}; Customer: {room.Value}");
        }
    }

    static void CheckOut() {
        Console.Write("\nEnter room number for check-out: ");
        int roomNumber = Convert.ToInt32(Console.ReadLine());

        if (reservedRooms.ContainsKey(roomNumber)) {
            Console.WriteLine($"Customer: {reservedRooms[roomNumber]}");
            Console.Write("Confirm check-out (y/n): ");
            char confirmation = Convert.ToChar(Console.ReadLine());

            if (confirmation == 'y' || confirmation == 'Y') {
                reservedRooms.Remove(roomNumber);
                Console.WriteLine("Check-out successful!");
            } else {
                Console.WriteLine("Check-out canceled.");
            }
        } else {
            Console.WriteLine("Invalid room number.");
        }
    }
}
