using System;

namespace task5.Interfaces;

/// <summary>
///  Интерфейс для основного компонента чая
/// </summary>

public interface IBeverageBase
{
    string GetName();
    double GetCost();
    string GetBaseId();
}
