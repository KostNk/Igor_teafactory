using System;
using task5.Interfaces;

namespace task5.Classes;
/// <summary>
/// Класс травяного чая
/// </summary>

public class HerbalTea : IBeverageBase
{
    public string GetName()
    {   
       return "Травяной чай";
    }
    public double GetCost()
    { 
        return 2.0;
    }
    public string GetBaseId()
    {
        return "4";
    }
}