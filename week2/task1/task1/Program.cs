﻿using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace task1

{

    class Program

    {
        static void Main(string[] args)

        {

            //создал переменную Pol типа bool
           bool Pol = true;
           //считываю данные из файла
           using (FileStream fs = new FileStream(@"C:\Users\Батыр\git\PP2\week2\task1\task.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    //создаю переменную text типа string и сохраняю все элементы файла в texte. 
                    //Потом эту переменную проверяю через функцию типа bool на палиндромность и записываю ответ в переменной типа bool
                    //если text палиндром то true, а если не палиндром то false
                    string text = sr.ReadLine();
                    Pol = Polindrome(text);
                }

            }
            //записали результат на другой файл
            using (FileStream fs2 = new FileStream(@"C:\Users\Батыр\git\PP2\week2\task1\batik.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs2))

                {
                    //здесь через условие проверяем text палиндром или нет. 
                    //Если text палиндром то выводим "Yes", а если нет то выводим "No" 
                   if (Pol == false)
                   {
                        sw.Write("No");
                   }
                    else
                    {
                        sw.Write("Yes");

                    }

                }

            }

        }
        private static bool Polindrome(string text)

        {
            //создаю цикл чтобы пробежаться по элементам массива типа char
            for (int i = 0; i < (text.Length) / 2; i++)
           {
               //здесь через условие проверяем 1 элемент массива и последний элемент массива. 
                //Если они одинаковы то переходим на следующий элемент. А если они не одинаковые то выводим false и выходим из функции
               if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
      }

    }

}