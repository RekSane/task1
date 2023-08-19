Console.Write("1. ededi girin: "); // 1
int a = Convert.ToInt32(Console.ReadLine()); // 1
Console.Write("2. ededi girin: "); // 1
int b = Convert.ToInt32(Console.ReadLine()); // 1

while (a > b) // n+1
{
    Console.WriteLine("Yeniden girin. (Birinci eded ikinciden kicik olmalidir.)"); // n
    Console.Write("1. ededi girin: "); // n
    a = Convert.ToInt32(Console.ReadLine()); // n
    Console.Write("2. ededi girin: "); // n
    b = Convert.ToInt32(Console.ReadLine());} // n

int sum = 0; // 1
while (a <= b) // n+1
{
    sum += a; // n
    a++; // n
}
// O(n)
Console.WriteLine("Toplam: " + sum);
