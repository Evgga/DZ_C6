// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.WriteLine ("Введите числа через запятую: ");
string? numbers = Console.ReadLine();
string [] manualNumbers = new string [numbers.Length];
int k = 0;
for (int i = 0; i < manualNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    k++;
  }
  else
  {
    manualNumbers[k] = manualNumbers[k]+$"{numbers[i]}";
  }
}

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
}
k++;


int [] resultNumbers = new int[k];
PrintArray (resultNumbers, manualNumbers);
int sum = 0;
for (int i = 0; i < k; i++)
{
  if (resultNumbers[i] > 0)
  {
    sum++;
  }
}
Console.WriteLine ("-> " + sum);



int[] InputArrayManually (int M) 
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < M; i++)
    {
        if (i == M - 1) Console.Write($"{array[i]} -> ");
        else Console.Write($"{array[i]}, "); 
    }
    return array;
}

int PositiveNumbersCounter(int[] array) 
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            counter++;
        }
    }
    Console.Write(counter);
    return counter;
}

PositiveNumbersCounter(InputArrayManually(5));


