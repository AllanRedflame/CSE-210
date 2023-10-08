using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.Clear();
        Scripture.Display();
        Word.Hide();

    }
}

static class Scripture {

    private static string _Reference = Reference.Scripture();
    private static List<string> _Text = new List<string>() {
        "Trust", "in", "the", "Lord", "with", "all", 
        "thine", "heart;", "and", "lean", "not", 
        "unto", "thine", "own", "understanding.",
        "In", "all", "thy", "ways", "acknowledge", 
        "him", "and", "he", "shall", "direct", "thy",
        "paths."
        };



    public static string Display() {
        string Str = string.Join(" ", _Text);
        return Str;
    }

    public static List<string> returnList() {
        return _Text;
    }
    };


 
static class Reference {

    private static string _Book = "Proverbs";
    private static int _Chapter = 3;
    private static int _BeginVerse = 5;
    private static int _EndVerse = 6;

    public static string Scripture() {
        return $"{_Book} {_Chapter}:{_BeginVerse}-{_EndVerse}";
    }

}

class Word {
    static Random random = new Random();

    //List<string> Verselist {get; set;}
    static List<string> FinishedList = new List<string>();     
    public static void Hide() {
        List<string> VerseList = Scripture.returnList();
        StringBuilder sb = new StringBuilder();

        int Counter = 0;
        for (int a = 0; a <= 5; a++) {
            for (int i = 0; i < VerseList.Count; i++) {
            int Num = random.Next(0, VerseList[i].Length);
            int NumTwo = random.Next(0, VerseList[i].Length);
            int NumThree = random.Next(0, VerseList[i].Length);
            int NumFour = random.Next(0, VerseList[i].Length);

                for (int j = 0; j < VerseList[i].Length; j++) {
                    if (Counter > 4) {
                        sb.Append('_');
                    }
                    else{
                        if (j == Num && Counter > 0) {
                            sb.Append('_');
                        }
                        
                        else if (j == NumTwo && Counter > 1) {
                          sb.Append('_');
                        }
                        else if (j == NumThree && Counter > 2) {
                            sb.Append('_');
                        }
                        else if (j == NumFour && Counter > 3) {
                            sb.Append('_');
                            
                        }
                        else {
                            sb.Append(VerseList[i][j]);
                        }
                        }

                }
                sb.Append(' ');

                //Janky way of adding lines so the user can't see the previous scripture as well
                StringBuilder output = sb;

                Console.Clear();
                Console.WriteLine(Reference.Scripture());
                Console.WriteLine($"{output}");

        }
            string UserInput = Console.ReadLine();
            if (UserInput == "quit") {
                Console.WriteLine("Ending program...");
                break;
            }
            else {
                Counter ++;
                continue;
            }
        }
    }}
