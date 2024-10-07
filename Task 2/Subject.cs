namespace Task_2
{
    public class Subject
    {
        public string Name { get; set; } = string.Empty;

        public Subject(string name)
        {
            Name = name;
        }

        public Subject() : this("")
        {
            
        }

        public static Subject Enter(string name)
        {
            Console.Write("Введіть назву предмета: ");
            return new Subject(name);
        }
    }
}
