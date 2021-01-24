using System;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(25, "Fatma Uğurlu");
            students.Add(32, "Emre Pelvan");
            students.Add(48, "Ayşe Bedel");
            students.Add(76, "Gözde Şimşek");
            students.Add(102, "Elif Kuzoluk");

            Console.WriteLine("Öğrencilerin Lİstesi");

            for (int i = 0; i < students.items1.Length; i++)
            {
                Console.WriteLine("Öğrenci Numarası: " + students.items1[i] + " " + "Öğrenci Adı: " + students.items2[i]);
            }


        }
    }
}
