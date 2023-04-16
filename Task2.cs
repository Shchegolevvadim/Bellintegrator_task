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
int[] CreateArray(int count)
{
    return new int[count];
}
void FillArray2( int[,] matrix, int[] array)
{int  N = matrix.GetLength(0);

   
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
        
        array[i] = matrix[i, N - 1 - i];
        }
    }
}     
 string PrintArray2(int[] array)
 {
    int count = array.Length;
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

void Found(int []arr){
int mincount = arr[arr.Length - 1];
for (int k = 0; k < arr.Length; k++){
    int c = arr.Length/2;
    if (k == c){break;

    }
    if (arr[k] < mincount){
    mincount = arr[k];
    }
Console.WriteLine(mincount);
}      
}


int[,] matrix = new int[5, 5];

FillArray(matrix);
PrintArray(matrix);
int[] arr = CreateArray(matrix.GetLength(0));
Console.WriteLine();
FillArray2(matrix, arr);
Console.WriteLine(PrintArray2(arr));
Found(arr);



