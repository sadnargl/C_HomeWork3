Console.Write ("Введите пятизначное число: ");
if (int.TryParse (Console.ReadLine(), out int i))
{
    i = Math.Abs(i); //чтобы захватить числа со знаком минус, так, на всякий случай
    if (i.ToString().Length != 5)
        {
            Console.WriteLine ("Вы ввели не пятизначное числo");  
        }
         else
        {
            for (int j = 0; j <= i.ToString().Length/2; j++) //не хотел 5-ку указывать, лучше сразу универсальную формулу
            {
            if (i.ToString()[j] != i.ToString()[i.ToString().Length-1-j])
                {
                    Console.WriteLine ("Число не палиндром");
                    Environment.Exit( 0 ); //Не хотел goto использовать

                }
             }
            Console.WriteLine ("Число палиндром");
        }
}
else
{
Console.WriteLine ("Вы ввели не числo, либо не целое число, либо слишком большое число");        
}
