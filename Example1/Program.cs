// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double GetPower(double a,double b) {
    if (b != 0){
    double result = 1;
    for (int i=1; i<=b; i++){
        result = result*a;
    } return result;
    } else {return 1;}
 }
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число больше 0");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write(GetPower(x,y));