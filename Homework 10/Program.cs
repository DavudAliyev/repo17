using System;
using System.Linq;

namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hikmet", "Abbas", "Nermin", "Nergiz", "Adil" };
            byte[] ages = { 14, 25, 32 };
            string opt;
            do
            {
                Console.WriteLine("1. Butun telebelere bax");
                Console.WriteLine("2. Telebe elave et");
                Console.WriteLine("3. Telebe uzerinde axtaris et");
                Console.WriteLine("4. Secilmis nomreli telebeni goster");
                Console.WriteLine("5. Secilmis nomreli telebeni sil");
                Console.WriteLine("0. Cix");

                Console.WriteLine("\nEmeliyyati secin: ");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine(names[i]);
                        }
                        break;
                    case "2":
                        string name;
                        bool hasOnlyLetter = true;
                        
                        do
                        {
                            Console.WriteLine("Telebe adini daxil edin");
                            name = Console.ReadLine();
                        } while (!hasOnlyLetter);
                        
                        Array.Resize(ref names, names.Length+1);
                        names[names.Length-1] = name;                  
                        break;
                    case "3":
                        Console.WriteLine("Elementi daxil edin: ");
                        string text= Console.ReadLine();
                        string text1 = "";

                        for (int i = 0;i<names.Length;i++)
                        {
                            if (names[i].Contains(text))
                            {
                                text1 += names[i];
                                Console.WriteLine(text1);
                            }
                        }                   
                        break;
                    case "4":
                        Console.WriteLine("Indexi daxil et: ");
                        string indexStr=Console.ReadLine();
                        try
                        {
                            int index = Convert.ToInt32(indexStr);
                            Console.WriteLine($"name: {names[index]} - age: {ages[index]}");
                        }
                        catch
                        {
                            Console.WriteLine("Xeta bas verdi");
                        }
                        break;
                    case "5":
                        break;

                }
            }
            while (opt != "0");
        } 

        static bool HasOnlyLetter(string str)
        {
            if (String.IsNullOrWhiteSpace(str)) return false;

            for (int i = 0;i < str.Length;i++)
            {
                if (!char.IsLetter(str[i])) return false;
            }
            return true;
        }
    }
}
