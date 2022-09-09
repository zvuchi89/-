Console.Write("Введите число:");

long n = Convert.ToInt64(Console.ReadLine());

if (n > 99)
{
Console.Write("Третья цифра  "+ n.ToString()+" = "+ n.ToString()[2]);
}
if(n < 100 )
 {
    Console.WriteLine("третьей цифры нет");
 }
