using System;

namespace task5.Interfaces;
/// <summary>
/// Интерфейс для добавок к чаю
/// </summary>
public interface IAdditive
{
    string GetName();
    double GetCost();
    string GetAdditiveId();
}
