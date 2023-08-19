Console.WriteLine("Nece eded gireceksiniz?: "); // n
int count = Convert.ToInt32(Console.ReadLine()); // n

int total = 0; // 1
for (int i = 1; i <= count; i++) // n
{
    Console.Write("Ededi girin: "); // n
    int num= Convert.ToInt32(Console.ReadLine()); // 1
    total += num; // 1
}

double average = (double)total / count; // 1
Console.WriteLine("Ortalama: " +  average); // 1

// O(n)