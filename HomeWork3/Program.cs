// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число > ");
string ournumber = Console.ReadLine();
int First = Convert.ToInt32(ournumber);


if(First % 2 == 0)
{
    Console.WriteLine("Your number allowed");
}
else
{
    Console.WriteLine("Your number is not allowed");
}
