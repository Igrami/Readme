//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, 
//значения которых лежат в отрезке [20,90].

using System;

class Program {
    static void Main() {
        int[] numbers = new int[] { 14, 75, 36, 59, 25, 90, 10, 60, 87, 27 };
        int count = 0;

        foreach (int number in numbers) {
            if (number >= 20 && number <= 90) {
                count++;
            }
        }

        Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90]: " + count);
    }
}