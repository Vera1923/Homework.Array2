//  Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9

Console.WriteLine("Введите размеры массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[num1,num2];
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
Console.WriteLine("Введите координаты: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

void FindElement()
{
    if(a>num1 && b <num2 )
    {
        Console.WriteLine("Такого элемента не существует.");
    }
    else
    {
        Console.WriteLine("=> "+ array[a,b]);
    }
}


CreateArray();
PrintArray();
FindElement();
