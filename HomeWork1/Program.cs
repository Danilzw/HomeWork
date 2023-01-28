// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число >");

string firstnumber = Console.ReadLine();

Console.Write("Введите второе число число >");

string secondnumber = Console.ReadLine();

int First;
int Second;

First = Convert.ToInt32(firstnumber);
Second = Convert.ToInt32(secondnumber);

if(First > Second)
{
    Console.WriteLine(First + " Большее");
}
else
{
    Console.WriteLine(Second +" Большее");
}
