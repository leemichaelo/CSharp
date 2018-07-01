using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Jaggaed Array
            int[][] jaggedArray = BuildJaggedMultiplicationTable(3);

            foreach (int[] row in jaggedArray)//Print the array
            {
                foreach (int cell in row)
                {
                    System.Console.Write(cell);
                }
                System.Console.WriteLine();
            }

            //Print Multidimensional Array
            int[,] multiSheet = BuildMultidimensionalMultiplicationTable(3);
            for (int i = 0; i < multiSheet.GetLength(0); i++)
            {
                for (int j = 0; j < multiSheet.GetLength(1); j++)
                {
                    Console.Write(multiSheet[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Build Jagged Array
        public static int[][] BuildJaggedMultiplicationTable(int maxFactor)
        {
            int[][] arrayToReturn = new int[maxFactor + 1][];
            for (int i = 0; i < arrayToReturn.Length; i++)
            {
                arrayToReturn[i] = new int[maxFactor + 1];
                for (int j = 0; j < arrayToReturn[i].Length; j++)
                {
                    arrayToReturn[i][j] = i * j;
                }
            }
            return arrayToReturn;
        }

        public static int[,] BuildMultidimensionalMultiplicationTable(int maxFactor)
        {
            int[,] arrayToReturn = new int[maxFactor + 1, maxFactor + 1];
            for (int i = 0; i < arrayToReturn.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToReturn.GetLength(1); j++)
                {
                    arrayToReturn[i, j] = i * j;
                }
            }
            return arrayToReturn;
        }

        public static List<int> GetPowersOf2(int power)
        {
            List<int> listToReturn = new List<int>();
            for (int i = 0; i < power + 1; i++)
            {
                listToReturn.Add(i * i);
            }
            return listToReturn;
        }

        //Adding to List
        public static class MathHelpers
        {
            public static List<int> GetPowersOf2(int power)
            {
                List<int> listToReturn = new List<int>();
                for (int i = 0; i < power + 1; i++)
                {
                    listToReturn.Add((int)System.Math.Pow(2, i));
                }
                foreach (var item in listToReturn)
                {
                    System.Console.WriteLine(item);
                }
                return listToReturn;
            }
        }

    }
}
