using ChallengeApp;

Employee user1 = new Employee("Sam", "Serious");

user1.AddGrade(double.MaxValue);
user1.AddGrade(2.09f);
user1.AddGrade(3.33);
user1.AddGrade("ab");
user1.AddGrade("12");
user1.AddGrade('k');
user1.AddGrade(123.45);

Statistics statistics = user1.GetStatistics();

Console.WriteLine($"\n\timię: {user1.Name}\n\tnazwisko: {user1.Surname} ");
Console.WriteLine($"\nMaksymalna ocena: {statistics.Max}; Minimalna ocena: {statistics.Min}; Średnia ocen: {statistics.Average:N2}");