using System;
using System.IO;
using System.Text;

namespace E_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                string str = "Hello World!";
                byte[] strInBytes = Encoding.ASCII.GetBytes(str);
                fs.Write(strInBytes, 0, strInBytes.Length);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Errors! ex");
            }
            finally
            {
                fs.Close();
            }

            using (Stream readdingStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read)) 
            {
                byte[] temp = new byte[readdingStream.Length];
                ASCIIEncoding encoding = new ASCIIEncoding();

                int len = 0;
                while ((len = readdingStream.Read(temp, 0, temp.Length)) > 0)
                {
                    string str = Encoding.ASCII.GetString(temp, 0, len);
                    Console.WriteLine(str);
                }
            }

        }
    }
}
