namespace Task_2
{
    public class Student
    {
        public string Surname { get; set; } = string.Empty;

        public Student() : this("")
        {
            
        }

        public Student(string surname)
        {
            Surname = surname;
        }

        public static Student Enter()
        {
            Console.Write("Введіть прізвище студента: "); 
            return new Student(Console.ReadLine());
        }
    }
}