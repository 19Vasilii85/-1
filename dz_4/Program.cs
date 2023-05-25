Console.Clear();
Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());
int max = Math.Max(number_1, Math.Max(number_2, number_3));
Console.WriteLine($"максимальное число равно: {max} из введенных чисел: {number_1}, {number_2}, {number_3}");
