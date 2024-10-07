namespace Task_2
{
    public class Group
    {
        public string Name { get; set; } = string.Empty;
        public readonly LinkedList<Student> Students;
        public readonly LinkedList<Subject> Subjects;
        public readonly LinkedList<Mark> Marks;

        public Group()
        {
            Students = new LinkedList<Student>();
            Subjects = new LinkedList<Subject>();
            Marks = new LinkedList<Mark>();
        }

        public Group(IEnumerable<Student> students, IEnumerable<Subject> subjects) : this()
        {
            Students = new(students);
            Subjects = new(subjects);
        }
    }
}
