// 64. Задайте N. Выведите все значения от N до 1 через рекурсию.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); 
string Numbers(int a, int b)
    {
      return a<=b ? Numbers(a+1, b) + $"{a} " : String.Empty;  
    }
    Console.WriteLine(Numbers(a,b)); 
