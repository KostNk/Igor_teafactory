using System;
using task5.Interfaces;

namespace task5.Classes;

/// <summary>
/// Класс добавки к  чаю - Мед
/// </summary>
public class Honey : IAdditive
{
    public string GetName()
    {
        return "Мед";
    }
    public double GetCost()
    {
        return 0.7;
    }
    public string GetAdditiveId()
    {
        return "A1";
    }
}

