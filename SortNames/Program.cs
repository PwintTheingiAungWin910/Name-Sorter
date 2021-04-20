using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNames
{
    class Program
    {
        static void Main(string[] args)
        {
		
			string fileName = "C:\\Users\\PwintTheingiAW\\source\\repos\\SortNames\\SortNames\\unsorted-names-list.txt";
			string[] incomingNames = System.IO.File.ReadAllLines(fileName);
			var sortedNames = getSortedNames(incomingNames);

			string outputFileName = "C:\\Users\\PwintTheingiAW\\source\\repos\\SortNames\\SortNames\\sorted-names-list.txt";
			System.IO.File.WriteAllLines(outputFileName, sortedNames);

			foreach (string name in sortedNames)
			{
				System.Console.WriteLine(name);
			}
			Console.ReadLine();
		}

		public static string[] getSortedNames(string[] names)
		{
			var sortKey = names.Select(getFormattedName).ToArray();
			System.Array.Sort(sortKey, names);
			return names;
		}

		private static string getFormattedName(string name)
		{
			var names = name.Split(' ');
			var length = names.Length;
			var formattedName = names[length - 1];
			for (int i=0; i < name.Length - 1; i++)
            {
				formattedName += ' ' + name[0];
			}
			return formattedName;
		}
	}
}
