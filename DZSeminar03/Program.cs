
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/
//Решение задачи 19
/*
void IndexNum(int num)
{
    int a = num / 10000; // первое число
    int b = num % 10000 / 1000; // второе число
    int c = num % 1000 / 100; // третье число
    int d = num % 100 / 10; // четвертое число
    int e = num % 10; // пятое число
    if(a == e && b == d)
    {
        Console.WriteLine("Число " + num + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число " + num + " Не является палиндромом");
    }
}


int num = 12821;
IndexNum(num);
*/


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
//Решение Задачи 21 
/*
double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x1 - x2;
    double yDistance = y1 - y2;
    double zDistance = z1 - z2;
    
    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance,2) + Math.Pow(zDistance,2));
}

double xA, yA, xB, yB, zA, zB;
double distance;

Console.Write("input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());
distance = GetDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine(distance);
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
//Решение Задачи 23.

/*
Console.Write("Введите число шагов построения таблицы кубов = ");
double Cube = Convert.ToDouble(Console.ReadLine());

double Length = Cube;
for(int index = 1; index <= Length; index++)
{
    Console.Write(+ Math.Pow(index, 3.0 / 1) + " ");
}
*/
