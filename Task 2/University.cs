namespace Task_2
{
    public class University
    {
        public string Name { get; set; } = string.Empty;
        public LinkedList<Group> Groups { get; set; } = new();
        public University(string name)
        {
            Name = name;
        }

        public University() : this("")
        {
            
        }
    }
}
