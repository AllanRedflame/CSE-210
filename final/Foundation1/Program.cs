using System;
using System.Collections.Generic;

class Program {

    public static void Main() {
        Console.Clear();
        for (int i = 0; i < 3; i++) {

            Console.WriteLine($"{Video.TitleProperty[i]}, " + 
            $"{Video.AuthorProperty[i]}, " +
            $"{Video.LengthProperty[i]}");
            Console.WriteLine(" ");

            for (int j = 0; j < 3; j ++) {
                Console.WriteLine($"     {Video.Comment.ComNameProperty[j + (i * 3)]}:");
                Console.WriteLine($"     \"{Video.Comment.ContentProperty[j + (i * 3)]}\" ");

            }
            Console.WriteLine(" ");
        }
        Console.WriteLine("Number of comments: " + Video.Comment.CommentNum());

    }

    class Video {

    private static List<string> _title = new List<string>() {
        "How Hot Can It Get?",
        "Jesus Heals a Man Born Blind",
        "The Cold War - Oversimplified",
    };

    public static List<string> TitleProperty {
        
        get {
            return _title;
        }
    }

    private static List<string> _author = new List<string>() {
        "Vsauce",
        "The Church of Jesus Christ of Latter-Day Saints",
        "OverSimplified",
    };

    public static List<string> AuthorProperty {
            
            get {
                return _author;
            }
        }

    private static List<string> _length = new List<string>() {
        "10:03",
        "7:48",
        "16:04",
    };

    public static List<string> LengthProperty {
        
        get {
            return _length;
        }
    }

    public class Comment {

        private static List<string> _namesFirst = new List<string>() {

            "YouTubeCommenter007",
            "Rick",
            "Video Author's Mother",
            "Probably a Spam Account",
            "Mr. Robert",
            "Zoboomafoo",
            "Shameless Self Promoter",
            "A Person Who Knows the Date",
            "Brigham Young"
                
        };

        public static List<string> ComNameProperty {
        
        get {
            return _namesFirst;
        }
    }

        private static List<string> _Content = new List<string>() {

            "This is a neat video.",
            "Never gonna give you up",
            "Good job, Sweetie!",
            "You want free gift cards?",
            "This is a very neat video.",
            "Animal Junction's the place to be!",
            "Nice video! Mine are better!",
            "Click 'like' if you're listening in 2023",
            "Nature is the glass reflecting God..."

        };

        public static List<string> ContentProperty {
        
        get {
            return _Content;
        }
    }

        public static List<string> Title {
            
        get
        {
            return _title;
        }
    }
        
        public static int CommentNum() {

            return _Content.Count;
    }
}
}
}
