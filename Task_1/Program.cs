// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


double[,] GenerateArray(int row, int column, int min, int max)
{
double[,]Array = new double [row,column];
var random = new Random();
for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {

        Array[i, j] = random.NextDouble() * (max - min) + min;
        Array[i,j] = Math.Round(Array[i,j], 2);
        }
    }
    return Array;
}



void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = Prompt("Количество строк >");
int column = Prompt("Количество столбцов >");
int min = Prompt("Минимальное значение элемента массива >");
int max = Prompt("Максимальное значение элемента массива >");
double[,]Array = GenerateArray(row, column, min, max);
PrintArray(Array);