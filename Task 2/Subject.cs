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

        public static Subject Enter()
        {
            Console.Write("Введіть назву предмета: ");
            return new Subject(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Предмет: {Name}.\n";
        }
    }
}
