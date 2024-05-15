namespace practic
{
    internal class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SchoolName { get; set; }
        public Student(string name, string lastName, int age, string schoolName)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            SchoolName = schoolName;
        }

        public override string ToString()
        {
            return $"{Name} {LastName} {Age} y.o {SchoolName}";
        }
    }
}
