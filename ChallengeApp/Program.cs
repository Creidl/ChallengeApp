using ChallengeApp;

Employee user1 = new Employee("Sam", "Serious");

user1.AddGrade(1);
user1.AddGrade(2);
user1.AddGrade(3);

Statistics statistics = user1.GetStatistics();

Console.WriteLine($"imię: {user1.Name} nazwisko: {user1.Surname} ");
Console.WriteLine($"Maksymalna ocena: {statistics.Max} Minimalna ocena: {statistics.Min} Średnia ocen: {statistics.Average:N2}");