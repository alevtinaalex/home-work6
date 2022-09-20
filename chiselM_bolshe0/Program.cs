// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Сколько чисел нужно ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
EnterNumbers(numbers);
MoreZero(numbers);

void EnterNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write("Введите {0} число ", i + 1);
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void MoreZero(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            count = count + 1;
    }
    System.Console.WriteLine($"Количество чисел больше нуля = {count}");
}
