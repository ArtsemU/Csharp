using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ghovard", "Volovic", Faculty.BIOLOGICALENGINEERING);
            Student student2 = new Student("Kaly", "Penny", Faculty.LITERATURE);
            student1.PrintName();
            Console.WriteLine(student1.Equals(student2));

            try
            {
                Student student3 = new Student("", "Test", Faculty.MATH);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error!!!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Error!!!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("____");
            }

            Professor prof1 = new Professor("Leonard", "Hofstadter", Faculty.CIVILENGINEERING);
            Professor prof2 = new Professor("Sheldon", "Cooper", Faculty.CIVILENGINEERING);
            prof1.PrintName();
            Console.WriteLine(prof1.Equals(prof2));

            HeadOfDepartment head1 = new HeadOfDepartment("Richard", "Feynman", Faculty.PHYSICS);
            HeadOfDepartment head2 = new HeadOfDepartment("Carl", "Sagan", Faculty.PHYSICS);
            Console.WriteLine(head1.Equals(prof2));
            Console.WriteLine(head1.Equals(student2));
            Console.WriteLine(head1.Equals(head2));
            head1.PrintName();

            Console.ReadLine();
        }
    }
}
