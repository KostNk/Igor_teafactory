using System;
using task5.Interfaces;

namespace task5.Classes;

/// <summary>
/// Класс добавки к  чаю - Молоко
/// </summary>

public class Milk : IAdditive
{
    public string GetName() 
    {
     return "Молоко";
    }
    public double GetCost()
    {
      return  0.5;
    }
    public string GetAdditiveId()
    {
        return "A2";
    }
}