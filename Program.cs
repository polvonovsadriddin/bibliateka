// вариант 12 средний уровень лабараорная 6,2


using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;




Random rnd = new Random();



Console.Write(" Исходная матрица:");
Console.WriteLine();
int[,] mas3 = new int[5, 5];
for (int i = 0;i<mas3.GetLength(0);i++)
{
    for (int j = 0;j<mas3.GetLength(1);j++)
    {
        mas3[i,j]= rnd.Next(100, 999);
        Console.Write(mas3[i,j]+" ");
    }
    Console.WriteLine();
}


int aa= LIBR.LIBR.Add(mas3);

int[] mas4 = new int[5];

for (int i = 0; i <6; i++)
{
    for (int j =0 ; j < 1; j++)
    {
        mas4[0] = mas3[0, aa];
        mas4[1] = mas3[1, aa];
        mas4[2] = mas3[2, aa];
        mas4[3] = mas3[3, aa];
        mas4[4] = mas3[4, aa];
    }
}
Console.WriteLine();

Console.Write(mas4[0] + " ");
Console.Write(mas4[1] + " ");
Console.Write(mas4[2] + " ");
Console.Write(mas4[3] + " ");
Console.Write(mas4[4] + " ");






























































































































































//int one = 0;
//double[] mas2 = new double[6];



//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(0); j++)
//    {
//        mas1[i, j] = rnd.Next(1, 10);
//        Console.Write(mas1[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int index = 0;


//double qu = MyLibrary.MyLIbrary.Zad(mas1);

//Console.WriteLine(qu);


//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(0); j++)
//    {

//    }
//    Console.WriteLine();
//}

//for (int i = 0; i <= mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(1); j++)
//    {
//        if (i == j)
//        {

//        }
//    }
//}















