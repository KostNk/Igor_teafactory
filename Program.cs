using task5.Classes;
using System;



// Основной метод для проверки системы
public class Program
{
    public static void Main()
    {
        TeaFactory teaFactory = new TeaFactory();

        Console.WriteLine("Сколько чаёв надо нагенерить?");
        int teanum= Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= teanum-1 ; i++)
        {
            TeaRecipe teaRecipe = teaFactory.CreateRandomTea();
            Console.WriteLine("Рецепт чая №{0}: {1}", i+1,teaRecipe.GetDescription());
            Console.WriteLine("Его стоимость: {0}",teaRecipe.GetTotalCost());
            Console.WriteLine();
        }
    }
}