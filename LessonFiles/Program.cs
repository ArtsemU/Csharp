using System;
using System.IO;

namespace LessonFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let play with FILES!!!");

            // получим имена и свойства всех дисков
            DriveInfo[] drivers = DriveInfo.GetDrives();

            foreach (var driver in drivers)
            {
                Console.WriteLine($"Driver name: {driver.Name}");
                Console.WriteLine($"Driver total free space: {driver.TotalFreeSpace/1000000}");
                Console.WriteLine($"Driver total size: {driver.TotalSize/1000000}");
                Console.WriteLine($"Driver % free space: {(double)(driver.TotalFreeSpace/ driver.TotalSize)}");
                Console.WriteLine($"Driver format: {driver.DriveFormat}");
                Console.WriteLine($"Driver type: {driver.DriveType}");
                Console.WriteLine($"Driver Volume label: {driver.VolumeLabel}");
                Console.WriteLine($"Driver format: {driver.DriveFormat}");
                Console.WriteLine("___________________");
            }
            string dirName = "H:\\";
            string newDir = "TestDir";
            string newCatalog = dirName + newDir;
            Console.WriteLine(Directory.Exists(newCatalog));
            if (!Directory.Exists(newCatalog))
            {
                Directory.CreateDirectory(newCatalog);
            }
            DirectoryInfo dirInfo = new DirectoryInfo(newCatalog);
            Console.WriteLine($"Dir full name: {dirInfo.FullName}");
            Console.WriteLine($"Dir name: {dirInfo.Name }");
            Console.WriteLine($"Dir parent: {dirInfo.Parent }");
            Console.WriteLine($"Dir attributes: {dirInfo.Attributes}");
            Console.WriteLine($"Dir created: {dirInfo.CreationTime }");

            //File.Create(newCatalog + "testName.txt");


            Directory.Delete(newCatalog);
            Console.WriteLine(Directory.Exists(newCatalog));
            Console.ReadLine();
        }
    }
}
