//Дан массив NxN. Напишите программу на C# которая находит минимальный элемент побочной диагонали,
// без учёта элемента пересечения главной и побочной диагонали.
//Для примера приведена матрица 5х5. Побочная диагональ выделена жирным,
// минимальный элемент побочной диагонали – красным и подчеркнут:

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 100);

        }
    }
}  
void PrintArray(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             Console.Write($"{matr[i, j]} ");
         }
     Console.WriteLine();
    }
}

void Method (int[,] matr)
{ 
    for (int i = matr.GetLength(0) - 1; i > 0; i--)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++){
        int N = matr.GetLength(1);
        int mincount = matr[i, N - 1 - i];
        
        
        if(i == j){break;
           
            }
        if(mincount < matr[i, N - 1 - i])
           {
            mincount = matr[i,j];
            
           }
           Console.WriteLine(mincount);
           
        }
     
    }
    
}      

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Method(matrix);

