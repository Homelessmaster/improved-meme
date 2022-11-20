//task 54
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(1); k++)
            {
                for (int m = 0; m < matrix.GetLength(1) - k; m++)
                    if (matrix[i, m] < matrix[i, m + 1])
                    {
                        int tmp = matrix[i, m];
                        matrix[i, m] = matrix[i, m + 1];
                        matrix[i, m + 1] = tmp;
                    }
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк и столбцов >>> ");
string[] size = Console.ReadLine().Split(' ');
int n = int.Parse(size[0]);
int m = int.Parse(size[1]);
int[,] matrix = new int [n, m];

InputMatrix(matrix);

Console.WriteLine();

ChangeMatrix(matrix);
*/



//task 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void SummLineMatrix(int[,] matrix, int[] array)
{
    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int Summ = 0; 

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Summ = Summ + matrix[i, j];
        }

        array[i] = array[i] + Summ;
    }

    return; 
}

int MinSumm(int[] array)
{
    int row = 1;
    int minSummRow = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minSummRow)
        {
            minSummRow = array[i];
            row = i+1;
        } 

    }
    return row;
}


Console.Clear();
Console.Write("Введите количество строк и столбцов >>> ");
string[] size = Console.ReadLine().Split(' ');
int n = int.Parse(size[0]);
int m = int.Parse(size[1]);
int[,] matrix = new int [n, m];
int[] array = new int[matrix.GetLength(0)];
InputMatrix(matrix);


SummLineMatrix(matrix, array);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"строка: {MinSumm(array)}");
*/





//task 58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}


void ProductOfTwoMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            int summ = 0;
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                int row = matrix1[i, k] * matrix2[k, j];
                summ = summ + row;
            }
            matrix3[i,j] = summ; 
        }

    }
    Console.WriteLine();
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            Console.Write($"{matrix3[i,j]} \t");
        }
        Console.WriteLine();
    } 
}



Console.Clear();

Console.Write("Введите количество строк и столбцов первой матрицы >>> ");
string[] size1 = Console.ReadLine().Split(' ');
int n1 = int.Parse(size1[0]);
int m1 = int.Parse(size1[1]);
int[,] matrix1 = new int [n1, m1];
InputMatrix(matrix1);

Console.Write("Введите количество строк и столбцов второй матрицы >>> ");
string[] size2 = Console.ReadLine().Split(' ');
int n2 = int.Parse(size2[0]);
int m2 = int.Parse(size2[1]);
int[,] matrix2 = new int [n2, m2];
InputMatrix(matrix2);

int[,] matrix3 = new int [n1, m1];
Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
ProductOfTwoMatrix(matrix1, matrix2, matrix3);
*/



//task 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
void InputMatrix(int[,] matrix)
{
    int num = 0;

    for (int k = 0; k < 4; k++)  matrix[0, k] = num++;
    for (int k = 1; k < 4; k++)  matrix[k, 3] = num++;
    for (int k = 2; k > -1; k--) matrix[3, k] = num++;
    for (int k = 2; k > 0; k--)  matrix[k, 0] = num++;
    for (int k = 1; k < 3; k++)  matrix[1, k] = num++;
    for (int k = 2; k < 3; k++)  matrix[k, 2] = num++;
    for (int k = 1; k > 0; k--)  matrix[2, k] = num++;


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите количество строк и столбцов первой матрицы >>> ");
string[] size1 = Console.ReadLine().Split(' ');
int n1 = int.Parse(size1[0]);
int m1 = int.Parse(size1[1]);
int[,] matrix1 = new int [n1, m1];
InputMatrix(matrix1);
*/


