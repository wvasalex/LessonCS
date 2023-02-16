// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Решение
// Console.WriteLine("Input 2 numbers");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num1 > num2 ? num1 : num2);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Решение
// Console.WriteLine("Input 3 numbers");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Max(num1, Math.Max(num2, num3)));


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num % 2 == 0 ? "да" : "нет");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
while (current <= num) {
    if (current % 2 == 0) {
        Console.WriteLine(current);
    }

    current++;
}