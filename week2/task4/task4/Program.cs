using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
           if (!File.Exists(@"C:\Users\Батыр\git\PP2\week2\task4\task4.txt"))
            {
                using (FileStream fs = new FileStream(@"C:\Users\Батыр\git\PP2\week2\task4\task4.txt", FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write("Hello World!");
                    }
                }
            }
           //создаю директори под именем Batko для того чтобы отправитьтекстовый документ 
            if (!Directory.Exists(@"C:\Users\Батыр\git\PP2\week2\task4\Batko"))
            {
                Directory.CreateDirectory(@"C:\Users\Батыр\git\PP2\week2\task4\Batko");
            }
            //задаю последовательность 
            string TheFirstFile = Path.Combine(@"C:\Users\Батыр\git\PP2\week2\task4", "task4.txt");
            string TheSecondFile = Path.Combine(@"C:\Users\Батыр\git\PP2\week2\task4\Batko", "task4.txt");


            //отправляем наш текстовик в нашу папку
            if (!File.Exists(@"C:\Users\Батыр\git\PP2\week2\task4\Batko\task4.txt"))
           
            {

                File.Move(@"C:\Users\Батыр\git\PP2\week2\task4\task4.txt", @"C:\Users\Батыр\git\PP2\week2\task4\Batko\task4.txt");

            }

        }

    }

}