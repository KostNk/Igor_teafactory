using System;

namespace task5.Classes;
using task5.Interfaces;
/// <summary>
/// Класс специального чая - Энергетический
/// </summary>


public class EnergyTea : ISpecialTea
{
    public string GetName() 
    {
        return "Энергетический чай";
    } 
    public double GetCost()
    {
        return 2.5;
    }
    public string GetSpecialEffect() 
    {
        return "Эффект: заряд бодрости!";
    }
    public string GetBaseId()
    {
        return "E1";
    }
    public string GetSpecialId()
    {
        return "E1";
    }
}
