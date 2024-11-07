using System;
using task5.Interfaces;

namespace task5.Classes;

/// <summary>
/// Класс для создания случайного чая
/// </summary>
public class TeaFactory
{
   private static readonly Random _random = new();

   private static readonly List<IBeverageBase> TeaBases = new()
   {
       new BlackTea(),
       new GreenTea(),
       new HerbalTea()
   };

   private static readonly List<IAdditive> Additives = new()
   {
       new Milk(),
       new Honey(),
       new Mint()
   };

    private static readonly List<ISpecialTea> Specials = new()
   {
       new EnergyTea(),
       new RelaxTea()
   };

   public TeaRecipe CreateRandomTea()
   {
       // Случайно выбираем базовый чай
       var teaBase = TeaBases[_random.Next(TeaBases.Count)];
       var recipe = new TeaRecipe(teaBase);

       // Случайное количество добавок (от 0 до всех возможных)
       int numberOfAdditives = _random.Next(Additives.Count + 1);

       // Добавляем случайные добавки
       var addedAdditives = new HashSet<int>();
       for (int i = 0; i < numberOfAdditives; i++)
       {
           int additiveIndex;
           do
           {
               additiveIndex = _random.Next(Additives.Count);
           } while (!addedAdditives.Add(additiveIndex)); // Избегаем дублирования добавок

           recipe.AddAdditive(Additives[additiveIndex]);
       }

       // Случайное количество спецэффектов 
       int numberOfSpecials = _random.Next(Specials.Count+1);

       // Добавляем случайные спецэффекты
       var addedSpecial = new HashSet<int>();
       for (int i = 0; i < numberOfSpecials; i++)
       {
           int SpecialIndex;
           do
           {
               SpecialIndex = _random.Next(Specials.Count);
           } while (!addedAdditives.Add(SpecialIndex)); // Избегаем дублирования спецэффектов

           recipe.AddSpecial(Specials[SpecialIndex]);
       }


       return recipe;
   }

}