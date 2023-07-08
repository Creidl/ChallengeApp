using ChallengeApp;

Supervisor user1 = new Supervisor();

Console.WriteLine("Program do oceny Supervisora");
Console.WriteLine("-----===============-------");

while(true)
{
    Console.WriteLine("  Podaj ocenę.");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    
    try
    {
        user1.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception cached: {e.Message}");
    }
    
} 

Statistics statistics = user1.GetStatistics(); 

Console.WriteLine($"\nMaksymalna ocena: {statistics.Max}; Minimalna ocena: {statistics.Min}; Średnia ocena: {statistics.AverageLetter}");