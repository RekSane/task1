int from = 12;
int to = 35;
int sum = 0;
int count = 0;

for (int i = from; i <= to; i++)
{
    bool isPrime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false; break;
        }
    }

    if (isPrime == true)
    {
        sum += i;
        count += 1;
    }   
}

double avg = (double)sum / count;
Console.WriteLine("Avarage: {0}", avg);