using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1.Using LINQ, write a function that returns all words that contain the substring “th” from a list .
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };

            //List<string> words = new List<string>(){ "the", "bike", "this", "it", "tenth","mathematics" };
            //var wordsThatContainTH = words.Where(w => w.Contains("th"));
            //foreach(var word in wordsThatContainTH)
            //{
            //    Console.WriteLine(word);
            //}


            ///2.Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            //var noDuplicates = names.Distinct();

            //foreach (var name in noDuplicates)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

            ///3. Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student. 
            //The function should take in a list of strings of grades -------  List<string> classGrades = new List<string>()

            //List<string> classGrades = new List<string>()
            //    {

            //        "80,100,92,89,65",
            //        "93,81,78,84,69",
            //        "73,88,83,99,64",
            //        "98,100,66,74,55"
            //    };

            //var gradeResults = classGrades.Select(x => x.Split(',')).Select(x => Array.ConvertAll(x, double.Parse)).Select(x => (x.Sum() - x.Min()) / (x.Count() - 1)).Average();
            //Console.WriteLine(gradeResults);
            //Console.ReadLine();

            ///4. Write a function that takes in a string of letters (i.e. “Terrill”) and returns an alphabetically ordered string corresponding to the letter frequency (i.e. "E1I1L2R2T1")

            //string someString = "Megan";
            //var newString = someString.ToUpper().GroupBy(x => x).Select(x => x.Key + "" + x.Count()).OrderBy(x => x).ToArray();
            //StringBuilder newbuilder = new StringBuilder();
            //foreach(string value in newString)
            //{
            //    newbuilder.Append(value);
            //}

            //newbuilder.ToString();
            //Console.WriteLine(newbuilder);
            //Console.ReadLine();

        }

    }
}



