using System;
using System.Collections.Generic;
using System.Text;
//We will Implement all that in the Udemy Begineer course
//It Would All be mdouled in diffrent modules and its types
namespace Begineer
{
    
    class Program : primitive_data_types
    {
        static int N = 3;
        public struct PersonName //Implementaion of structure
        {
            public string FirstName;
            public string MiddleName;
            public string LastName;
        }
        public int Fibonachi(int n) //Implementation of if else statements
        {
            if (n == 1)
            {
                return 0;
            }
            else
            {
                return (Fibonachi(n - 1) + Fibonachi(n - 2));
            }
        }
        public static void College_using_strings()//Strings Application
        {
            var CollegeName = "JECRC";
            var CollegeAddress = "Sitapura,Jaipur";
            var FullCollege = CollegeName + " , " + CollegeAddress;
        }
        public static void AgeGroup(int age)//Implementaion of Switch
        {
            switch (age)
            {
                case var expression when (0 < age && age < 1):
                    Console.WriteLine("New Born");
                    break;
                case var expression when (1 <= age && age < 14):
                    Console.WriteLine("Children");
                    break;
                case var expression when (14 <= age && age < 24):
                    Console.WriteLine("Youth");
                    break;
                case var expression when (24 <= age && age < 64):
                    Console.WriteLine("Adult");
                    break;
                case var expression when (65 < age):
                    Console.WriteLine("Senior Citizen");
                    break;
                default:
                    Console.WriteLine("Enter Correct Values");
                    break;
            }
        }
        public static int Exponent_for(int num)//Implementation of For Loop
        {
            int exponent = 1;
            for (var i = 1; i < num; i++)
            {
                exponent = exponent * i;
            }
            return exponent;
        }
        public static int Exponent_foreach(int num)//Implemenation of ForEach Loop
        {
            int exponent = 1;
            List<int> numberLists = numberList(num);
            foreach (int number in numberLists)
            {
                exponent = exponent * number;
            }
            return exponent;
        }
        public static List<int> numberList(int n)//Implementation of list
        {
            List<int> numberlist = new List<int>() { 1 };

            for (int i = 2; i <= n; i++)
            {
                numberlist.Add(i);
            }
            return numberlist;

        }
        public static int Exponent_while(int num)//Implemenation of while Loop
        {
            int exponent = 1;
            while (num > 1)
            {
                exponent = exponent * num;
                num--;
            }
            return exponent;
        }
        public static void Date_Random()//Implemnenation of random and date and random
        {
            DateTime start = DateTime.Now;
            Random gen = new Random();
            int randomyear = gen.Next(1900, start.Year);
            int randommonth = gen.Next(1, 12);
            int randomday;
            switch (randommonth)
            {
                case 2:
                    if (randomyear % 4 == 0)
                    {
                        randomday = gen.Next(1, 29);
                    }
                    else
                        randomday = gen.Next(1, 28);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    randomday = gen.Next(1, 30);
                    break;
                default:
                    randomday = gen.Next(1, 31);
                    break;
            }
            DateTime geneatedDate = new DateTime(randomyear, randommonth, randomday);
            Console.WriteLine("Random Date {0}", geneatedDate);

        }
        public static void Print_Transpose_matrix(int[,] matrix)//Implemetaion of Array and only take square matrix
        {
            int[,] matrixB = new int[N, N];
            int i, j;
            Console.WriteLine("Transpose of the Matrix is");
            for(i=0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {

                    matrixB[i, j] = matrix[j, i];
                }
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine(matrixB[i, j]);
                }
            }
        }
        public static void stringBuilder()//Implemenation of String-Builder
        {
            var strBuild = new StringBuilder();
            strBuild.Append('*', 10);
            Console.WriteLine("Print 10 star:{0}",strBuild);
            strBuild.Replace('*', 'N');
            Console.WriteLine("Print 10 N by replace:{0}", strBuild);
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}

