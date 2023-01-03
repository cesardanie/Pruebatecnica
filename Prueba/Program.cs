using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Prueba
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.DiagonalDifference(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        class Result
        {


            public static int DiagonalDifference(List<List<int>> arr)
            {
                int sum = 0;
                int primervalor = 0, segundovalor = 0, tercervalor = 0, totalprimeradiagonal = 0;
                int secprimer = 0, secsegundo = 0, sectercero = 0, sectotal = 0, total = 0;
                foreach(List<int> arrTemp in arr)
                {
                    if(sum==0)
                    {
                        primervalor = arrTemp[0];
                    }
                    if (sum == 2)
                    {
                        sectercero = arrTemp[0];
                    }
                    if (sum == 4)
                    {
                        secsegundo = arrTemp[0];
                        segundovalor = arrTemp[0];
                    }
                    if (sum == 6)
                    {
                        secprimer = arrTemp[0];
                    }
                    if (sum == 8)
                    {
                        tercervalor = arrTemp[0];
                    }

                    sum++;

                }


                
                totalprimeradiagonal = primervalor + segundovalor + tercervalor;
                sectotal = secprimer + secsegundo + sectercero;
                return total = sectotal - totalprimeradiagonal;

            }

    }
}
}
