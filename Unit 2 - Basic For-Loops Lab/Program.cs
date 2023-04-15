Console.WriteLine("Please enter a number.");

int userinput = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= userinput; i++)
{
    sum = sum + i;
}

Console.WriteLine(sum);