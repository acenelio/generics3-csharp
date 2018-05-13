using System;
using System.IO;
using System.Collections.Generic;
using Course.Entities;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<Contestant> list = new List<Contestant>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] v = sr.ReadLine().Split(',');
                        WrittenTest wt = new WrittenTest(int.Parse(v[1]), int.Parse(v[2]));
                        PracticalTest pt = new PracticalTest(int.Parse(v[3]), int.Parse(v[4]));
                        list.Add(new Contestant(v[0], wt, pt));
                    }
                    list.Sort();
                    Console.WriteLine("Contest ranking:");
                    foreach (Contestant contestant in list) {
                        Console.WriteLine(contestant);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
