using System;
using task5.Interfaces;

namespace task5.Classes;
/// <summary>
/// Класс зелёного чая
/// </summary>

public class GreenTea : IBeverageBase
{
    public string GetName()
    {
        return "Зеленый чай";
    } 
    public double GetCost()
    { 
        return 1.8;
    }
    public string GetBaseId()
    {
        return "3";
    }
}