/*
AUTHOR: Richard Soria
DESCR:  Program that generates a truth table using binary bits
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truthTableGenerator
{
    class TruthTableGenerator
    {
        public static int convertBoolToBinary(bool val)
        {
            //if true returns 1 if false returns 0
            return val ? 1 : 0;
        }
        public static void GenerateTable()
        {
            bool cbit, bbit, abit;

            string format = "[{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|";

            Console.WriteLine(format, "C-in", "B", "A", "Sun", "C-out");
            Console.WriteLine("---------------------------------------");

            cbit = false;
            bbit = false;
            abit = false;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit), 
                convertBoolToBinary(abit), convertBoolToBinary( (abit ^ bbit) ^ cbit), 
                convertBoolToBinary( (abit & bbit) | (bbit & cbit) | (abit & cbit)));

            cbit = true;
            bbit = false;
            abit = false;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit),
                convertBoolToBinary(abit), convertBoolToBinary((abit ^ bbit) ^ cbit),
                convertBoolToBinary((abit & bbit) | (bbit & cbit) | (abit & cbit)));

            cbit = false;
            bbit = true;
            abit = false;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit),
                convertBoolToBinary(abit), convertBoolToBinary((abit ^ bbit) ^ cbit),
                convertBoolToBinary((abit & bbit) | (bbit & cbit) | (abit & cbit)));


            cbit = false;
            bbit = false;
            abit = true;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit),
                convertBoolToBinary(abit), convertBoolToBinary((abit ^ bbit) ^ cbit),
                convertBoolToBinary((abit & bbit) | (bbit & cbit) | (abit & cbit)));


            cbit = true;
            bbit = true;
            abit = false;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit),
                convertBoolToBinary(abit), convertBoolToBinary((abit ^ bbit) ^ cbit),
                convertBoolToBinary((abit & bbit) | (bbit & cbit) | (abit & cbit)));


            cbit = true;
            bbit = false;
            abit = true;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit),
                convertBoolToBinary(abit), convertBoolToBinary((abit ^ bbit) ^ cbit),
                convertBoolToBinary((abit & bbit) | (bbit & cbit) | (abit & cbit)));

            cbit = false;
            bbit = true;
            abit = true;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit),
                convertBoolToBinary(abit), convertBoolToBinary((abit ^ bbit) ^ cbit),
                convertBoolToBinary((abit & bbit) | (bbit & cbit) | (abit & cbit)));

            cbit = true;
            bbit = true;
            abit = true;

            Console.WriteLine(format, convertBoolToBinary(cbit), convertBoolToBinary(bbit),
                convertBoolToBinary(abit), convertBoolToBinary((abit ^ bbit) ^ cbit),
                convertBoolToBinary((abit & bbit) | (bbit & cbit) | (abit & cbit)));


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TruthTableGenerator.GenerateTable();
        }
    }
}
