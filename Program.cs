using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutout
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("test_file.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 0; i < 10; ++i)
            {
                file.WriteByte((byte)i);
            }

            file.Position = 0;
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(file.ReadByte() + " ");
            }
            file.Close();
            Console.ReadKey();
        }
    }
}
