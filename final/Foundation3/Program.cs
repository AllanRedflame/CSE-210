using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Event.ShortDetails();
        Event.StandardDetails();
        Event.FullDetails();
        Console.WriteLine("\nRefresh to get new outputs!");
    }   
}

class Event {

    static Random random = new Random(); 

    private static List<string> date = new() {
        "10/24/2023",
        "10/31/2023",
        "11/1/2023",
        "11/20/2023",
        "11/29/2023"
    };



    private static List<string> time = new() {
        "11:30 AM",
        "12:30 AM",
        "2:00 PM",
        "4:00 PM",
        "7:00 PM"
    };


    public static void StandardDetails() {

        int whichEvent = random.Next(0, 3);
        
        if (whichEvent == 0) {
            Console.WriteLine($"\nTitle: {Lectures.Title}\nDescription: {Lectures.Description}\n" + 
            $"Date: {date[random.Next(0, 5)]}, Time: {time[random.Next(0, 5)]}, Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
        else if (whichEvent == 1) {
            Console.WriteLine($"\nTitle: {Receptions.Title}\nDescription: {Receptions.Description}\n" + 
            $"Date: {date[random.Next(0, 5)]}, Time: {time[random.Next(0, 5)]} Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
        else {
            Console.WriteLine($"\nTitle: {Outdoor.Title}\nDescription: {Outdoor.Description}\n" + 
            $"Date: {date[random.Next(0, 5)]}, Time: {time[random.Next(0, 5)]} Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
    }

    public static void FullDetails() {
        int whichEvent = random.Next(0, 3);

        if (whichEvent == 0) {
            Console.WriteLine($"\nEvent: Lecture, Title: {Lectures.Title}\n"+
            $"Description: {Lectures.Description}, Speaker: {Lectures.Speaker[random.Next(1, 3)]}, Capacity: {Lectures.Capacity[random.Next(1, 3)]}\n" + 
            $"Date: {date[random.Next(0, 5)]}, Time: {time[random.Next(0, 5)]}, Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
        else if (whichEvent == 1) {
            Console.WriteLine($"\nEvent: Reception, Title: {Receptions.Title}\n" + 
            $"{Receptions.Title}, Description: {Receptions.Description} " + 
            $"RSVP Email: {Receptions.Email}\nDate: {date[random.Next(0, 5)]}, Time: {time[random.Next(0, 5)]}, Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
        else {
            Console.WriteLine($"\nEvent: Outdoor Event, Title: {Outdoor.Title}\n" + 
            $"Description: {Outdoor.Description}, Weather: {Outdoor.Weather[random.Next(1, 3)]}, " + 
            $"Date: {date[random.Next(0, 5)]}, Time: {time[random.Next(0, 5)]}, Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
    }

    public static void ShortDetails() {

        int whichEvent = random.Next(0, 3);

        if (whichEvent == 0) {
            Console.WriteLine($"\nEvent: Lecture, Title: {Lectures.Title}\n" + 
            $"Date: {date[random.Next(0, 5)]}, Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
        else if (whichEvent == 1) {
            Console.WriteLine($"\nEvent: Reception, Title: {Receptions.Title}\n" + 
            $"Date: {date[random.Next(0, 5)]}, Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }
        else {
            Console.WriteLine($"\nEvent: Outdoor Event, Title: {Outdoor.Title}\n" + 
            $"Date: {date[random.Next(0, 5)]}, Address: {Address.Addresses[random.Next(0, Address.Addresses.Count)]}");
        }



    }

    class Address {

        private static List<string> addresses = new() {
            "221 Baker Street",
            "4 Privet Drive",
            "124 Conch Street",
            "12 Grimmauld Place",
            "93 Diagon Ally",
            "Venus 1234, Sky Pad Apartments",
            "17 Cherry Tree Lane",
            "1313 Webfoot Walk",
            "P Sherman 42 Wallaby Way, Sydney"
        };

        public static List<string> Addresses {
            get {
                return addresses;
            }
        }

    }

    class Lectures {

        private static string title = "History Lecture";

        public static string Title {
            get {
                return title;
            }
        }

        private static string description = "Lecture on the Russian Revolution";

        public static string Description {
            get {
                return description;
            }
        }
        private static List<string> speaker = new(){
            "Robert James",
            "James Arnold",
            "Samuel Brown"
        };

        public static List<string> Speaker {
            
            get {
                return speaker;
            }
        }
        
        private static List<string> capacity = new() {
            "50",
            "100",
            "300"
        };

        public static List<string> Capacity {
            
            get {
                return capacity;
            }
        }

    }

    class Receptions {

        private static string title = "Wedding Reception";

        public static string Title {
            get {
                return title;
            }
        }

        private static string description = "Wedding reception for Bob and Rebecca";

        public static string Description {

            
            get {
                return description;
            }
        }

        private static string email = "receptionemail@email.com";

        public static string Email {
            get {
                return email;
            }
        }
    }

    class Outdoor {

        private static string title = "Outdoor Get-Together";

        public static string Title {
            get {
                return title;
            }
        }

        private static string description = "Outdoor social event. Come and meet new people!";

        public static string Description {
            get {
                return description;
            }
        }

        private static List<string> weather = new() {
            "Sunny",
            "Windy",
            "Cloudy"
        };

        public static List<string> Weather {
            get {
                return weather;
            }
        }


    }

}
