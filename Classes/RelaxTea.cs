using System;
using task5.Interfaces;

namespace task5.Classes;

/// <summary>
/// Класс специального чая - расслабляющий
/// </summary>

public class RelaxTea : ISpecialTea
{
    public string GetName()
    {
        return "Расслабляющий чай";
    }
    public double GetCost()
    {
        return 2.3;
    }
    public string GetSpecialEffect()
    {
        return "Эффект: расслабление и спокойствие";
    }

    public string GetBaseId()
    {
        return "E2";
    }
    public string GetSpecialId()
    {
        return "E2";
    }
}

