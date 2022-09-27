int n = 0;
while ( (n < 10000) || (n > 100000) )
{
   Console.Write("Пятизначное число: ");
   n = Convert.ToInt32(Console.ReadLine());
}
if (n / 10000 == n % 10 && n % 10000 / 1000 == n % 100 / 10)
   Console.WriteLine("Число {0} является палиндромом!", n);
else
   Console.WriteLine("Число {0} не является палиндромом!", n);