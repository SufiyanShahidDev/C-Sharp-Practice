namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.name = "Test";
            student1.age = 14;
            student1.course = "Web Development";
            student1.marks = 89;

            student1.ShowData();
        }
                   
    }
}
