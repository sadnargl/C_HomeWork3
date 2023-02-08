Console.Write ("Введите число: ");
if (int.TryParse (Console.ReadLine(), out int i))
{
    for (int j = 1; j <= Math.Abs(i); j++) // Math.Abs(i) захватить отрицательные числа
    {
        if (i>=0) 
        {
        Console.Write ($"{Math.Pow (j,3)} ");
        }
        else
        {
            Console.Write ($"{Math.Pow (j*(-1),3)} ");
        }
    }
}
else
{
Console.WriteLine ("Вы ввели не числo, либо не целое число, либо слишком большое число");        
}