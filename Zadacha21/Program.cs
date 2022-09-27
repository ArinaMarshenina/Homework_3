int GetNumber(string name, string PointName)
{
    Console.Write($"Введите координату {name} точки {PointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

int x1 = GetNumber("x", "A");
int y1 = GetNumber("y", "A");
int z1 = GetNumber("z", "A");
int x2 = GetNumber("x", "B");
int y2 = GetNumber("y", "B");
int z2 = GetNumber("z", "B");

double Coordinates(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double Length =  Math.Round (Coordinates(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {Length}");