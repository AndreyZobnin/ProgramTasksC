Console.Write("Какое будет количество чисел массива?"); //Приглашение вопрос
int N = Convert.ToInt32(Console.ReadLine()); // Конвертируем
int [] massiv = new int [N]; // создаем массив количество берем из консоли N
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введи индексы", + i + ":");
    massiv[i] = Convert.ToInt32(Console.ReadLine());
    // massiv[i] = new Random().Next(N);
}
int Minimum (int[] massiv) {
    int minimum = massiv [0];
    for (int j = 1; j < N; j++)
    {
        if (massiv[j] < minimum) {
            minimum = massiv[j];
        }
    }
    return minimum;
}
int Maximum (int[] massiv) {
    int maximum = massiv [0];
    for (int i = 1; i < N; i++)
    {
        if (massiv[i] > maximum) {
            maximum = massiv[i];
        }
    }
    return maximum;
}
int maximum = Maximum(massiv);
int minimum = Minimum(massiv);
int tmp  = maximum - minimum;
Console.WriteLine("разница " + tmp );