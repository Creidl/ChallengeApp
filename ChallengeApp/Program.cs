using ChallengeApp;

Employee user1 = new Employee("Sam", "Serious");

Console.WriteLine("Program do oceny pracownika");
Console.WriteLine("-----===============-------");

while(true)
{
    Console.WriteLine("\n  Podaj ocenę.");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    else
    {
        user1.AddGrade(input);
    }
} 

Statistics statistics = user1.GetStatistics(); 

Console.WriteLine($"\n\timię: {user1.Name}\n\tnazwisko: {user1.Surname} ");
Console.WriteLine($"\nMaksymalna ocena: {statistics.Max}; Minimalna ocena: {statistics.Min}; Średnia ocena: {statistics.AverageLetter}");