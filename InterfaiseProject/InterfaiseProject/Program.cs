using System;
using static InterfaiseProject.Interfais;
using static InterfaiseProject.RealisInterfais;

public class MainClass
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int size = 100;
        IArrayManipulator array = new NumberArray(size);

        for (int i = 0; i < size; i++)
        {
            array.Add(random.Next(50));
        }

        array.Show();

        long searchValue = random.Next(50);
        if (array.Find(searchValue))
        {
            Console.WriteLine($"Значение было найдено: {searchValue}");
        }
        else
        {
            Console.WriteLine($"Не удалось найти значение: {searchValue}");
        }

        Console.WriteLine($"Минимальное значение: {array.FindMin()}");
        Console.WriteLine($"Максимальное значение: {array.FindMax()}");
    }
}
