// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
//Пример: для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

/*Console.WriteLine("Введите число 8: ");
int f = Convert.ToInt32(Console.ReadLine());

long Fibonachi(int index)
{
    if (index >= 0)
    return positive(index);
    return negative(index);
    
    long positive(int i)
    {
        long f0 = 0, f1 = 1;
        for (; i> 0;i--)
        {
            (f0,f1) = (f1,f0+f1);
        }
        return f0;
    }
        long negative(int i)
        {
           long f0 = 0, f1 = 1;
           for(; i<0; i++)
           {
             (f0,f1) = (f1-f0,f0);
           } 
           return f0;
        }
}

for (int k = -8; k <= 8; k++)
{
    Console.Write("{0,4}", Fibonachi(k));
}*/


