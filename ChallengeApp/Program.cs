using ChallengeApp;

EmployeeInFile user1 = new EmployeeInFile("John","Malkovich");

Console.WriteLine("Program do oceny pracownika");
Console.WriteLine("-----=================-----");

user1.AddGrade(33);
//user1.AddGrade(21);
/*while(true)
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
*/
Statistics statistics = user1.GetStatistics(); 

Console.WriteLine($"\nMaksymalna ocena: {statistics.Max}; Minimalna ocena: {statistics.Min}; Średnia ocena: {statistics.AverageLetter}");