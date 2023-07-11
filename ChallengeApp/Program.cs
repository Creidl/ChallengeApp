using ChallengeApp;

EmployeeInMemory user1 = new EmployeeInMemory("John","Malkovich");
EmployeeInFile user2 = new EmployeeInFile("Sylwester", "Stalone");

Console.WriteLine("Program do oceny pracownika");
Console.WriteLine("-----=================-----");

user1.GradeAdded += EmployeeGradeAdded;
user2.GradeAdded += EmployeeGradeAdded;

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

Console.WriteLine("\n\tPróba dodania oceny do drugiego usera");
user2.AddGrade(99);
statistics = user2.GetStatistics();
Console.WriteLine($"\nMaksymalna ocena: {statistics.Max}; Minimalna ocena: {statistics.Min}; Średnia ocena: {statistics.AverageLetter}");

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("dodano ocenę");
}