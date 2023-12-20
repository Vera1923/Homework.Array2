//  Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
// 4 3 1 => 2 6
// 2 6 9 4 6
// 4 6 2


int[,] array = new int[3, 3];

        void CreateArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            }
        }
        void PrintArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    System.Console.Write(array[i, j] + " ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
        void MinElement()
        {
            int i1, j1, mini=0, minj=0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < array[mini, minj])
                    {
                        mini = i;
                        minj = j;
                    }
                }
            }
            Console.WriteLine("\nМинимальный элемент: {0}", array[mini, minj]);
            Console.WriteLine();
            int[,] array2 = new int[2,2];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                if (i >= mini)
                {
                    i1 = i;
                }
                else
                {
                    i1 = i +1;
                }
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (j >= minj)
                    {
                        j1 = j;
                    }
                    else
                    {
                        j1 = j +1;
                    }
                    array2[i, j] = array[i1, j1];
                    Console.WriteLine("{0}", array2[i, j]);
                }
                Console.Write("\n");

            }

        }
        CreateArray();
        PrintArray();
        MinElement();




