// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int Prompt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int row = Prompt("Количетсво строк > ");
int column = Prompt("Количество столбцов > ");

void PrintArray(int[,]array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
    System.Console.Write(array[i,j] + "\t");
     }
    System.Console.WriteLine();
}
}


int [,] CreateArray(int row, int column, int min, int max)
{
    var rnd = new Random();
    var array = new int[row, column];

for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = rnd.Next(min, max + 1);
}
}
return array;
}


int[,]myarray = CreateArray(row, column, 1, 20);

PrintArray(myarray);


double sum = 0;

Console.Write($"Среднее арифметическое в каждом столбце: ");

for (int j = 0; j < myarray.GetLength(1); j++)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        
     sum = myarray[i,j] + sum;
    }
double avg = sum / row;  
Console.Write($"{avg:F1}; ");
sum = 0;
}
