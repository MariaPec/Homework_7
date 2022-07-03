//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

Console.WriteLine("Массив, в котором будем искать элемент => ");
PrintArray(myarray);

int rowPosition = Prompt("Введите позицию элемента в строке > ");
int columnPosition = Prompt("Введите позицию элемента в столбце > ");
int number;

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        if (i == rowPosition-1 && j == columnPosition-1)
        {
            number = myarray[i, j];
            Console.WriteLine($"Значение элемента на заданной позиции равно {number}");
            Environment.Exit(0);
        }      
    }
}

Console.WriteLine($"Такого элемента нет");