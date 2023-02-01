// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число >");

string firstnumber = Console.ReadLine();

Console.Write("Введите второе число >");

string secondnumber = Console.ReadLine();

Console.Write("Введите третье число >");

string thirdnumber = Console.ReadLine();


int First = Convert.ToInt32(firstnumber);
int Second = Convert.ToInt32(secondnumber);
int Third = Convert.ToInt32(thirdnumber);

int max = First;
if(max < First)
{
    max = Second;
}
if(max < Second)
{
    max = Second;
}
if(max < Third)
{
    max = Third;
}

Console.WriteLine("Максимальное число: " + max);