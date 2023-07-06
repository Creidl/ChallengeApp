using ChallengeApp;

Employee user1 = new Employee("Sam", "Serious");

user1.AddGrade(2.09f);
user1.AddGrade(3.33);
user1.AddGrade("12");

Statistics statistics = user1.GetStatistics(); 

Console.WriteLine($"\n\timię: {user1.Name}\n\tnazwisko: {user1.Surname} ");
Console.WriteLine($"\nMaksymalna ocena: {statistics.Max}; Minimalna ocena: {statistics.Min}; Średnia ocen: {statistics.Average:N2}");