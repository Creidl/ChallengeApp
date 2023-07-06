using ChallengeApp;

Employee user1 = new Employee("Sam", "Serious");

user1.AddGrade(2.09f);
user1.AddGrade(3.33);
user1.AddGrade("12");

List<Statistics> statistics = new List<Statistics>();
statistics.Add(user1.GetStatistics()); // tu zastosowano foreach
statistics.Add(user1.GetStatisticsWithFor());
statistics.Add(user1.GetStatisticsWithDoWhile());
statistics.Add(user1.GetStatisticsWithWhile());

Console.WriteLine($"\n\timię: {user1.Name}\n\tnazwisko: {user1.Surname} ");
foreach(Statistics stat in statistics)
{
    Console.WriteLine($"\nMaksymalna ocena: {stat.Max}; Minimalna ocena: {stat.Min}; Średnia ocen: {stat.Average:N2}");
}