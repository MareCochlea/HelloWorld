String name;
Array scores;
scores = new int[20];

Console.Title = "My First Program";

Console.WriteLine("Who are you???");

// The command below gets your name and sends it to the console.
name = Console.ReadLine();

Console.WriteLine("Oh, hello "+name+"!");

Console.ReadLine();

Console.WriteLine(scores);

Console.WriteLine("Press any key when you're ready to begin.");
Console.ReadKey(true);