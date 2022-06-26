Console.Write("Input first number: ");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input second number: ");
int number_2 = Convert.ToInt32 (Console.ReadLine());
int max = number_1;

if (number_1 > number_2)
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " -> max = " + number_1);
else
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " -> max = " + number_2);