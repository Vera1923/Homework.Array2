// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9 2 6 9
// 4 6 2 4 3 1



int[,] array = new int[5,5];
void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void PrintArray2()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int c = array[4,j];
            array[4,j] = array[0,j];
            array[0,j] = c;
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


CreateArray();
PrintArray();
PrintArray2();
