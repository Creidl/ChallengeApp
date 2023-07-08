namespace ChallengeApp
{
    public abstract class Person
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public char Sex { get; protected set; }

        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
    }
}
