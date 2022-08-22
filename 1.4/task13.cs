Console.WriteLine("Введите число ");
int numbers = Convert.ToInt32(Console.ReadLine());
string stringNumbers = Convert.ToString(numbers);
if (stringNumbers.Length > 2)
{
    Console.WriteLine("Третья цифра введенного числа "+ stringNumbers[2]);    
}
else Console.WriteLine("Третьей цифры нет"); 