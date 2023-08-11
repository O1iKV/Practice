//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "День недели только цифра от 1 до 7 соответственно";
string check(int number)
{
if (number >= 6 && number < 8) ss = "Да";  //Выходной 
if (number >= 1 && number < 6) ss = "Нет"; //Будний
return ss;
}
System.Console.WriteLine(check(number));

