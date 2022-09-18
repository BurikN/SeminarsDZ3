/*Задача 19
Console.Write("Введите пятизначное число:");
string num = Console.ReadLine();
Console.WriteLine(pal(num));

string pal(string str)
{
    int len=str.Length;

    if(len==5)
    {
        if (str[0]==str[4] || str[1]==str[3])
          return "Это палиндром";
        else
          return "Не является палиндромом";  
    }
    return "Введенное число не пятизначное";
}
*/
/*Задача 21
int [] NumA = new int [3];
int [] NumB = new int [3];
Console.WriteLine("Введите координаты точки А:");
Console.Write("x=");
NumA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("y=");
NumA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("z=");
NumA[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.Write("x=");
NumB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("y=");
NumB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("z=");
NumB[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Длина вектора составляет:"+ VecLength(NumA,NumB));

double VecLength(int[] arrayA, int[] arrayB)
{
    double longNum = Math.Sqrt(Math.Pow(arrayB[0]-arrayA[0],2)+Math.Pow(arrayB[1]-arrayA[1],2)+Math.Pow(arrayB[2]-arrayA[2],2));
    return Math.Truncate(100*longNum)/100;
}
*/
//Задача 23
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

CubeNum(num);

void CubeNum(int num)
{
    int i = 1;
    while(i < num+1)
    {
        Console.WriteLine(i + "->" + Math.Pow(i,3));
        i++;
    }
}
