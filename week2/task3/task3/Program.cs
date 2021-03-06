﻿using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task3

{
    class Program
    {
        //указываю путь к папке в которой содержатся наши файлы
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Батыр\git\PP2\week2");
            PrintInfo(dir, 0);
            Console.ReadKey();
        }
        //задаю условие функции для того чтобы вывести наши файлы в консоль
        static void PrintInfo(FileSystemInfo fsi, int k)
        {
           string s = new string(' ', k);
            Console.WriteLine(s + fsi.Name);
            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for (int i = 0; i < arr.Length; i++)
                {
                    PrintInfo(arr[i], k + 5);
                }
            }
        }

    }

}