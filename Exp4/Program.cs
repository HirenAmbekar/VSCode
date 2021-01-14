using System;

namespace exp3
{
    class array
    {
        public static void Main()
        {
            /*declartion of 2D array*/
            int[,] array2 = new int[3, 3] { { 1,2,3} , { 4,5,6} , { 7,8,9 } };
            Console.WriteLine("Two dimensional array:");
            for (int i = 0; i < array2.GetLength(0); i++) {

                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.WriteLine("array2[{0},{1}] = {2}", i, j, array2[i, j]);
                }
            }

            /*declartion of 3D array */
            int[,,] array3 = new int[2, 2, 3] { { { 1, 2, 3 },
                                                     { 4, 5, 6 } },
                                                     { { 7, 8, 9 },
                                                     { 10, 11, 12 } } };
            Console.WriteLine("Three dimensional array:");
            for (int x = 0; x < array3.GetLength(0); x++)
            {
                for (int y = 0; y < array3.GetLength(1); y++)
                {
                    for (int z = 0; z < array3.GetLength(2); z++)
                    {
                        Console.WriteLine("array3[{0},{1},{2}] = {3}", x, y,z, array3[x, y, z] );
                    }
                }                
            }

            /*declartion of Jagged array */
            int[][] array4 = new int[3][]
                  {
                   new int[] { 1, 2, 3 },
                   new int[] { 4, 5, 6, 7, 8},
                   new int[] { 9, 10 }
                  };
            Console.WriteLine("Jagged array:");
            for (int n = 0; n < array4.GetLength(0); n++)
            {
                System.Console.Write("Row({0}): ", n);
                for (int t = 0; t < array4[n].GetLength(0); t++)
                {
                    Console.Write("{0} ", array4[n][t]);
                }
                Console.WriteLine();
            }
                Console.ReadLine();
        }
    }
 }
