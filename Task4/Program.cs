namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.Id = 1;
            std1.Name = "John Doe";
            std1.Age = 22;
            std1.Phone = "123-456-7890";
            std1.Gender = "Male";
            std1.Major = "Computer Science";
            std1.GPA = 3.8f;
            Console.WriteLine(std1.getStudentInfo());
            Console.WriteLine("--------------------------------------------------");
            Student std2 = new Student();
            std2.Id = 2;
            std2.Name = "Jane Smith";
            std2.Age = 20;
            std2.Phone = "987-654-3210";
            std2.Gender = "Female";
            std2.Major = "Artificial Intelligence";
            std2.GPA = 3.7f;
            Console.WriteLine(std2.getStudentInfo());
        }
    }
}
