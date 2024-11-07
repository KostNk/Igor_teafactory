using System;
using task5.Interfaces;

namespace task5.Classes;
/// <summary>
/// Класс добавки к  чаю - Мята
/// </summary>

public class Mint : IAdditive
{
    public string GetName()
    {
        return "Мята";
    }
    public double GetCost()
    {
        return 0.4;
    }

    public string GetAdditiveId()
    {
        return "A3";
    }
}
