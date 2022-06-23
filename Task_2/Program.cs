// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int number)
  {
    int count = Convert.ToString (number).Length;
    int intermediate = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      intermediate = number - number % 10;
      result = result + (number - intermediate);
      number = number / 10;
    }
   return result;
  }

int sumNumbers = SumNumbers(number);
Console.WriteLine("Сумма цифр введенного Вами числа = " + sumNumbers);