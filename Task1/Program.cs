// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void FillMassiv(int[,] massiv)
{
    Random num = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = num.Next(-10, 11);
        }
    }
}

void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MassSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] >= array[i, k])
                {
                    int temporary = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
    }

}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillMassiv(array);
PrintMass(array);
Console.WriteLine();
MassSort(array);
PrintMass(array);