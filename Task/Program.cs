//Variant 12
namespace Task;
public static class Program
{
    private const string FILE_PATH = "data.bin";

    public static void Main()
    {
        while(true)
        {
            try
            {
                int operation = ChooseOperation();
                switch(operation)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            EnterToFile();
                            break;
                        }
                    case 2:
                        {
                            ShowFromFile();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Не відома операція. Спробуйте ще раз.");
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
        }
    }

    private static string EnterStudent()
    {
        string result = string.Empty;
        Console.Write("Введіть прізвище студента: "); result += Console.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            int mark = EnterMark($"предмету {i + 1}");
            result += $"*{mark}";
        }
        return result;
    }

    private static int EnterMark(string subject)
    {
        Console.Write($"Введіть оцінку для {subject}: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        while(mark > 5 || mark < 1)
        {
            Console.Write("Оцінка може бути від 1 по 5. Спробуйте ще: "); 
            mark = Convert.ToInt32(Console.ReadLine());
        }
        return mark;
    }

    private static int EnterCount()
    {
        Console.Write("Введіть кількість студентів: ");
        int count = Convert.ToInt32(Console.ReadLine());
        while(count <= 0)
        {
            Console.Write("Кількість має бути більше 0. Спробуйте ще: "); 
            count = Convert.ToInt32(Console.ReadLine());
        }
        return count;
    }

    private static int ChooseOperation()
    {

        Console.WriteLine("Виберіть операцію: ");
        Console.WriteLine("0-Вихід.");
        Console.WriteLine("1-Ввести данні.");
        Console.WriteLine("2-Вивести з файлу.");
        Console.Write(">>> ");
        int operation = Convert.ToInt32(Console.ReadLine());
        return operation;
    }

    private static void EnterToFile()
    {
        using BinaryWriter writer = new(File.Open(FILE_PATH, FileMode.Create));
        int count = EnterCount();
        for (int i = 0; i < count; i++)
        {
            string student = EnterStudent();
            writer.Write(student);
        }
    }
    private static void ShowFromFile()
    {
        if(File.Exists(FILE_PATH))
        {
            using BinaryReader reader = new(File.Open(FILE_PATH, FileMode.Open));
            int count = 0;
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                try
                {
                    count++;
                    string student = reader.ReadString();
                    ProcessStudent(student);
                }
                catch(Exception)
                {
                    break;
                } 
            }
        }
        else
        {
            Console.WriteLine("Файлу не існує");
        }
    }

    private static void ProcessStudent(string student)
    {
        Console.WriteLine(student);
    }
}