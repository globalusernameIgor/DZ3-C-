/*Напишите программу, которая принимает на вход трехзначное число и на выходе показывает **вторую** цифру этого числа
 
 // 456 -> 5
 // 782 -> 8
 // 918 -> 1*/

int r = new Random().Next(100, 999);

int b = (r / 10)% 10;

Сonsole.WriteLine($"Вторая цифра числа {b}");

//3. Напишите программу, которая будет принимать на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет 

Сonsole.WriteLine("Введите номер загаданного дня недели: ");
int Date = int.Parse(Console.ReadLine()!);
if ( num >= 1 && num <= 5 )
{
    Console.Write(" Это не выходной ");
}
else if ( num >= 6 && num <= 7)
{
    Console.Write(" Это выходной ")
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int Promt (string message);
{

Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}
int GetThirdRank(int number)
{

    while (number > 999)
{

     number /= 10;
}
return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Promt("Введите число > ");
if (ValidateNumber (number) )
{
    Сonsole.WriteLine (GetThirdRank (number));
}
    


