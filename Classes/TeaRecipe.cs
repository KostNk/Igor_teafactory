using System;
using System.Runtime.CompilerServices;
using task5.Interfaces;

namespace task5.Classes;


// Класс для представления рецепта чая
public class TeaRecipe
{
    private IBeverageBase _baseTea;
    private List<IAdditive> _additives = new List<IAdditive>();
    private List<ISpecialTea> _specials = new List<ISpecialTea>();

    public TeaRecipe(IBeverageBase baseTea)
    {
        _baseTea = baseTea;
    }

    public void AddAdditive(IAdditive additive)
    {
        _additives.Add(additive);
    }

    public void AddSpecial(ISpecialTea special)
    {
        _specials.Add(special);
    }

    public double GetTotalCost()
    {
        double totalCost = _baseTea.GetCost();
        foreach (var additive in _additives)
        {
            totalCost += additive.GetCost();
        }
        return totalCost;
    }

    public string GetDescription()
    {
        string description = _baseTea.GetName();
        if (_additives.Count > 0)
        {
            description += " с добавками: " ;
            foreach (var additive in _additives)
            {
                description = description+additive.GetName() + " ";
            }
        }

        if (_specials.Count > 0)
        {
            description += " со спецэффектами: " ;
            foreach (var special in _specials)
            {
                description = description+special.GetName() + " ";
            }
        }
        return description;
    }
}
