using System;
using task5.Interfaces;

namespace task5.Classes;


/// <summary>
/// Класс черного чая
/// </summary>

public class BlackTea : IBeverageBase
{
    public string GetName()
    {
        return "Черный чай";
    }
    public double GetCost()
    {
        return 1.5;
    }
    public string GetBaseId()
    {
        return "1";
    }
}