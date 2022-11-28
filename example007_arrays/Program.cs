
//string[,] table = new string[2, 5];
//Strung.Empty - инициализация строк
// table[0,0] - первый столбик     table[0,1] - второй столбик   table[0,4] - пятый последний столбик
//table[1,0] - вторая последняя строка

/*table[1,2]="слово";
for (int rows=0; rows<2; rows++)
{
    for (int columns=0; columns<5;columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
}*/



void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1;10)
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);

