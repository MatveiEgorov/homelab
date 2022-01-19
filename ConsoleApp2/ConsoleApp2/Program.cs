using System;

namespace ConsoleApp2
{

    class Program
    {

        static void Main(string[] args)
        {


            /*   int[,] myArray = new int[,]
               {
                   {1, 2, 3 },
                   {4, 5, 6 },
                   {7, 8, 9 }
               };
               int hi = myArray.GetLength(0);
               int len = myArray.GetLength(1);

               for (int i = 0; i < hi; i++)
               {
                   for (int y = 0; y < len; y++)
                   {
                       Console.Write(myArray[i,y] + "\t");
                   }
                   Console.WriteLine();
               }*/





            /*     string[] strArr = new string[]

                      {"sxcsd", "dsfsdf", "dfsdfdsf"};
                  for (int i = 0; i < strArr.Length; i++)
                      Console.WriteLine("№[{0}] = {1}", i, strArr[i]);
                  Console.WriteLine(strArr.Length);
                  Console.WriteLine("Vedite index element");
                  int index = Convert.ToInt32(Console.ReadLine());
                  if (index<=strArr.Length)
                  {
                      Console.WriteLine("vvedite novyy cnroky");
                      strArr[index] = Console.ReadLine();
                  }

                  for (int i = 0; i < strArr.Length; i++)
                      Console.WriteLine("№[{0}] = {1}", i, strArr[i]);

          */
            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[3];
            //arr[2] = new int[4];
            //Console.WriteLine("vedi elems 1 ctroki");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int i1 = 0; i1 < arr[i].Length; i1++)
            //    {
            //        arr[i][i1] = Convert.ToInt32(Console.ReadLine());

            //    };
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int y = 0; y < arr[i].Length; y++)
            //    {
            //        Console.Write(arr[i][y] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //var arr = new[] { 2,3 };
            //var arr2 = new[] { "dfsfsd","sdfsdfsd" };


            (int, string, char, string, int) karteg = (sds: 23, dfg:"ds", fdssd:'F', rwfewf:"daasd", ewr:3213);
            Console.WriteLine(karteg);
            Console.WriteLine(karteg.Item1);
            Console.WriteLine(karteg.Item3);
            Console.WriteLine(karteg.Item5);

            string str = karteg.Item2;
            Console.WriteLine(str);

            bool z= karteg.Item1 <= karteg.Item5 ? true : false;
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
