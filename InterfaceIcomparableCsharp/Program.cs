using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\cliente\Documents\denior pessoal2\Lista.txt";
            try
            {
                using  (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    list.Sort();

                    foreach (string srt in list)
                    {
                        Console.WriteLine(srt);
                    }
                }
            }
            catch (IOException e){
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
