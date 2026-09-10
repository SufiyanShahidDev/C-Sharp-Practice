namespace studentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
                Student student1 = new Student();
                student1.name = "Roghani";
                student1.age = 16;
                student1.course = "Web Development";

                Console.WriteLine(student1.name);
                Console.WriteLine(student1.age);
                Console.WriteLine(student1.course);
            
        }
    }

}

    

