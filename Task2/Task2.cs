Console.WriteLine ("Вводим координаты, первой точки (x, y, z)");
int x1 = InputFigureFromConsole ("Введите х: ");
int y1= InputFigureFromConsole ("Введите y: ");
int z1 = InputFigureFromConsole ("Введите z: ");
Console.WriteLine ("Вводим координаты, второй точки (x, y, z)");
int x2 = InputFigureFromConsole ("Введите х: ");
int y2= InputFigureFromConsole ("Введите y: ");
int z2 = InputFigureFromConsole ("Введите z: ");
double result = Math.Sqrt (Math.Pow ((x1-x2),2) + Math.Pow ((y1-y2),2) + Math.Pow ((z1-z2),2));
Console.WriteLine ($"Расстояние между двумя точками: {result}"); 

int InputFigureFromConsole (string invitation)
{
    Console.Write (invitation);
    int xyz;
    while (!int.TryParse (Console.ReadLine(), out xyz))
    {
        Console.WriteLine ("Ошибка ввода числа");
        Console.Write (invitation);
    }
    return xyz;
}


