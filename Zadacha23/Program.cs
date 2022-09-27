int N()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());     
}

void GetPrint(int N)
{    
    int count = 1;
    Console.WriteLine($"Таблица кубов чисел от 1 до числа {N}:  ");
    while (count <= N)
{ 
   Console.Write(Math.Pow((count),3) + " ");
   count++;
}
}

GetPrint(N());