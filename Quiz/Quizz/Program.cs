using System;

class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        int replies;
        string[] questions = new string[]
        {
            "Sual 1 Nokia mobil telefonu hansi ölkənin brendidir",
            "Sual 2 Bunlardan hansi Xezri adlanir?",
            "Sual 3 Sahesine gore ABS-in en boyuk stati hansidir?",
            "Sual 4 XX esrde nece dunya muharibesi bash verib?",
            "Sual 5 Radioaktivlik kim terefinden kesf olunmusdur?",

            "Sual 6 Dieqo Maradona Italiyanin hansi futbol  klubundaki uğurundan sonra taninmaga başladi?",
            "Sual 7 Şusa şeheri ne zaman işğaldan azad edilmisdir?",
            "Sual 8 Çinlilerin milli oyunu sayilan idman növu hansidir?",
            "Sual 9 <Matrixs> filiminde Neo rolunu oynuyan aktyor kimdir?",
            "Sual 10 <<Harry Potter>> romanlar seriyasinin yaziçisi kimdin?"
        };

        string[][] answers = new string[][]
        {
            new string[] { "Malaziya","Yaponiya","Finlandiya","Çin" },
            new string[] { "Cenub kuleyi", "Serq kuleyi", " Simal kuleyi", "Qerb kuleyi" },
            new string[] { "Texas", "Koliforniya", "Alyaska", "Arziona" },
            new string[] { "1", "0", "2","4" },
            new string[] { "Christian Doppler", "Hugo Zaparowicz", "Henry Bacruerel", "Alfred Merz"},

            new string[] {  "Milan", "Roma", "Napoli", "Yuventus" },
            new string[] { "10 noyabr", "7 noyabr", "8 noyabr", "1 noyabr"},

            new string[] { "Voleyboll", "Badminton", "Stolustu tennis", "Futbol"},

            new string[] { "Brend Pitt", "Tom Kruz", "Kianu Rivz", "Tom Henks"},
            new string[] {  "Hans Andersen", "Mark Tven", "C.K.Rounlinq", "R.Kiplinq" }
        };

        Random rand = new Random();

        for (int i = 0; i < questions.Length; i++)
        {

            Console.Clear();
            Console.WriteLine(questions[i]);

            string[] mixedAnswers = MixQues(answers[i], rand);

            for (int j = 0; j < mixedAnswers.Length; j++)
            {
                char option = (char)('a' + j);
                Console.WriteLine($"{option}{mixedAnswers[j]}");
            }

            Console.WriteLine("Enter the answer(a,b,c,d): ");

            string userAnswers = Console.ReadLine().ToLower();

            if (userAnswers == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Duzgun cavab. ");
                totalScore += 10;

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sehv cavab!!!");

            }
            Console.ResetColor();
            Console.WriteLine("Davam etmek ucun ENTER basin. ");
            Console.ReadLine();

        }



        Console.WriteLine($"Tebrikler Imtahani bitirdiniz Topladiginiz Xal {Math.Max(totalScore, 0)}");



    }

    static string[] MixQues (string[] arr, Random rand)
    {
        string[] mixedArray = arr.Clone() as string[];

        for (int i = 0; i < mixedArray.Length; i++)
        {
            int randIndex = rand.Next(i, mixedArray.Length);
            string temp = mixedArray[i];
            mixedArray[i] = mixedArray[randIndex];
            mixedArray[randIndex] = temp;
        }

        return mixedArray;


    }

}
